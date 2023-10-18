using System;
using LibraryForLabyrinth;

namespace AbstractFabric
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Wall MakeWall()
        {
            return new WallWithBomb();
        }
        public override Room MakeRoom(int roomNumber)
        {
            if (roomNumber < 1)
            {
                throw new ArgumentException("Номер комнаты должен быть больше 0.", nameof(roomNumber));
            }
            return new RoomWithBomb(roomNumber);
        }
    }
}
