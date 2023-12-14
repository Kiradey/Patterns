using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuArrayIterator:IIterator<MenuItem>
    {
        private MenuItem[] _menuOfItems;
        private int _position;
        public MenuArrayIterator(MenuItem[] items)        {
            _menuOfItems = items;
            _position = 0;
        }
        public bool HasNext()
        {
            return _position < _menuOfItems.Length;
        }
        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuOfItems[_position++];
            }
            else
            {
                throw new InvalidOperationException("Блюд больше не обнаружено!");
            }
        }

    }
}
