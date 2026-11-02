using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class ChocolateMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Simmering Milk and Chocolate");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Whipped Cream");
        }
    }
}
