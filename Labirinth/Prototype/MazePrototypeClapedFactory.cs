using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
using LibraryForLabyrinth;
namespace Prototype
{
    public class MazePrototypeClapedFactory : MazePrototypeFactory
    {
        protected MazePrototypeClapedFactory() : base(new Maze(), new RoomWithClap(), new Wall(), new Door()) { }
    }
}
