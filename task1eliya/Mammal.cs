using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Mammal:Animal
    {
        protected int milkCalories;
        protected int pragnencyMonths;

        public Mammal(string name, int age, bool isPredator, int mealCalories, int milkCalories, int pragnencyMonths)
            :base(name, age, isPredator, mealCalories)
        {
            this.pragnencyMonths = pragnencyMonths;
            this.milkCalories = milkCalories;
        }

        public int GetPragnencyMonth()
        {
            return pragnencyMonths;
        }

        public void SetPragnencyMonth(int PragnencyMonths)
        {
            this.pragnencyMonths=PragnencyMonths;
        }

        public int GetmilkCalories()
        {
            return mealCalories;
        }

        public  void SetmilkCalories(int milkCalories)
        {
            this.milkCalories=milkCalories;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nmilk calories:{milkCalories}\nPragnency Months:{pragnencyMonths}\n";
        }

        public new int Eat()
        {
            return base.Eat() + milkCalories;
        }
    }
}
