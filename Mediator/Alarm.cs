using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mediator.AlarmForMediator;

namespace Mediator
{
    internal class Alarm
    {
        private AlarmMediator _mediator;

        public Alarm(AlarmMediator mediator)
        {
            if (mediator == null) { throw new ArgumentNullException(nameof(mediator)); }
            _mediator = mediator;
        }

        public void OnEvent()
        {
            _mediator.Execute(new AlarmRequest(new TimeOnly(9, 30)));
        }
    }
}
