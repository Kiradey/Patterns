using Bridge;
using System;
namespace EBridge
{
    class Program
    {
        static void Main()
        {
            IImplementor condition = new AirCondition();
            MemoryRemote remote = new MemoryRemote(condition);

            remote.TurnOn();
            remote.PowerPlus();
            remote.ModeNext();
            remote.Save(1);

            Console.WriteLine();

            remote.PowerMinus();
            remote.ModePreview();
            remote.Save(2);

            Console.WriteLine();

            remote.Load(1);

            Console.WriteLine();

            remote.Load(2);

            Console.WriteLine();

            remote.TurnOff();

            Console.ReadLine();
        }
    }
}