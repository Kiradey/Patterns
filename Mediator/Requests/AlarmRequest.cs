using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class AlarmRequest : IRequest
    {
        public TimeOnly Time { get; private set; }

        public AlarmRequest(TimeOnly time)
        {
            Time = time;
        }
    }
}
