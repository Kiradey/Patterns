using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfrespons
{
    public class OperationButtonHelpHandler : HelpHandler
    {
        public OperationButtonHelpHandler(HelpHandler helpHandler) : base(helpHandler) { }
        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            return helpRequest.Symbol == '+' || helpRequest.Symbol == '-' || helpRequest.Symbol == '*' || helpRequest.Symbol == '/';
        }
        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            return $"Это кнопка операции '{helpRequest.Symbol}'";
        }
    }
}
