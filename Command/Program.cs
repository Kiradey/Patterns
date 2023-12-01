using System;
namespace Command
{
    class Program
    {
        static void Main()
        {
            Remote remote = new Remote();
            Conditioner conditioner = new Conditioner();
            Lights light = new Lights();

            remote.Add(0, new OnConditionerCommand(conditioner), new OffConditionerCommand(conditioner));
            remote.Execute(0);
            Console.WriteLine();

            Console.WriteLine("\nОтменяем последнее действие...\n");
            remote.Undo();

            MultiCommand multiCommandOn = new MultiCommand(new List<ICommand> { new OnLightsCommand(light), new OnConditionerCommand(conditioner) });
            MultiCommand multiCommandOff = new MultiCommand(new List<ICommand> { new OffConditionerCommand(conditioner), new OffLightCommand(light) });

            remote.Add(1, multiCommandOn, multiCommandOff);
            remote.Execute(1);

            Console.WriteLine("\nОтменяем действие...\n");
            remote.Undo();
            Console.ReadLine();
        }
    }
}