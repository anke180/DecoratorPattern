using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal abstract class CoffeeStore
    {


        public CoffeeStore()
        {
        }

        public Beverage orderCoffee(string type)
        {
            Beverage coffee = createCoffee(type);
            PrintBeverage(coffee);
            return coffee;
        }

        public void PrintBeverage(Beverage coffee)
        {
            Console.WriteLine(coffee.GetDescription() + " $" + coffee.cost().ToString("#.##"));
        }
        public abstract Beverage createCoffee(string type);
    }
}
