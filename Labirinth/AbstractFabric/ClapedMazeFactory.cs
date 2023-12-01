using System;
using LibraryForLabyrinth;

namespace AbstractFabric
{
    public class ClapedMazeFctory : MazeFactory
    {
        public override Door MakeDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException("Комната не может быть пустой. Kiradey");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException("Комната не может быть пустой. Kiradey");
            }
            return new DoorWithClap(room1, room2);
        }
        public override Room MakeRoom(int Number)
        {
            if (Number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть положительным числом.");
            }
            return new RoomWithClap(Number);
        }
    }
}