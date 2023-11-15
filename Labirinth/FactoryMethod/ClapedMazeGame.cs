using System;
using LibraryForLabyrinth;
namespace FactoryMethod
{
    internal class ClapedMazeGame : MazeGame
    {
        protected override Room MakeRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), " Комната с отрицательным значением.");
            }
            return new RoomWithClap(roomNumber);
        }
        protected override Door MakeDoor(Room room1, Room room2, bool isOpen)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1), "Пустая комната.");
            }
            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2), "Пустая комната.");
            }
            return new DoorWithClap(room1, room2);
        }
    }
}
