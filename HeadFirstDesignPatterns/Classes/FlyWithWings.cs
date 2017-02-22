using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return ("I fly with my wings");
        }
    }
}
