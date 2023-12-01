using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Conditioner
    {
        public void On()
        {
            Console.WriteLine("Вы включили кондиционер!");
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили кондиционер!");
        }
    }
}
