using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Lemon : Decorator
    {
        public Lemon(Coffee coffee) : base(coffee, 1, ", лимон")
        {
            if (coffee == null) throw new ArgumentNullException(nameof(coffee), "Пустое значение!");
        }
    }
}
