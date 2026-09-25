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
        VENTI
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
            switch (Size)
            {
                case Size.TALL:
                    return 1.00;
                case Size.GRANDE:
                    return 1.50;
                case Size.VENTI:
                    return 2.00;
                break;
            }
            return 0.0;
        }
    }
}
