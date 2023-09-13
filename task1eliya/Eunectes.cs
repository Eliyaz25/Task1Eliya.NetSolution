using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Eunectes : Snake
    {
        protected string species;

        public Eunectes(string name, int age, bool isPredator, int mealCalories, double tailLength, bool isPoisonous, string species)
            : base(name, age, isPredator, mealCalories, tailLength, isPoisonous)
        {
            this.species = species;
        }

        public string GetSpecies()
        { return species; }

        public void SetSpecies(string species)
            { this.species = species; }

        public override string ToString()
        {
            return base.ToString()+$"species: {species}\n";
        }
    }
}
