using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
using LibraryForLabyrinth;
namespace Prototype
{
    internal class MazePrototypeFactory : MazeFactory
    {
        private Maze _protoMaze;
        private Room _protoRoom;
        private Wall _protoWall;
        private Door _protoDoor;
        protected MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door)
        {
            _protoMaze = maze;
            _protoRoom = room;
            _protoWall = wall;
            _protoDoor = door;
        }
        public MazePrototypeFactory()
        : this(new Maze(), new Room(), new Wall(), new Door())
        { }
        public override Maze MakeMaze()
        {
            return _protoMaze.Clone();
        }
        public Room MakeRoom()
        {
            return _protoRoom.Clone();
        }
        public override Wall MakeWall()
        {
            return _protoWall.Clone();
        }
        public  Door MakeDoor()
        {
            return _protoDoor.Clone();
        }
    }
}
