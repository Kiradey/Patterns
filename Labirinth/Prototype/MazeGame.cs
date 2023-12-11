using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForLabyrinth;
using AbstractFabric;
namespace Prototype
{
    internal class MazeGame
    {
        public static Maze Create(MazePrototypeFactory protoFactory)
        {
            Room room1 = protoFactory.MakeRoom(1);
            Room room2 = protoFactory.MakeRoom(2);

            Door door = protoFactory.MakeDoor(room1, room2);

            Wall wall = protoFactory.MakeWall();

            room1.SetSide(Direction.North, wall);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, wall);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.North, wall);

            Maze maze = protoFactory.MakeMaze();

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;

        }
    }
}
