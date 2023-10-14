using System;
using LibraryForLabyrinth;
namespace AbstractFabric
{
    class program
    {
        static void Main()
        {
            var factory1 = MazeGame.CreateMaze(new MazeFactory());
            var factory2 = MazeGame.CreateMaze(new BombedMazeFactory());
            Console.ReadLine();
        }

            
    }
}