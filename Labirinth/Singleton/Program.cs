using System;
using AbstractFabric;
using LibraryForLabyrinth;
namespace Singleton
{
    class Program
    {
        static void Main()
        {
            var factory1 = MazeGame.CreateMaze(SingletonMazeFactory.Instance);
            var factory2 = MazeGame.CreateMaze(SingletonBombedMazeFactory.Instance);
            var factory3 = MazeGame.CreateMaze(SingletonClapedMazeFactory.Instance);
            Console.ReadLine();
        }
    }
}