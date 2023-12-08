using System;
namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            DrinkBehavior tea = new Tea();
            tea.Create();
            DrinkBehavior coffee = new Coffee(true);
            coffee.Create();
            DrinkBehavior coffeeWithMilk = new Coffee(false);
            coffeeWithMilk.Create();

            Console.ReadLine();
        }
    }
}