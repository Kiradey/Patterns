using System;
namespace State
{
    class Program
    {
        static void Main()
        {
            CandyMachine candyMachine = new CandyMachine(5);
            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();
            candyMachine.TurnCrank();

            candyMachine.InsertQuarter();

            Console.WriteLine($"Осталось конфет: {candyMachine.candyLeft}");
            Console.ReadLine();
        }
    }
}