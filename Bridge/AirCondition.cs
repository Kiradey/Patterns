using EBridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class AirCondition : IImplementor
    {
        public void On()
        {
            Console.WriteLine("Вы включили кондиционер.");
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили кондиционер.");
        }
        public void SetPower(int power)
        {
            if (power > 0)
            {
                Console.WriteLine($"Вы установили мощность кондиционера на {power}.");
            }
            else
            {
                throw new ArgumentException(nameof(power), "Значение мощности должно принимать значения больше 0.");
            }
        }
        public void SetMode(int mode)
        {
            if (mode > 0)
            {
                Console.WriteLine($"Вы установили режим кондиционера на {mode}.");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение режима должно принимать значения больше 0.");
            }
        }
    }
}
