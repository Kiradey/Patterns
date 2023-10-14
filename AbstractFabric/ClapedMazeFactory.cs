using System;
using LibraryForLabyrinth;

namespace AbstractFabric
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Door MakeDoor(Room _room1, Room _room2)
        {
            return new DoorWithClap(_room1, _room2);
        }

        public override Room MakeRoom(int Number)
        {
            return new RoomWithClap(Number);
        }
    }
}