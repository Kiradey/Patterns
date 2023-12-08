using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class AlarmForMediator
    {
        internal class AlarmMediator : IMediator
        {
            private CoffeePot _coffeePot;
            private Sprinkler _sprinkler;

            public AlarmMediator(CoffeePot coffeePot, Sprinkler sprinkler)
            {
                if (coffeePot == null) { throw new ArgumentNullException(nameof(coffeePot), "Пустое значение!"); }
                if (sprinkler == null) { throw new ArgumentNullException(nameof(sprinkler), "Пустое значение!"); }
                _coffeePot = coffeePot;
                _sprinkler = sprinkler;
            }
            public void Execute(IRequest request)
            {
                if (request == null) { throw new ArgumentNullException(nameof(request), "Пустое значение!"); }
                if (request is AlarmRequest alarmRequest)
                {
                    _coffeePot.Check(alarmRequest);
                    _sprinkler.Check(alarmRequest);
                }
            }
        }
    }
}


