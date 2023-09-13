using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Cow : Mammal
    {
        protected int numCalving;

        public Cow(string name, int age, bool isPredator, int mealCalories, int milkCalories, int pragnencyMonths, int numCalving)
            : base(name, age, isPredator, mealCalories, milkCalories, pragnencyMonths)
        {
            this.numCalving = numCalving;
        }

        public int GetNumCalving()
        {
            return numCalving;
        }

        public void SetNumCalving(int numCalving)
        { this.numCalving = numCalving; }

        public override string ToString()
        {
            return base.ToString() + $"num of calving:{numCalving}\n";
        }

        public new int Eat()
        {
            return base.Eat() / 4;
        }
    }
}
