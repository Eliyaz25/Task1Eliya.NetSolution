using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Hipo : Mammal
    {
        protected double fatPrecent;

        public Hipo(string name, int age, bool isPredator, int mealCalories, int milkCalories, int pragnencyMonths, double fatPrecent)
            : base(name, age, isPredator, mealCalories, milkCalories, pragnencyMonths)
        {
            this.fatPrecent = fatPrecent;
        }

        public double GetFatPrecent()
        {
            return fatPrecent;
        }

        public void SetFatPrecent(double fatPrecent)
        {
            this.fatPrecent = fatPrecent;
        }

        public override string ToString()
        {
            return base.ToString() + $"fat precent:{fatPrecent}\n";
        }
    }
}
