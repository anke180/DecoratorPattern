using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual double cost()
        {
            if (Size == Size.TALL)
            {
                return cost() + 0.15;
            }
            else if (Size == Size.GRANDE)
            {
                return cost() +  0.20;
            }
            else if (Size == Size.VENDI)
            {
                return cost() + 0.25;
            }
            else
            {
                return cost();
            }
        }
    }
}
