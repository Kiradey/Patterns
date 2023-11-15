using System;
using Builder;
using LibraryForLabyrinth;
namespace MazeBuilder
{
    class Program
    {
        static void Main()
        {
            MazeGame.Create(new Builder.MazeBuilder());
            MazeGame.Create(new BombedMazeBuilder());
            MazeGame.Create(new ClapedMazeBuilder());
            Console.ReadLine();
        }
    }
}