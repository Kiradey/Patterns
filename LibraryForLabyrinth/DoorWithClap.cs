using System;

namespace LibraryForLabyrinth
{
    public class DoorWithClap : Door
    {
        public DoorWithClap(Room room1, Room room2) : base(room1, room2, true)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException("Комната не может быть пустой.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException("Комната не может быть пустой.");
            }
        }
        public override void Enter()
        {
            Console.WriteLine("Хлопок!");
        }
    }
}
