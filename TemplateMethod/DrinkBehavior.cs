using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class DrinkBehavior
    {
        public void Create()
        {
            BoilerWater(); 
            PourIntoMug();
            Brew();
            AddСomponents();
        }
        public void BoilerWater()
        {
            Console.WriteLine("\nВы вскипятили воду!");
        }
        public void PourIntoMug()
        {
            Console.WriteLine("Вы налили в кружку воду!");
        }
        protected abstract void Brew();
        protected abstract void AddСomponents();
        protected abstract bool IsAddish();
    }
}
