using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore store = new AnkeFactory();
            Beverage coffee = store.orderCoffee("irishcoffee");

            CoffeeStore store2 = new AnkeFactory();
            Beverage coffee2 = store2.orderCoffee("mocha");
        }
    }
}