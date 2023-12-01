using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfrespons
{
    public class IntButtonHelpHandler : ButtonHelpHandler
    {
        public IntButtonHelpHandler(HelpHandler helpHandler) : base(helpHandler) { }
        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            return char.IsDigit(helpRequest.Symbol);
        }
        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            return $"Это кнопка для цифры '{helpRequest.Symbol}'";
        }
    }
}

