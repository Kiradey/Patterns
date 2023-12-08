using Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class CalendarEventRequest:CalendarRequest
    {
        public CalendarEventRequest(DateOnly date) : base(date) { }
    }
}
