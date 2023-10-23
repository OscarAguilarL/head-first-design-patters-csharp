namespace StarbuzzCoffee
{
    public abstract class CondimentDecorator : Beverage
    {
        public override string Description { get; protected set; }
    }
}