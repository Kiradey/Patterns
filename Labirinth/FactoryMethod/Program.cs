using LibraryForLabyrinth;
using System;
namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var factoryMethod1 = new MazeGame();
            var maze1 = factoryMethod1.Create();

            var factoryMethod2 = new BombedMazeGame();
            var maze2 = factoryMethod1.Create();

            var factoryMethod3 = new ClapedMazeGame();
            var maze3 = factoryMethod1.Create();

            Console.ReadLine();
        }
    }
}