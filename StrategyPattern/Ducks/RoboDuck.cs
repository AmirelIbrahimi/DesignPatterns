using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RoboDuck : Duck
    {
        public RoboDuck()
        {
            flyBehavior = new FlyWithRocket();
            quackBehavior = new QuackYesWay();
            swimBehavior = new Sinking();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Robo Duck");
        }
    }
}
