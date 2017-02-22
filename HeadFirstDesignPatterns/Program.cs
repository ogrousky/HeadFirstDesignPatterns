using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.SetFlyBehavior(new FlyWithWings());
            mallardDuck.SetQuackBehavior(new Quacker());
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
            ////
            var rubberDuck = new RubberDuck();
            rubberDuck.SetFlyBehavior(new FlyNoWay());
            rubberDuck.SetQuackBehavior(new MuteQuack());
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            System.Console.ReadLine();
        }
    }
}
