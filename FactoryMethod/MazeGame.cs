using System;
using LibraryForLabyrinth;

namespace FactoryMethod
{
    internal class MazeGame
    {
        public Maze Create()
        {
            Room room1 = MakeRoom(1);
            Room room2 = MakeRoom(2);

            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Такой комнаты не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Такой комнаты не существует");
            }

            Door door = MakeDoor(room1, room2, true);

            Wall wall = MakeWall();

            room1.SetSide(Direction.North, wall);
            room1.SetSide(Direction.West, wall);
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, wall);

            room2.SetSide(Direction.North, wall);
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.South, wall);

            Maze maze = MakeMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
        protected virtual Room MakeRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением.");
            }
            return new Room(roomNumber);
        }
        protected virtual Door MakeDoor(Room room1, Room room2, bool isOpen)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Такой комнаты не существует");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Такой комнаты не существует");
            }
            return new Door(room1, room2, isOpen);
        }
        protected virtual Wall MakeWall()
        {
            return new Wall();
        }
        protected virtual Maze MakeMaze()
        {
            return new Maze();
        }
    }
}
