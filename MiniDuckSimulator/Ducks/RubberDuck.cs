using System;
using MiniDuckSimulator.Behaviors;
using MiniDuckSimulator.Ducks.Abstractions;

namespace MiniDuckSimulator.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber ducky");
        }
    }
}