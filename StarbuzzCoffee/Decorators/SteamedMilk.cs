namespace StarbuzzCoffee.condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }

        public override string Description => _beverage.Description + ", Steamed Milk";
    }
}