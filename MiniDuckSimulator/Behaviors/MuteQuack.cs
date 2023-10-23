using System;
using MiniDuckSimulator.Behaviors.Abstractions;

namespace MiniDuckSimulator.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}