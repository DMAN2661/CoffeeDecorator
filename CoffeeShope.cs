namespace CoffeeDecorator
{
    using System;
    using BaseCoffee;
    using SpecificDecorator;
    using SpecificCoffee;
    using System.Globalization;

    internal class CoffeeShope
    {
        public static void Main(string[] args)
        {
            Coffee myCoffee = new DarkRoast();
            myCoffee = new Milk(myCoffee);
            myCoffee = new Sugar(myCoffee);
            myCoffee = new Whip(myCoffee);

            Console.WriteLine(myCoffee.GetDescription());
            Console.WriteLine(myCoffee.GetPrice() + " euro");
            //Console.WriteLine($"{myCoffee.GetPrice()}:C2"); // C converts it into currency and 2 is the numner of decimals
            //var asd = string.Format(new CultureInfo("en-DE"), "{0:C}", myCoffee.GetPrice());
            //Console.WriteLine(asd); // Here I tried to convert it into German currency
            //Console.WriteLine("€");

            //string.Format(new CultureInfo("da-DK"), "{0:C}", 1456.12155) 
        }
    }

}