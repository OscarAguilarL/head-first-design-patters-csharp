using System;
using MiniDuckSimulator.Behaviors.Abstractions;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}