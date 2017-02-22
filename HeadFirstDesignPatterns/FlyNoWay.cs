﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public class FlyNoWay : FlyBehavior
    {
        public string Fly()
        {
            return ("I can't Fly");
        }
    }
}
