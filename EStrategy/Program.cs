using System;
using EStrategy.BehaviorsHere;
using EStrategy.DucksHere;
namespace EStrategy
{
    class Program
    {
        static void Main()
        {
            Duck funnyDuck = new FunnyDuck(new NoFly(), new Quack(), new Swim());
            Duck ironDuck = new IronDuck(new NoFly(), new NoQuack(), new NoSwim());
            Duck rubberDuck = new RubberDuck(new NoFly(), new NoQuack(), new Swim());
            Duck wildDuck = new WildDuck(new Fly(), new Quack(), new Swim());

            Console.WriteLine("Смешная утка:");
            DisplayDuckBehavior(funnyDuck);

            Console.WriteLine("\nЖелезная утка:");
            DisplayDuckBehavior(ironDuck);

            Console.WriteLine("\nРезиновая утка:");
            DisplayDuckBehavior(rubberDuck);

            Console.WriteLine("\nДикая утка:");
            DisplayDuckBehavior(wildDuck);

            Console.ReadLine();
        }
        static void DisplayDuckBehavior(Duck duck)
        {
            duck.Quack();
            duck.Fly();
            duck.Swim();
        }
    }
}