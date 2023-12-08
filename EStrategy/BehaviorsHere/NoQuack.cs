﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStrategy.BehaviorsHere
{
    public class NoQuack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Утка не крякает!");
        }
    }
}
