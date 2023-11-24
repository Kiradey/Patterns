using System;
namespace EDecorator
{
    internal class Program
    {
        public static void Main()
        {
            Coffee latte = new Latte();
            latte = new Syrup(latte);
            Console.WriteLine($"{latte.GetDescription()}{latte.Price()}");
            Coffee cappuccino = new Cappuccino();
            cappuccino = new Lemon(cappuccino);
            cappuccino = new Sugar(cappuccino);
            cappuccino = new Discount(cappuccino);
            Console.WriteLine($"{cappuccino.GetDescription()}   {cappuccino.Price}");
        }
    }
}