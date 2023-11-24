using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Sugar:Decorator
    {
        public Sugar(Coffee coffee):base(coffee, 1, ", сахар") 
        {
            if (coffee == null) throw new ArgumentNullException(nameof(coffee), "Пустое значение!");
        }
    }
}
