﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public class MuteQuack: QuakBehavior
    {
        public string Quack()
        {
            return ("I can't Quack");
        }
    }
}
