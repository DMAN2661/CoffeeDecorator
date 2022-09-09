namespace CoffeeDecorator.SpecificDecorator
{

    using BaseCoffee;
    using Decorator;

    public class Whip : Decorator
    {
        private const double WhipPrice = 0.1;

        public Whip(Coffee coffee) : base(coffee)
        {
            this.Description = "With Whip";
            this.AddPrice = WhipPrice;
        }
    }


}