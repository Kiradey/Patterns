using Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Calendar
    {
        private CalendarMediator _mediator;
        public Calendar(CalendarMediator calendarMediator)
        {
            if (calendarMediator == null)
            {
                throw new ArgumentNullException(nameof(calendarMediator), "Пустое значение!");
            }
            _mediator = calendarMediator;
        }
        public void OnEvent()
        {
            _mediator.Execute(new NewDayRequest());
        }
    }
}
