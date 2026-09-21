using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class SimpleBeverageFactory
    {
        public virtual Beverage CreateBeverage(string type)
        {
            Beverage drink = null;
        }
    }
}
