using LibraryForLabyrinth;
using System;

namespace AbstractFabric
{
    public class MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
        public virtual Wall MakeWall()
        {
            return new Wall();
        }
        public virtual Room MakeRoom(int roomNumber)
        {
            if (roomNumber <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть положительным числом. Kiradey", nameof(roomNumber));
            }
            return new Room(roomNumber);
        }
        public virtual Door MakeDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Комната не может быть пустой. Kiradey");
            }

            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Комната не может быть пустой. Kiradey");
            }
            return new Door(room1, room2, true);
        }
    }
}
