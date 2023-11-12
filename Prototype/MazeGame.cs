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
        public static Maze Create(Room roomPrototype)
        {
            Room room1 = roomPrototype.Clone();
            Room room2 = roomPrototype.Clone();

            Door door = new(room1, room2, true);

            Wall wall = new();

            room1.SetSide(Direction.North, wall);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, wall);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, door);
            room2.SetSide(Direction.North, wall);

            Maze maze = new();

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}
