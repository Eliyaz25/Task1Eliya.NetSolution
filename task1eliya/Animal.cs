using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Animal
    {
        //תכונות
        protected string name;
        protected int age;
        protected bool isPredator;
        protected int mealCalories;

        //פעולה בונה
        public Animal(string name, int age, bool isPredator, int mealCalories)
        {
            this.name = name;
            this.age = age;
            this.isPredator = isPredator;
            this.mealCalories = mealCalories;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name=name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public bool GetIsPredator()
        {
            return isPredator;
        }

        public void SetIsPredator(bool isPredator)
        {
            this.isPredator = isPredator;
        }

        public int GetMealCalories()
        {
            return mealCalories;
        }

        public void SetMealCalories(int mealCalories)
        {
            this.mealCalories = mealCalories;
        }


        public override string ToString()
        {
            return $"name:{name}\nage:{age}\nis predator:{isPredator}\nmeal calories:{mealCalories}\n";
        }

        //הפעולה מחזירה כמות קלוריות של חיה ביום
        public int Eat()
        {
            return 3*mealCalories;
        }


    }
}
