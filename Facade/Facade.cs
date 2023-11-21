using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private TV _tv;
        private Audio _audio;
        private DVDPlayer _dvd;

        public Facade()
        {
            _tv = new TV();
            _audio = new Audio();
            _dvd = new DVDPlayer();
        }
        public void On()
        {
            if (_tv == null)
            {
                throw new ArgumentNullException(nameof(_tv), "Пустое значение!");
            }
            if (_audio == null)
            {
                throw new ArgumentNullException(nameof(_audio), "Пустое значение!");
            }
            if (_dvd == null)
            {
                throw new ArgumentNullException(nameof(_dvd), "Пустое значение!");
            }
            _tv.On();
            _audio.On();
            _dvd.In();
        }
        public void Off()
        {
            Console.WriteLine("Вы выключили домашний кинотеатр!");
            _tv.Off();
            _audio.Off();
            _dvd.Out();
        }
    }
}
