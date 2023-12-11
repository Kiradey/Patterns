using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLabyrinth;
namespace Prototype
{
    public class MazePrototypeBombedFactory : MazePrototypeFactory
    {
        public MazePrototypeBombedFactory()
                    : base(new Maze(), new RoomWithBomb(0), new WallWithBomb(), new Door(new Room(0), new Room(1))) { }
    }
}

