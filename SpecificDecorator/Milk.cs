namespace CoffeeDecorator.SpecificDecorator
{

   using BaseCoffee;
   using Decorator;

    public class Milk : Decorator
    {
        private const double MilkPrice = 0.15;

        public Milk(Coffee coffee) : base(coffee)
        {
            this.Description = "With Milk";
            this.AddPrice = MilkPrice;
        }
    }
}