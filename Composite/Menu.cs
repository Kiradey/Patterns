using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Menu : IComponent
    {
        private readonly List<IComponent> _menuOfComponents = new List<IComponent>();
        public string Name { get; private set; }
        public Menu(string name)
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
                throw new ArgumentNullException(nameof(component), "Пустое значение!");
            }
            _menuOfComponents.Add(component);
        }
        public void Remove(IComponent component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Пустое значение!");
            }
            if (!_menuOfComponents.Contains(component))
            {
                throw new InvalidOperationException("Указанный компонент не обнаружен!");
            }
            _menuOfComponents.Remove(component);
        }
        public void Print()
        {
            Console.WriteLine($"Меню {Name}:");
            _menuOfComponents.ForEach(component => component.Print());
        }
    }
}
