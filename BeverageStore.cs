using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BeverageStore
    {
        SimpleBeverageFactory factory;
        public BeverageStore(SimpleBeverageFactory factory)
        {
            this.factory = factory;
        }

        public Beverage OrderBeverage(string type)
        {
            Beverage beverage = factory.CreateBeverage(type);
            return beverage;
        }
    }
}
