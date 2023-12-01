using System;
namespace ChainOfrespons
{
    public abstract class HelpHandler
    {
        protected HelpHandler? _helpHandler;
        public HelpHandler(HelpHandler helpHandler)
        {
            _helpHandler = helpHandler;
        }

        public virtual string HandleHelp(HelpRequest helpRequest)
        {
            if (IsSupportRequest(helpRequest))
            {
                return BuildHelpString(helpRequest);
            }
            if (_helpHandler != null)
            {
                return _helpHandler.HandleHelp(helpRequest);
            }
            return BuildDefaultHelpString(helpRequest);
        }
        //  protected abstract bool IsSupportRequest(HelpRequest helpRequest)
        protected abstract bool IsSupportRequest(HelpRequest helpRequest);
        // проверка-если цифра либо символ операции, то возвращает true
        protected abstract string BuildHelpString(HelpRequest helpRequest);
        //это такая-то цифра, либо это такая-то кнопка
        protected virtual string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            return "Вы попали в базовый обработчик";
        }
    }
}
