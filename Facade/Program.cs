using System;
namespace Facade
{
    class Program
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.On();
            facade.Off();
            Console.ReadLine();
        }
    }
}