using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OnLightsCommand : ICommand
    {
        private Lights _light;
        public OnLightsCommand(Lights light)
        {
            if (light == null)
            {
                throw new ArgumentNullException(nameof(light), "Свет не может принимать значение null!");
            }
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
    }
}
