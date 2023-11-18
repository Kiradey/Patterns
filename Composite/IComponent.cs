using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComponent
    {
        void Add(IComponent component);
        void Remove(IComponent component);
        void Print();
    }
}
