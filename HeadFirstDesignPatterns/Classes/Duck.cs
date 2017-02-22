using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuakBehavior quackBehavior;

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

        public void SetQuackBehavior(IQuakBehavior quack)
        {
            quackBehavior = quack;
        }

        public void SetFlyBehavior(IFlyBehavior fly)
        {
            flyBehavior = fly;
        }

    }
}
