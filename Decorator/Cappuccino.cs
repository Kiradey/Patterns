using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Cappuccino : Coffee
    {
        public Cappuccino() : base("Капучино.") { }
        public override double Price()
        {
            return 20;
        }
    }

}
