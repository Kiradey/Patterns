using ChainOfrespons;
using System;
class program
{
    static void Main()
    {
        var applicationHelpHandler = new ApplicationHelpHandler(null);
        var buttonHelpHandler = new ButtonHelpHandler(applicationHelpHandler);
        var intButtonHelpHandler = new IntButtonHelpHandler(buttonHelpHandler);
        var operationHelpHandler = new OperationButtonHelpHandler(buttonHelpHandler);

        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('1')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('5')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('+')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('m')));
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('д')));
        Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('-')));
        Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('1')));

        Console.ReadLine();
    }
}
