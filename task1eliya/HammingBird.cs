using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class HammingBird: Bird
    {
        protected int lifeExpectancy;

        public HammingBird(string name, int age, bool isPredator, int mealCalories, double flightHeight, double wingSpan, int lifeExpectancy)
            : base(name, age, isPredator, mealCalories, flightHeight, wingSpan)
        {
            this.lifeExpectancy = lifeExpectancy;
        }

        public int GetSpecies()
        { return lifeExpectancy; }

        public void SetSpecies(int lifeExpectancy)
        { this.lifeExpectancy = lifeExpectancy; }
        

        public override string ToString()
        {
            return base.ToString()+$"life expectancy: {lifeExpectancy}\n";
        }

    }
}
