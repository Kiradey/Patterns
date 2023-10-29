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
        protected override Room CreateRoom(int roomNumber)
        {
            return new RoomWithBomb(roomNumber);
        }
    }
}
