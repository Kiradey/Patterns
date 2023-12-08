﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStrategy.BehaviorsHere;

namespace EStrategy
{
    public class Fly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка летает!");
        }
    }
}
