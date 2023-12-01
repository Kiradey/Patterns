using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Door
    {
        public void Open()
        {
            Console.WriteLine("Вы открыли дверь!");
        }
        public void Close()
        {
            Console.WriteLine("Вы закрыли дверь!");
        }
    }
}
