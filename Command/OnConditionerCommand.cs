using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OnConditionerCommand : ICommand
    {
        private Conditioner _conditioner;
        public OnConditionerCommand(Conditioner conditioner)
        {
            if (conditioner == null) { throw new ArgumentNullException(nameof(conditioner), "Кондиционер не может принимать значение null!"); }
            _conditioner = conditioner;
        }
        public void Execute()
        {
            _conditioner.On();
        }
    }
}
