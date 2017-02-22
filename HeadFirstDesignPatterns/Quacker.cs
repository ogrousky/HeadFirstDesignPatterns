using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public class Quacker:QuakBehavior
    {
        public string Quack()
        {
            return ("I Quack");
        }
    }
}
