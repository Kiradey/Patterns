using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBridge
{
    public class TV : IImplementor
    {
        public void On()
        {
            Console.WriteLine("Вы включили телевизор.");
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили телевизор.");
        }
        public void SetPower(int power)
        {
            if (power > 0)
            {
                Console.WriteLine($"Вы установили мощность телевизора на {power}.");
            }
            else
            {
                throw new ArgumentException(nameof(power), "Значение мощности должно быть больше 0.");
            }
        }
        public void SetMode(int mode)
        {
            if (mode > 0)
            {
                Console.WriteLine($"Вы установили режим телевизора на {mode}.");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение режима должно быть больше 0.");
            }
        }
    }
}