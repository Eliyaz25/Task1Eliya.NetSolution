using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Snake: Reptile
    {
        protected bool isPoisonous;

        public Snake(string name, int age, bool isPredator, int mealCalories, double tailLength, bool isPoisonous)
            : base(name, age, isPredator, mealCalories, tailLength)
        {
            this.isPoisonous = isPoisonous;
        }

        public bool GetIsPoisonous()
        { return isPoisonous; }

        public void SetIsPoisonous(bool isPoisonous)
        { this.isPoisonous = isPoisonous; }

        public override string ToString()
        {
            return base.ToString()+$"is Poisonous: {isPoisonous}\n";
        }

        public string Dance()
        {
            return "dancing🐍";
        }
    }
}
