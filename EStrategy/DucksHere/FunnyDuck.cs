using EStrategy.BehaviorsHere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStrategy.DucksHere
{
    public class FunnyDuck : Duck
    {
        public FunnyDuck(IFly fly, IQuack quack, ISwim swim)
            : base(new NoFly(), new Quack(), new Swim())
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
