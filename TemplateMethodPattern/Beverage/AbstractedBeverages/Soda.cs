using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Soda : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Simmering Soda");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Ice");
        }

        public override bool CustomerWantsCondiment()
        {
            Console.WriteLine("Would you like ice with your soda (y/n)?");
            String answer = Console.ReadLine();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
