using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EBridge
{
    public class Remote
    {
        protected IImplementor implementor { get; private set; }
        public int Power { get;protected set; }
        public int Mode { get;protected set; }
        public Remote(IImplementor implementor)
        {
            if (implementor == null)
            {
                throw new ArgumentNullException(nameof(implementor), "Пустое значение.");
            }
            this.implementor = implementor;
        }
        public void TurnOn()
        {
            implementor.On();
        }
        public void TurnOff()
        {
            implementor.Off();
        }
        public virtual void PowerPlus()
        {
            implementor.SetPower(++Power);
        }
        public virtual void PowerMinus()
        {
            implementor.SetMode(++Mode);
        }
        public virtual void ModeNext()
        {
            implementor.SetMode(++Mode);
        }
        public virtual void ModePreview()
        {
            implementor.SetMode(--Mode);
        }
    }
}
