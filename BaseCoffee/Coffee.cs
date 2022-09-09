namespace CoffeeDecorator.BaseCoffee
{

    public abstract class Coffee
    {
        private string description;
        private double price;

        protected Coffee()
        {
        }

        protected string Description
        {
            get { return description; }
            set { description = value; }
        }

        protected double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}