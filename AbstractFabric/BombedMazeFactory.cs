using System;
using LibraryForLabyrinth;

namespace AbstractFabric
{
    public class MazeWithBombFactory : MazeFactory
    {
        public override Wall MakeWall()
        {
            return new WallWithBomb();
        }
        public override Room MakeRoom(int roomNumber)
        {
            return new RoomWithBomb(roomNumber);
        }
    }
}
