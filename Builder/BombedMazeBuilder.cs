using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLabyrinth;
namespace Builder
{
    internal class BombedMazeBuilder : MazeBuilder
    {
        private readonly Maze _maze = new();
        public new void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            RoomWithBomb room = new(roomNumber);
            room.SetSide(Direction.North, new WallWithBomb());
            room.SetSide(Direction.South, new WallWithBomb());
            room.SetSide(Direction.East, new WallWithBomb());
            room.SetSide(Direction.West, new WallWithBomb());
            _maze.AddRoom(room);
        }
        public void BuildDoor(int roomNumber1, int roomNumber2)
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
                throw new ArgumentException("Комнаты с указанными номерами не существуют.");
            }
            if (room2 == null)
            {
                throw new ArgumentException("Комнаты с указанными номерами не существуют.");
            }
            Door door = new(room1, room2, true);
            room1.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, door);
        }
        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}
