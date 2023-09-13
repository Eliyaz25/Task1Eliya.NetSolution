using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Reptile: Animal, IReptile
    {
        protected double tailLength;

        public Reptile(string name, int age, bool isPredator, int mealCalories, double tailLength)
            :base(name, age, isPredator, mealCalories)
        {
            this.tailLength = tailLength;
        }

        public void BodyTempeCheck()
        {
            Console.WriteLine("reptile is checking body tempature");
        }

        public void crawl()
        {
            Console.WriteLine("reptile is crawling");
        }

        public void defense()
        {
            Console.WriteLine("reptile in defense");
        }

        public double GetTailLength()
        {
            return tailLength;
        }

        public void SetTailLength(double tailLength)
        {
            this.tailLength=tailLength;
        }

        public override string ToString()
        {
            return base.ToString()+ $"tail length: {tailLength}\n";
        }
    }
}
