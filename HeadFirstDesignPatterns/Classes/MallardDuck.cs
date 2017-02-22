using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quacker();
        }


        public override void Display()
        {
            System.Console.WriteLine("I am a model Duck");
        }
    }
}
