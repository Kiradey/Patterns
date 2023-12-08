using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStrategy.BehaviorsHere;

namespace EStrategy.DucksHere
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFly fly, IQuack quack, ISwim swim)
            : base(new NoFly(), new NoQuack(), new Swim())
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
