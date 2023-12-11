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
        public MazePrototypeClapedFactory()
                  : base(new Maze(), new RoomWithClap(0), new Wall(), new Door(new Room(0), new Room(1))) { }
    }
}
