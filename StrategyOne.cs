﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    public class StrategyOne : IStrategy
    {
        public void StrategyMethod()
        {
            Console.WriteLine("Strategy One");
        }
    }
}
