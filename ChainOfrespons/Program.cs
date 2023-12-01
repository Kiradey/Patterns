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

        // intButtonHandler.SetHandler(buttonHandler);
        // buttonHandler.SetHandler(applicationHandler);

        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('1'))); //"это цифра '1'"
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('+'))); // обязанность делегирует в buttonHelp, выводит "эта кнопка '+'"
        Console.WriteLine(intButtonHelpHandler.HandleHelp(new HelpRequest('m'))); // обязанность делегирует в buttonHelp, делегируется applicationHelp, выводит "Вы находитесь в калькуляторе"
        Console.WriteLine(operationHelpHandler.HandleHelp(new HelpRequest('-'))); // "Это оператор '-'"

        Console.ReadLine();
    }
}