namespace CoffeeDecorator.SpecificCoffee
{

    using BaseCoffee;

    public class Decaf : Coffee
    {
        private const string DecafDescription = "House Blend Coffee";
        private const double DecafPrice = 1.4;

        public Decaf()
        {
            this.Description = DecafDescription;
            this.Price = DecafPrice;
        }

        public override double GetPrice()
        {
            return this.Price;
        }

        public override string GetDescription()
        {
            return this.Description;
        }
    }







}