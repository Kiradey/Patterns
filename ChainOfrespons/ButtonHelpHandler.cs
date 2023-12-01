using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfrespons
{
    public class ButtonHelpHandler : HelpHandler
    {
        public ButtonHelpHandler(HelpHandler helpHandler) : base(helpHandler) { }
        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            return char.IsLetter(helpRequest.Symbol);
        }
        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            return $"Это кнопка для буквы '{helpRequest.Symbol}'. Вы находитесь в калькуляторе!";
        }
    }
}
