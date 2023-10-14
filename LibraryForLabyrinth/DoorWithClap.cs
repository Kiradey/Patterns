using System;
namespace LibraryForLabyrinth
{
    public class DoorWithClap : Door
    {
        public DoorWithClap(Room _room1, Room _room2):base(_room1, _room2, true) { }
        public override void Enter()
        {
            Console.WriteLine("Хлопок!");
        }
    }
}
