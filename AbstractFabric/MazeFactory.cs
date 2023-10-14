using LibraryForLabyrinth;
using System;
namespace AbstractFabric
{
    public abstract class MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
        public virtual Wall MakeWall()
        {
            return new Wall();
        }
        public virtual Room MakeRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }
        public virtual Door MakeDoor(Room _room1, Room _room2)
        {
            return new Door(_room1, _room2, true);
        }
    }
}