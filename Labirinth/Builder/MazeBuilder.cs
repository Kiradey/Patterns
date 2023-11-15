using System;
using LibraryForLabyrinth;

namespace Builder
{
    internal abstract class MazeBuilder
    {
        protected Maze maze;
        public MazeBuilder()
        {
            maze = new Maze();
        }
        public virtual void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }

            Room room = CreateRoom(roomNumber);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());

            maze.AddRoom(room);
        }
        public virtual void DoorBuilder(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            if (roomNumber2 < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            Room? room1 = maze.NumberCheck(roomNumber1);
            Room? room2 = maze.NumberCheck(roomNumber2);
            if (room1 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            if (room2 == null)
            {
                throw new ArgumentException("Комнаты с указанным номером не существуют.");
            }
            Door door = new Door(room1, room2, true);
            room1.SetSide(Direction.East, door);
            room2.SetSide(Direction.West, door);
        }
        protected virtual Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentException("Номер комнаты должен быть неотрицательным.");
            }
            return new Room(roomNumber);
        }
    }
}
