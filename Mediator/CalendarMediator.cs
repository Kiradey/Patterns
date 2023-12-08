using Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class CalendarMediator : IMediator
    {
        private CoffeePot _coffeePot;
        private Sprinkler _sprinkler;

        public CalendarMediator(CoffeePot coffeePot, Sprinkler sprinkler)
        {
            if (coffeePot == null) { throw new ArgumentNullException(nameof(coffeePot), "Пустое значение!"); }
            if (sprinkler == null) { throw new ArgumentNullException(nameof(sprinkler), "Пустое значение!"); }
            _coffeePot = coffeePot;
            _sprinkler = sprinkler;
        }
        public void Execute(IRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (request is CalendarRequest calendarRequest)
            {
                _coffeePot.Check(calendarRequest);
                _sprinkler.Check(calendarRequest);
            }
        }
    }
}
