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
        protected MazePrototypeBombedFactory() : base(new Maze(), new RoomWithBomb(), new WallWithBomb(), new Door()) { }
    }
}
