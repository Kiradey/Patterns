using Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request is CalendarEventRequest)
            {
                Console.WriteLine($"Разбрызгиватель будет включен {request.Date}");
            }
        }
        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            Console.WriteLine($"Разбрызгиватель будет включен в {request.Time}");
        }
    }
}
