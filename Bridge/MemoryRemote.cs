using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBridge
{
    public class MemoryRemote : Remote
    {
        private Dictionary<int, (int Power, int Mode)> _dictionary = new Dictionary<int, (int Power, int Mode)>();
        public MemoryRemote(IImplementor implementor) : base(implementor)
        {
            if (implementor == null)
            {
                throw new ArgumentNullException(nameof(implementor), "Пустое значение.");
            }
        }
        public void Save(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "Значение должно быть положительным.");
            }
            _dictionary[index] = (Power, Mode);
            Console.WriteLine($"Сохраненный режим: {index}. Мощность: {Power}. Режим: {Mode}.");
        }
        public void Load(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "Значение должно быть положительным.");
            }
            if (_dictionary.ContainsKey(index))
            {
                var dictionary = _dictionary[index];
                int savedpower = dictionary.Power;
                int savedMode = dictionary.Mode;

                Power = savedpower;
                Mode = savedMode;
                implementor.SetPower(Power);
                implementor.SetMode(Mode);
                Console.WriteLine($"Загруженный режим: {index}. Мощность: {Power}. Режим: {Mode}.");
            }
            else
            {
                Console.WriteLine($"Режим с индексом {index} не обнаружен.");
            }
        }
    }
}
