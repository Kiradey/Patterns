using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Requests
{
    internal class CalendarRequest:IRequest
    {
        public DateOnly Date { get; private set; }
        public CalendarRequest(DateOnly date)
        {
            Date = date;
        }
    }
}
