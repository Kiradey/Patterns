using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface IMediator
    {
        public void Execute(IRequest request);
    }
}
