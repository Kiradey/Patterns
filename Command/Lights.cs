using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Lights
    {
        public void On()
        {
            Console.WriteLine("Вы включили свет!");
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили свет!");
        }
    }
}
