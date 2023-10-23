using MiniDuckSimulator.Behaviors;
using MiniDuckSimulator.Ducks;

namespace MiniDuckSimulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            var rubberDuck = new RubberDuck();
            var decoy = new DecoyDuck();

            var model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuck.PerformQuack();
            decoy.PerformQuack();
            
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}