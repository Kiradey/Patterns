using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDecorator
{
    internal abstract class Coffee
    {
        protected string description;
        public Coffee(string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description), "Пусто значение!");
            }
            this.description = description;
        }
        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Price();
    }
}
