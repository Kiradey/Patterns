using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuVeganIterator : IIterator<MenuItem>
    {
        private List<MenuItem> _menuOfItems;
        private int _position;
        public MenuVeganIterator(List<MenuItem> menuOfItems)
        {
            _menuOfItems = menuOfItems;
            _position = 0;
        }
        public bool HasNext()
        {
            while (_position < _menuOfItems.Count && !_menuOfItems[_position].isVegan)
            {
                _position++;
            }
            return _position < _menuOfItems.Count;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuOfItems[_position++];
            }
            else
            {
                throw new InvalidOperationException("Больше нет веганских блюд");
            }
        }
    }
}
