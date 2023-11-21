using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Вы включили телевизор!");
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили телевизор!");
        }
        public void Mode()
        {
            Console.WriteLine("Вы изменили режим телевизора!");
        }
    }
}
