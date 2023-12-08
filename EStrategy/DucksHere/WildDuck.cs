using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStrategy.BehaviorsHere;

namespace EStrategy.DucksHere
{
    public class WildDuck : Duck
    {
        public WildDuck(IFly fly, IQuack quack, ISwim swim)
            : base(new Fly(), new Quack(), new Swim())
        { }
        public override void Quack()
        {
            _quackBehavior.Execute();
        }
        public override void Fly()
        {
            _flyBehavior.Execute();
        }
        public override void Swim()
        {
            _swimBehavior.Execute();
        }
    }
}
