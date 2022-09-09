namespace CoffeeDecorator.Decorator
{
    using BaseCoffee;

    public abstract class Decorator : Coffee
    {
        private Coffee coffee;
        private double addPrice;

        protected Decorator(Coffee coffee)
        {
            this.Coffee = coffee;
        }

        protected double AddPrice
        {
            get {return this.addPrice;}

            set {this.addPrice = value;}
        }

        protected Coffee Coffee
        {
            get {return this.coffee;}

            set {this.coffee = value;}
        }

        public override double GetPrice()
        {
            return this.Coffee.GetPrice() + this.addPrice;
        }

        public override string GetDescription()
        {
            return $"{this.Coffee.GetDescription()}, {this.Description}";
        }
    }
}