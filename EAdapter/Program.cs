using System;
namespace EAdapter
{
    class Program
    {
        static void Main()
        {
            Duck duck = new();
            duck.Quack();
            duck.Fly();

            Duck rubDuck = new RubberDuck();
            rubDuck.Quack();
            rubDuck.Fly();

            Turkey turkey = new();
            Duck adapter = new Adapter(turkey);
            adapter.Quack();
            adapter.Fly();
            Console.ReadLine();
        }
    }
}