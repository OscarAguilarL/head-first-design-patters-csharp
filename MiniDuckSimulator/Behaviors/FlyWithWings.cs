using System;
using MiniDuckSimulator.Behaviors.Abstractions;

namespace MiniDuckSimulator.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        void IFlyBehavior.Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}