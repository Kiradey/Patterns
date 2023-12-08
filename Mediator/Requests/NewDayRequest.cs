using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Requests
{
    internal class NewDayRequest : CalendarRequest
    {
        public NewDayRequest() : base(CurrentDate()) { }
        public static DateOnly CurrentDate()
        {
            DateTime dateTime = DateTime.Now;
            return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}
