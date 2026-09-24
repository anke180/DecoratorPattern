using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class AnkeFactory : CoffeeStore
    {
        public AnkeFactory() 
        {
        }

        public override Beverage createCoffee(string type)
        {
            Beverage beverage = null;

            if (type.Equals("espresso"))
            {
                beverage = new Espresso();
            } else if (type.Equals("doppio"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
            } else if (type.Equals("lungo"))
            {
                beverage = new Espresso();
                beverage = new Condiments.Water(beverage);
            } else if (type.Equals("doppio"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("corretta"))
            {
                beverage = new Espresso();
                beverage = new Liqour(beverage);
            } else if (type.Equals("conPanna"))
            {
                beverage = new Espresso();
                beverage = new Whip(beverage);
            } else if (type.Equals("cappucinno"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("americano"))
            {
                beverage = new Espresso();
                beverage = new Condiments.Water(beverage);
                beverage = new Condiments.Water(beverage);
            } else if (type.Equals("cafeLatte"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("flatWhite"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
            } else if (type.Equals("romana"))
            {
                beverage = new Espresso();
                beverage = new Lemon(beverage);
            } else if (type.Equals("morocchino"))
            {
                beverage = new Espresso();
                beverage = new Condiments.Chocolate(beverage);
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("mocha"))
            {
                beverage = new Espresso();
                beverage = new Condiments.Chocolate(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            } else if (type.Equals("bicerin"))
            {
                beverage = new Espresso();
                beverage = new BlackChocolate(beverage);
                beverage = new WhiteChocolate(beverage);
                beverage = new Whip(beverage);
            } else if (type.Equals("breve"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
                beverage = new HalfMilk(beverage);
            } else if (type.Equals("rafCaffee"))
            {
                beverage = new Espresso();
                beverage = new VanillaSugar(beverage);
                beverage = new Cream(beverage);
            } else if (type.Equals("meadRaf"))
            {
                beverage = new Espresso();
                beverage = new Honey(beverage);
                beverage = new Cream(beverage);
            } else if (type.Equals("galao"))
            {
                beverage = new Espresso();
                beverage = new MilkFoam(beverage);
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("caffeAffogato"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new IceCream(beverage);
            } else if (type.Equals("viennatype"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Whip(beverage);
                beverage = new Whip(beverage);
            } else if (type.Equals("glace"))
            {
                beverage = new Espresso();
                beverage = new IceCream(beverage);
            } else if (type.Equals("chocolateMilk"))
            {
                beverage = new Beverages.Chocolate();
                beverage = new Milk(beverage);
                beverage = new Milk(beverage);
            } else if (type.Equals("demiCreme"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Cream(beverage);
                beverage = new Cream(beverage);
            } else if (type.Equals("latteMacchiato"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new MilkFoam(beverage);
            } else if (type.Equals("freddo"))
            {
                beverage = new Espresso();
                beverage = new Liqour(beverage);
                beverage = new Ice(beverage);
            } else if (type.Equals("frappuccino"))
            {
                beverage = new Espresso();
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Whip(beverage);
            } else if (type.Equals("caramelFrappuccino"))
            {
                beverage = new Espresso();
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Cream(beverage);
                beverage = new Syrup(beverage);
            } else if (type.Equals("frappe"))
            {
                beverage = new Espresso();
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new IceCream(beverage);
            } else if (type.Equals("irishcoffee"))
            {
                beverage = new Espresso();
                beverage = new Espresso(beverage);
                beverage = new Whiskey(beverage);
                beverage = new Whip(beverage);
            }

            return beverage;
        }
    }
}
