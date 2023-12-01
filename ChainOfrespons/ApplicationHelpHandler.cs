using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfrespons
{
    public class ApplicationHelpHandler : HelpHandler
    {
        public ApplicationHelpHandler(HelpHandler helpHandler) : base(helpHandler) { }
        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            return true;
        }
        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            return $"Это кнопка 'helpRequest.Symbol'";
        }
    }
}
