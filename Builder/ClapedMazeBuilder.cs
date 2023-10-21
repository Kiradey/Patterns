using LibraryForLabyrinth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Builder
{
    internal class ClapedMazeBuilder : MazeBuilder
    {
        private readonly Maze _maze = new();
        public new void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }

            RoomWithClap room = new(roomNumber);

            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.West, new Wall());

            _maze.AddRoom(room);
        }
        public void DoorBuild(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            if (roomNumber2 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room? room1 = _maze.NumberCheck(roomNumber1);
            Room? room2 = _maze.NumberCheck(roomNumber2);

            if (room1 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            if (room2 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            Door door = new Door(room1, room2, true);
            room1.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, door);
        }
        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}
