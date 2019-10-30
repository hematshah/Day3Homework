using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Homework
{
    class Chef : Cooking
    {
        int num;
        private int howManyChefs = 3;

        // default constuctor for chef class 
        public Chef()
        {
        }

        public Chef(int numberValue)
        {
            num = numberValue;
        }

        public Chef(int numberValue, int numberOfChefs)
        {
            num = numberValue;
            howManyChefs = numberOfChefs;

        }

        public int HowManyChefs
        {
            get => howManyChefs;
            set
            {
                if (num < howManyChefs)
                {
                    howManyChefs = num;
                }
                else if (num > howManyChefs)
                {
                    num = howManyChefs;
                }

            }
        }

    }
    class Cooking : Cookware
    {
        public string Dishes;
        private string CookingUtensils;
        public string InductionHob;
    }
    class Cookware
    {
        private int NumberOfCookwareTypes;
        public string CastIron;
        public string FryingPan;
        public string Wok;
    }





    class Meat
    {
        private double animalFlesh;
        private double fats;
        private double leanMeats;

        public Meat()
        {
        }

        public Meat(double x, double y)
        {
            fats = x;
            leanMeats = y;
        }
        public double GetanimalFlesh()
        {
            return animalFlesh;
        }
        public void SetanimalFlesh(double fat, double leanMeat)
        {
            animalFlesh = (fat / leanMeat) * 100;
        }

        public double MeatRatio()
        {

            double meatRatio = (fats / leanMeats) * 100;
            return meatRatio;

        }

        public virtual void PrintMeatText()
        {

            Console.WriteLine("This is you butcher speaking --> we have different meat to fat ratios. ");

        }

    }
    class MeatType : Meat
    {
        private string Redmeat;
        private string Poultry;
        private string Pork;

        public override void PrintMeatText()
        {
            Console.WriteLine("We have diffrent types of meat available for veriety of meat dishes. ");
        }
    }
    class MeatVariations : MeatType
    {
        public string chicken;
        public string cow;
        public string scheep;
        public string goat;
        public string eggs;
        public string fish;


    }
    class MeatDish : MeatVariations
    {
        private string Curry;
        private bool eaten;

        public override void PrintMeatText()
        {
            Console.WriteLine(" Our signature dish is curry !");
        }
    }






    class Vegetables
    {
        private string Brocoli;
        public string SunFlowerSeed;
        private string Lettuce;
        private string Tomatoes;
        public string olives;
        public string potatoes;

    }
    class FryingVegDish : Oil
    {
        private string chips;

        public bool eaten;
    }
    class Oil : Vegetables
    {
        private string Vegetable;
        private string SunFlower;
        private string Olive;
        public int TypeOfoils;
    }
}
