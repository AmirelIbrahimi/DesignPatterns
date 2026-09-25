using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        public CondimentDecorator(Beverage baseBeverage)
        {
            this.baseBeverage = baseBeverage;
            this.Size = baseBeverage.Size;
        }
        public abstract override string GetDescription();

    }
}