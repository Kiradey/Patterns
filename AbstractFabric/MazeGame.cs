using LibraryForLabyrinth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class MazeGame
    {
        public static Maze CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();
            Room room1 = factory.MakeRoom(2);
            Room room2 = factory.MakeRoom(3);
            Door door = factory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.MakeWall());
            room1.SetSide(Direction.West, factory.MakeWall());
            room1.SetSide(Direction.South, factory.MakeWall());
            room1.SetSide(Direction.East, door);

            room2.SetSide(Direction.North, factory.MakeWall());
            room2.SetSide(Direction.East, factory.MakeWall());
            room2.SetSide(Direction.South, factory.MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}
