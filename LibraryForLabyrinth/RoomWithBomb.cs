using System;
namespace LibraryForLabyrinth
{
    public class RoomWithBomb : Room {
        private static Random rand = new Random();
        public RoomWithBomb(int roomNumber) : base(roomNumber) { }
        public void Explode()
        {         
            base.Enter();
            if (rand.Next(2) == 1)
            {
                Console.WriteLine("Комната взорвана!");
                SideInit.OfType<WallWithBomb>().ToList().ForEach(x => x.Explode());
            }
        }
    }
}