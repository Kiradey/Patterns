using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuItem
    {
        public string name { get; set; }
        public bool isVegan { get; set; }
        public MenuItem(string name, bool isVegan)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name), "Имени не обнаружено!");
            }
            this.name = name;
            this.isVegan = isVegan;
        }
    }
}
