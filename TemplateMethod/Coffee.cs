using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Coffee:DrinkBehavior
    {
        private bool _withAdditives;

        public Coffee(bool withAdditives)
        {
            _withAdditives = withAdditives;
        }
        protected override void Brew()
        {
            Console.WriteLine("Вы заварили кофе!");
        }
        protected override void AddСomponents()
        {
            if (IsAddish())
            {
                Console.WriteLine("Вы добавили сахар с молоком!");
            }
            else
            {
                Console.WriteLine("Ничего не добавили в кофе!");
            }
        }
        protected override bool IsAddish()
        {
            return _withAdditives;
        }
    }
}
