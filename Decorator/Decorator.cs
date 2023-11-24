using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal class Decorator:Coffee
    {
        //   public overide Price() => _coffe.Price() + _price;
        private Coffee _coffee;
        private double _extraPrice;
        public Decorator(Coffee coffee, double extraPrice, string descriptionAddition) : base(coffee.GetDescription() + descriptionAddition)
        {
            if (coffee == null) throw new ArgumentNullException(nameof(coffee), "Пустое значение!");
            if (extraPrice == 0) throw new ArgumentException(nameof(extraPrice), "Вы ничего не добавили!");
            _coffee = coffee;
            _extraPrice = extraPrice;
        }
        public override double Price()
        {
            return _coffee.Price() + _extraPrice;
        }
    }
}
