using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuakBehavior quackBehavior;

        public void PerformQuack()
        {
            System.Console.WriteLine(quackBehavior.Quack()); 
        }

        public void PerformFly()
        {
            System.Console.WriteLine(flyBehavior.Fly());
        }
        public abstract void Display();

        public void Swim()
        {
            System.Console.WriteLine("I can swim");
        }

        public void SetQuackBehavior(QuakBehavior quack)
        {
            quackBehavior = quack;
        }

        public void SetFlyBehavior(FlyBehavior fly)
        {
            flyBehavior = fly;
        }

    }
}
