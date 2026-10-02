using DecoratorPattern.BeverageFactory;
using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore Starbuzz = new Starbuzz();

            PrintBeverage(Starbuzz.OrderBeverage("espresso", Size.TALL));
            PrintBeverage(Starbuzz.OrderBeverage("doppio", Size.GRANDE));
            PrintBeverage(Starbuzz.OrderBeverage("lungo", Size.VENTI));
            PrintBeverage(Starbuzz.OrderBeverage("macchiato", Size.VENTI));
            PrintBeverage(Starbuzz.OrderBeverage("corretta", Size.GRANDE));
            PrintBeverage(Starbuzz.OrderBeverage("conpanna", Size.GRANDE));
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
