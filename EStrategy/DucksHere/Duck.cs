using EStrategy.BehaviorsHere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStrategy.DucksHere
{
    public abstract class Duck
    {
        protected IFly _flyBehavior;
        protected IQuack _quackBehavior;
        protected ISwim _swimBehavior;
        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _flyBehavior = fly;
            _quackBehavior = quack;
            _swimBehavior = swim;
        }

        public abstract void Quack();
        public abstract void Fly();
        public abstract void Swim();
    }
}
