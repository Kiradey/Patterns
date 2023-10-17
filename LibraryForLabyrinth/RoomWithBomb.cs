using System;
namespace LibraryForLabyrinth
{
    public class RoomWithBomb : Room {
        private static Random Rand = new Random();
        public RoomWithBomb(int roomNumber) : base(roomNumber) { }
        public void Explode()
        {         
            base.Enter();
            if (Rand.Next(2) == 1)
            {
                Console.WriteLine("Комната взорвана!");
                if (SideInit != null)
                {
                    SideInit.OfType<WallWithBomb>().ToList().ForEach(x => x.Explode());
                }
            }
        }
    }
}