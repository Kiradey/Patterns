using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAdapter
{
    internal class RubberDuck:Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка пищит!");
        }
        public override void Fly()
        {
            Console.WriteLine("Резиновая утка не может летать (если не кинуть)!");
        }
    }
}
