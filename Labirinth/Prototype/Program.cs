using LibraryForLabyrinth;
namespace Prototype
{
    internal class Program
    {
        static void Main()
        {
            var roomPrototype = new Room(1);
            var maze = MazeGame.Create(roomPrototype);
            Console.ReadLine();
        }
    }
}