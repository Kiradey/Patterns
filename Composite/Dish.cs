using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Dish : IComponent
    {
        public string Name { get; private set; }
        public Dish(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Имени не обнаружено!");
            }
            Name = name;
        }
        public void Add(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Не имеет никаких значений!");
            }
            throw new InvalidOperationException("Нельзя добавить. Данная операция запрещена!");
        }
        public void Remove(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Не имеет никаких значений!");
            }
            throw new InvalidOperationException("Нельзя удалить. Данная операция запрещена!");
        }
        public void Print()
        {
            Console.WriteLine($"~{Name}.");
        }
    }
}
