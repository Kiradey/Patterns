using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OffLightCommand : ICommand
    {
        private Lights _light;
        public OffLightCommand(Lights light)
        {
            if (light == null) { throw new ArgumentNullException(nameof(light), "Свет не может принимать значениe null!"); }
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }
    }
}
