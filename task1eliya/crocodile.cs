using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class crocodile : Reptile
    {
        protected bool hadTeethCheck;

        public crocodile(string name, int age, bool isPredator, int mealCalories, double tailLength, bool hadTeethCheck)
            : base(name, age, isPredator, mealCalories, tailLength)
        {
            this.hadTeethCheck = hadTeethCheck;
        }

        public bool GetHadTeethCheck()
        { return hadTeethCheck; }

        public void SetHadTeethCheck(bool hadTeethCheck)
        { this.hadTeethCheck = hadTeethCheck; }

        public override string ToString()
        {
            return base.ToString()+$"had teeth check:{hadTeethCheck}\n";
        }
    }
}
