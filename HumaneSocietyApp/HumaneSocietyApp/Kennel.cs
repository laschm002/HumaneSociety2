using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class Kennel
    {
        public int food = 100;
        public int medicine = 100;
        Animal animal;
        public List<Cage> cages;
        public Cat marvin = new Cat("marvin", "siamese cat", false, "fancy feast", 1, 2, true);
        public Dog killer = new Dog("killer", "hellhound", true, "beef", 4, 5, true);

        public Kennel()
        {
            animal = new Animal();
            cages = new List<Cage>();
        }
        
        public List<Cage> generateCages()
        {
            Cage cage1 = new Cage(false, animal);
            Cage cage2 = new Cage(false, animal);
            Cage cage3 = new Cage(false, animal);
            Cage cage4 = new Cage(false, animal);
            Cage cage5 = new Cage(false, animal);

                cages.Add(cage1);
                cages.Add(cage2);
                cages.Add(cage3);
                cages.Add(cage4);
                cages.Add(cage5);
            foreach (Cage cage in cages)
            {
                Console.WriteLine(cage.animal);
            }
            return cages;
        }

        public void assignCageNumber(Animal animal)
        {
          
                cages.Add(new Cage(false, animal));

        }
        public List<Cage> removeAnimal(Animal animal)
        {
                cages.Remove();
            
            return cages;
        }


        public void feed (Animal animal)
        {
            animal.foodAmount += 1 * animal.feedingsPerDay;
            food -= 1 * animal.feedingsPerDay;
        }

        public bool changeShotStatus(Animal animal)
        {
            animal.shotsStatus = true;
            medicine -= 10;

            return animal.shotsStatus;
        }

        public bool changeAnimalStatus(Animal animal)
        {
            animal.animalStatus = true;
            

            return animal.animalStatus;
        }

        public void performAnimalMaintence()
        {
            Console.WriteLine("Please enter the name of the animal");
            Console.WriteLine(" ");
            Console.WriteLine("What would you like to do to the animal?");
            Console.WriteLine("Enter 1 to feed the animal.");
            Console.WriteLine("Enter 2 to give it a shot");
            Console.WriteLine("Enter 3 to change the status because it died");
            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                feed(animal);
            }

            else if (response == 2)
            {
                changeShotStatus(animal);
            }
            else if (response == 3)
            {
                changeAnimalStatus(animal);
            }

            else
            {
                Console.WriteLine("You can only enter 1,2, or 3");
                performAnimalMaintence();
            }
        }

    }
}
