using LibraryForLabyrinth;
using System;
namespace FactoryMethod
{
    internal class BombedMazeGame : MazeGame
    {
        protected override Room MakeRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным значением.");
            }
            return new RoomWithBomb(roomNumber);
        }
        protected override Wall MakeWall()
        {
            return new WallWithBomb();
        }
    }
}
