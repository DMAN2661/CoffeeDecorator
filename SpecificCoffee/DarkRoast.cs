namespace CoffeeDecorator.SpecificCoffee
{

    using BaseCoffee;

    public class DarkRoast : Coffee
    {
        private const string DarkRoastDescription = "Dark Roast Coffee";
        private const double DarkRoastPrice = 1.1;

        public DarkRoast()
        {
            this.Description = DarkRoastDescription;
            this.Price = DarkRoastPrice;
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