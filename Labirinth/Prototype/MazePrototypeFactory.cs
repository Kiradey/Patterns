using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFabric;
using LibraryForLabyrinth;
namespace Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze _protoMaze;
        private Room _protoRoom;
        private Wall _protoWall;
        private Door _protoDoor;
        protected MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door)
        {
            if (maze == null)
            {
                throw new ArgumentNullException(nameof(maze), "Пустое значение для лабиринта!");
            }
            if (room == null)
            {
                throw new ArgumentNullException(nameof(room), "Пустое значение для комнаты!");
            }
            if (wall == null)
            {
                throw new ArgumentNullException(nameof(wall), "Пустое значение для стены!");
            }
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Пустое значение для двери!");
            }
            _protoMaze = maze;
            _protoRoom = room;
            _protoWall = wall;
            _protoDoor = door;
        }
        public MazePrototypeFactory() : this(new Maze(), new Room(0), new Wall(), new Door(new Room(0), new Room(1)))
        {
        }
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
        public Door MakeDoor()
        {
            return _protoDoor.Clone();
        }
    }
}
