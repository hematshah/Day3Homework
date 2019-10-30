using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            Chef chef1 = new Chef(2);
            Chef chef2 = new Chef(4, 1);
            int cheftype = chef.HowManyChefs; // not able to have parameters
            Console.WriteLine(cheftype);

            Meat meat = new Meat(2, 10);
            MeatVariations meat1 = new MeatVariations();
            double meatPercentage = meat.MeatRatio();
            double meatPercentage1 = meat1.GetanimalFlesh();
            Console.WriteLine("the lean meat percentage is " + meatPercentage + " %");
            Console.WriteLine("the lean meat percentage is " + meatPercentage1 + " %");

            Console.WriteLine("");

            Meat[] printingMeatMessages = { new Meat(), new MeatDish(), new MeatType() };
            printingMeatMessages[0].PrintMeatText();
            printingMeatMessages[1].PrintMeatText();
            printingMeatMessages[2].PrintMeatText();

            Console.WriteLine("");

            MeatVariations printingMeatText = new MeatVariations();
            printingMeatText.PrintMeatText();

            Console.WriteLine("");

            Meat printingMeatText1 = new MeatDish();
            printingMeatText1.PrintMeatText();






        }
    }
}
