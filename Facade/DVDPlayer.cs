using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DVDPlayer
    {
        public void In()
        {
            Console.WriteLine("Вы вставили диск!");
        }
        public void Out()
        {
            Console.WriteLine("Вы вывели диск!");
        }
        public void Play()
        {
            Console.WriteLine("Содержимое диска воспроизводится!");
        }
    }
}
