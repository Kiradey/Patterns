using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Discount : Decorator
    {
        public Discount(Coffee coffee) : base(coffee, coffee.Price() * (-0.01), " + скидка")
        {
            if (coffee == null) throw new ArgumentNullException(nameof(coffee), "Пустое значение!");
        }
    }
}
