namespace CoffeeDecorator.SpecificDecorator
{

    using BaseCoffee;
    using Decorator;

    public class Sugar : Decorator
    {
        private const double SugarPrice = 0.2;

        public Sugar(Coffee coffee) : base(coffee)
        {
            this.Description = "With Sugar";
            this.AddPrice = SugarPrice;
        }
    }
}