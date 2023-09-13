using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Bird: Animal, IBird
    {
        
        protected double flightHeight;
        protected double wingspan;

        
        public Bird(string name, int age, bool isPredator, int mealCalories, double flightHeight, double wingSpan)
            :base(name, age, isPredator, mealCalories)
        {
            this.flightHeight = flightHeight;
            this.wingspan = wingSpan;
        }

        public double GetFlightHeight()
        {
            return flightHeight;
        }

        public void SetFlightHeight(double flightHeight)
        {
            this.flightHeight = flightHeight;
        }

        public double GetWingspan()
        {
            return wingspan;
        }

        public void SetWingspan(double wingspan)
        {
            this.wingspan= wingspan;
        }

        public override string ToString()
        {
            return base.ToString()+ $"flight height:{flightHeight}\nwingspan:{wingspan}\n";
        }

        public string Sing()
        {
            return "tweettweet🎶🎶";
        }

        public string Dance()
        {
            return "dancing🐣";
        }

        public void TakeOff()
        {
            Console.WriteLine("birs is taking off");
        }

        public void Landing()
        {
            Console.WriteLine("bird is landing");
        }

        public void gliding()
        {
            Console.WriteLine("bird is gliding");
        }
    }
}
