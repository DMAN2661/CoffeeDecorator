namespace CoffeeDecorator.SpecificCoffee
{

    using BaseCoffee;

    public class HouseBlend : Coffee
    {
        private const string HouseBlendDescription = "House Blend Coffee";
        private const double HouseBlendPrice = 1.2;

        public HouseBlend()
        {
            this.Description = HouseBlendDescription;
            this.Price = HouseBlendPrice;
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