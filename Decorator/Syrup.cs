using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Syrup : Decorator
    {
        public Syrup(Coffee coffee) : base(coffee, 1, ", сироп")
        {
            if (coffee == null) throw new ArgumentNullException(nameof(coffee), "Пустое значение!");
        }
    }
}
