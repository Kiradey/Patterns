using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Tea : DrinkBehavior
    {
        protected override void Brew()
        {
            Console.WriteLine("Вы заварили чай!");
        }
        protected override void AddСomponents()
        {
            if (IsAddish())
            {
                Console.WriteLine("Вы добавили лимон!");
            }
        }
        protected override bool IsAddish()
        {
            return true;
        }
    }
}

