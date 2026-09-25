using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Beverages.Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new Beverages.Espresso();
            doppio.Size = Size.GRANDE;
            doppio = new Condiments.Espresso(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new Beverages.Espresso();
            lungo.Size = Size.VENTI;
            lungo = new Condiments.Water(lungo);
            PrintBeverage(lungo);

            Beverage macchiato = new Beverages.Espresso();
            macchiato.Size = Size.VENTI;
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new Beverages.Espresso();
            corretta.Size = Size.GRANDE;
            corretta = new Liquor(corretta);
            PrintBeverage(corretta);

            Beverage conpanna = new Beverages.Espresso();
            conpanna.Size = Size.GRANDE;
            conpanna = new Whip(conpanna);
            PrintBeverage(conpanna);

            Beverage cappucinno = new Beverages.Espresso();
            cappucinno.Size = Size.GRANDE;
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            PrintBeverage(cappucinno);

            Beverage americano = new Beverages.Espresso();
            americano.Size = Size.VENTI;
            americano = new Condiments.Water(americano);
            americano = new Condiments.Water(americano);
            PrintBeverage(americano);

            Beverage caffélatte = new Beverages.Espresso();
            caffélatte.Size = Size.VENTI;
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new SteamedMilk(caffélatte);
            caffélatte = new MilkFoam(caffélatte);
            PrintBeverage(caffélatte);

            Beverage flatwhite = new Beverages.Espresso();
            flatwhite.Size = Size.VENTI;
            flatwhite = new SteamedMilk(flatwhite);
            flatwhite = new SteamedMilk(flatwhite);
            PrintBeverage(flatwhite);

            Beverage romana = new Beverages.Espresso();
            romana.Size = Size.VENTI;
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Beverages.Espresso();
            morocchino.Size = Size.VENTI;
            morocchino = new Condiments.Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Beverages.Espresso();
            mocha.Size = Size.VENTI;
            mocha = new Condiments.Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Beverages.Espresso();
            bicerin.Size = Size.VENTI;
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Beverages.Espresso();
            breve.Size = Size.VENTI;
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            breve = new Whip(breve);
            PrintBeverage(breve);

            Beverage rafcoffee = new Beverages.Espresso();
            rafcoffee.Size = Size.VENTI;
            rafcoffee = new VanillaSugar(rafcoffee);
            rafcoffee = new Cream(rafcoffee);
            PrintBeverage(rafcoffee);

            Beverage meadraf = new Beverages.Espresso();
            meadraf.Size = Size.VENTI;
            meadraf = new Honey(meadraf);
            meadraf = new Cream(meadraf);
            PrintBeverage(meadraf);

            Beverage galao = new Beverages.Espresso();
            galao.Size = Size.VENTI;
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage cafféaffogato = new Beverages.Espresso();
            cafféaffogato.Size = Size.VENTI;
            cafféaffogato = new Condiments.Espresso(cafféaffogato);
            cafféaffogato = new IceCream(cafféaffogato);
            PrintBeverage(cafféaffogato);

            Beverage viennacoffee = new Beverages.Espresso();
            viennacoffee.Size = Size.VENTI;
            viennacoffee = new Condiments.Espresso(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            viennacoffee = new Whip(viennacoffee);
            PrintBeverage(viennacoffee);

            Beverage glace = new Beverages.Espresso();
            glace.Size = Size.VENTI;
            glace = new Condiments.Espresso(glace);
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolatemilk = new Beverages.Chocolate();
            chocolatemilk.Size = Size.VENTI;
            chocolatemilk = new Milk(chocolatemilk);
            chocolatemilk = new Milk(chocolatemilk);
            PrintBeverage(chocolatemilk);

            Beverage democréme = new Beverages.Espresso();
            democréme.Size = Size.VENTI;
            democréme = new Condiments.Espresso(democréme);
            democréme = new Cream(democréme);
            democréme = new Cream(democréme);
            PrintBeverage(democréme);

            Beverage lattemacchiato = new Beverages.Espresso();
            lattemacchiato.Size = Size.VENTI;
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new SteamedMilk(lattemacchiato);
            lattemacchiato = new MilkFoam(lattemacchiato);
            PrintBeverage(lattemacchiato);

            Beverage freddo = new Beverages.Espresso();
            freddo.Size = Size.VENTI;
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frapppuccino = new Beverages.Espresso();
            frapppuccino.Size = Size.VENTI;
            frapppuccino = new Ice(frapppuccino);
            frapppuccino = new SteamedMilk(frapppuccino);
            frapppuccino = new Whip(frapppuccino);
            PrintBeverage(frapppuccino);

            Beverage caramelfrappuccino = new Beverages.Espresso();
            caramelfrappuccino.Size = Size.VENTI;
            caramelfrappuccino = new Ice(caramelfrappuccino);
            caramelfrappuccino = new SteamedMilk(caramelfrappuccino);
            caramelfrappuccino = new Cream(caramelfrappuccino);
            caramelfrappuccino = new Syrup(caramelfrappuccino);
            PrintBeverage(caramelfrappuccino);

            Beverage frappe = new Beverages.Espresso();
            frappe.Size = Size.VENTI;
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishcoffee = new Beverages.Espresso();
            irishcoffee.Size = Size.VENTI;
            irishcoffee = new Beverages.Espresso(irishcoffee);
            irishcoffee = new Whiskey(irishcoffee);
            irishcoffee = new Whip(irishcoffee);
            PrintBeverage(irishcoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}