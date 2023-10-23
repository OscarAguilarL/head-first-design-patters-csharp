using System;
using MiniDuckSimulator.Behaviors.Abstractions;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}