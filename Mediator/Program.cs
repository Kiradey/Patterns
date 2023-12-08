using System;
using static Mediator.AlarmForMediator;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            AlarmMediator alarmMediator = new(new CoffeePot(), new Sprinkler());
            CalendarMediator calendarMediator = new(new CoffeePot(), new Sprinkler());

            Alarm alarm = new(alarmMediator);
            Calendar calendar = new(calendarMediator);

            calendar.OnEvent();
            alarm.OnEvent();

            Console.ReadLine();
        }
    }
}