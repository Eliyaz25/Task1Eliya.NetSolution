using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1eliya
{
    public class Park
    {
        private Animal[] animals;
        private int currentAnimals;

        public Park()
        {
            animals = new Animal[0];
            currentAnimals = 0;
        }

        public void AddAnimal(Animal animal)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i] == null)
                {
                    animals[i] = animal;
                    currentAnimals++;
                    break;
                }
            }

        }

        public List<Animal> tenAbovePredators()
        {
            List<Animal> tenAbovePredators = new List<Animal>();
            for (int i = 0; i < 1000; i++)
            {
                if(animals[i] != null)
                    if (animals[i].GetIsPredator() && animals[i].GetAge()>=10)
                        tenAbovePredators.Add(animals[i]);
            }
            return tenAbovePredators;
        }

        public int CountReptileBirdPredators()
        {
            int counter = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(animals[i] != null)
                    if((animals[i] is Bird || animals[i] is Reptile) && animals[i].GetIsPredator())
                        counter++;
            }
            return counter;
        }
    }
}
