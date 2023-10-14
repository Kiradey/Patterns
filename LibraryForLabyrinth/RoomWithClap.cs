using System;
namespace LibraryForLabyrinth
{
    public class RoomWithClap : Room
    {
        private readonly DoorWithClap _clapDoor;
        private readonly Room _room1;
        private readonly Room _room2;
        public RoomWithClap(int roomNumber) : base(roomNumber)
        {
            _room1 = new Room(1);
            _room2 = new Room(2);

            _clapDoor = new DoorWithClap(_room1, _room2);
        }
        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Хлопок! Вы встретили хлопушку!");
            _clapDoor.Enter();
        }
    }
}