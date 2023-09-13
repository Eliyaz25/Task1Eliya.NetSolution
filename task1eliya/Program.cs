using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
   public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] names = { "Moana", "Cinderella", "Ariel", "Mulan", "Aurora"};
            Mammal[] arrMammal =
            {
                new Mammal(names[rnd.Next(names.Length)], rnd.Next(1, 100), false,
                rnd.Next(1000, 2000), rnd.Next(100, 500), rnd.Next(5, 20)),
                new Hipo(names[rnd.Next(names.Length)], rnd.Next(1, 50), false,
                rnd.Next(1000, 2000), rnd.Next(100, 500), rnd.Next(5, 20), rnd.Next(50, 100)),
                new Hipo(names[rnd.Next(names.Length)], rnd.Next(1, 50), false,
                rnd.Next(1000, 2000), rnd.Next(100, 500), rnd.Next(5, 20), rnd.Next(50, 100)),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 20), false,
                rnd.Next(1000, 2000), rnd.Next(100, 500), rnd.Next(5, 100), rnd.Next(10, 60)),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 20), false,
                rnd.Next(1000, 2000), rnd.Next(100, 500), rnd.Next(5, 20), rnd.Next(10, 60))
            };
            Reptile[] arrReptile =
            {
                new Reptile(names[rnd.Next(names.Length)], rnd.Next(1, 70), true, rnd.Next(100, 500),
                rnd.Next(1, 20)),
                new crocodile(names[rnd.Next(names.Length)], rnd.Next(1, 70), true, rnd.Next(100, 500),
                rnd.Next(1, 20), true),
                new Snake(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 500),
                rnd.Next(1, 20), true),
                new Snake(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 500),
                rnd.Next(1, 20), true),
                new Eunectes(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 500),
                rnd.Next(1, 20), false, "E. beniensis")
                
            };
            Animal[] arrAnimal =
            {
                new Animal(names[rnd.Next(names.Length)], rnd.Next(1, 100), true, rnd.Next(100, 2000)),
                new Mammal(names[rnd.Next(names.Length)], rnd.Next(1, 100), true, rnd.Next(100, 2000),
                rnd.Next(100, 500), rnd.Next(1, 20)),
                new Bird(names[rnd.Next(names.Length)], rnd.Next(1, 20), false, rnd.Next(100, 2000),
                rnd.Next(5, 50), rnd.Next(1, 30) / rnd.Next(2, 5)),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 20), false,
                rnd.Next(100, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(1, 5)),
                new Hipo(names[rnd.Next(names.Length)], rnd.Next(1, 60), false,
                rnd.Next(100, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(20, 80)),
                new Snake(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 2000),
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), true),
                new Eunectes(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 2000),
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), false, "E. beniensis"),
                new HammingBird(names[rnd.Next(names.Length)], rnd.Next(1, 20), true, rnd.Next(100, 2000),
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), rnd.Next(1, 30) / rnd.Next(2, 5), rnd.Next(7,11)),
                
                
            };

            

            Console.WriteLine("Mammals:\n");
            foreach (var animal in arrMammal)
            {
                Console.WriteLine(animal+"\n");
            }
            Console.WriteLine("Reptiles:\n");
            foreach (var animal in arrReptile)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }
            Console.WriteLine("Animals:\n");
            foreach (var animal in arrAnimal)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }

           
        }

        //ט.כניסה: הפעולה מקבלת מערך של חיות
        //ט.יציאה: הפעולה מחזירה את סכום הקלוריות של כל החיות 
        public static int SumCalories(Animal[] animals)
        {
            int sumCalories = 0;
            foreach (var animal in animals)
                sumCalories += animal.Eat();
            return sumCalories;
        }

        //ט.כניסה: הפעולה מקבלת מערך של חיות
        //ט.יציאה: הפעולה מחזירה את מספר היונקים
        public static int CountMammals(Animal[] animals)
        {
            int countMammals = 0;
            foreach(var animal in animals)
                if(animal is Mammal)
                    countMammals++;
            return countMammals;
        }

        //ט.כניסה: הפעולה מקבלת מערך של חיות
        //ט.יציאה: בפעולה ציפורים ונחשים רוקדים
        public static void DanceBirdAndSnake(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Bird)
                    (animal as Bird).Dance();
                else if(animal is Snake)
                    (animal as Snake).Dance();
            }
        }

        //ט.כניסה: הפעולה מקבלת מערך של חיות
        //טץיציאה: הפעולה מחזירה את שם ההיפופוטם עם הכי הרבה אחוזי שומן
        public static string FattestHippo(Animal[] animals)
        {
            Hipo fattestHippo = null;
            double maxFatPrecent = 0;

            foreach(var animal in animals)
            {
                if (animal is Hipo)
                    if ((animal as Hipo).GetFatPrecent() > maxFatPrecent)
                    {
                        fattestHippo = (animal as Hipo);
                        maxFatPrecent = fattestHippo.GetFatPrecent();
                    }
            }

            return fattestHippo.GetName();
        }




    }
}
