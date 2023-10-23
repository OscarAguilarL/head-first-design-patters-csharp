using System;
using MiniDuckSimulator.Behaviors.Abstractions;

namespace MiniDuckSimulator.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}