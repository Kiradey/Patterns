using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
using LibraryForLabyrinth;
namespace Prototype
{
    internal class MazePrototypeFactory : MazeFactory
    {
        private Maze _protoMaze;
        private Room _protoRoom;
        private Wall _protoWall;
        private Door _protoDoor;
        public MazePrototypeFactory(Maze protoMaze, Room protoRoom, Wall protoWall, Door protoDoor)
        {
            _protoMaze = protoMaze;
            _protoRoom = protoRoom;
            _protoWall = protoWall;
            _protoDoor = protoDoor;
        }
        public override Maze MakeMaze()
        {
            return _protoMaze.Clone();
        }
        public override Room MakeRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером.");
            }
            var room = _protoRoom.Clone();
            room.Initializing(roomNumber);
            return room;
        }
        public override Wall MakeWall()
        {
            return _protoWall.Clone();
        }
        public override Door MakeDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комнаты не существует.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комнаты не существует.");
            }
            var door = _protoDoor.Clone();
            door.Initializing(room1, room2);
            return door;
        }
    }
}
