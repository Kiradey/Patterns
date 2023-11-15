using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBridge
{
    public interface IImplementor
    {
        void On();
        void Off();
        void SetPower(int power);
        void SetMode(int mode);
    }
}
