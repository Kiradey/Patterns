using Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class CoffeePot
    {
        public void Check(CalendarRequest request)
        {
            if (request == null) { throw new ArgumentNullException(nameof(request), "Пустое значение!");}
            if(request is NewDayRequest)
            {
                switch (request.Date.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Сегодня выходной!");
                        break;
                    default:
                        Console.WriteLine("Сегодня будний день!");
                        if (DateTime.Now.Hour < 12)
                        {
                            Console.WriteLine("Готовим кофе!");
                        }
                        break;
                }
            }
        }
        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            Console.WriteLine($"Кофе будет готов в {request.Time}");
        }
    }
}
