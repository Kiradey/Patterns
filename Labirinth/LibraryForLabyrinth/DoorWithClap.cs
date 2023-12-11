using System;

namespace LibraryForLabyrinth
{
    public class DoorWithClap : Door
    {
        public DoorWithClap(Room room1, Room room2) : base(room1, room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1),"Комната не может быть пустой.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2),"Комната не может быть пустой.");
            }
        }
       // public DoorWithClap() { }
        public override void Enter()
        {
            Console.WriteLine("Хлопок!");
        }
    }
}
