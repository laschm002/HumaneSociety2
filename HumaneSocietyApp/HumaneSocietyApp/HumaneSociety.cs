using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class HumaneSociety
    {
        public double money;
        Kennel kennel;
        Adopter adopter;
        public Adopter nina = new Adopter();

        public HumaneSociety()
        {
            kennel = new Kennel();
            adopter = new Adopter();
        }

        public void enterChoiceToAdmitOrAdopt ()
        {
            Console.WriteLine("Would you like to admit a new Animal, enter adoption information, or record animal maintence?");
            Console.WriteLine("Enter 1 to admit a new animal" );
            Console.WriteLine("Enter 2 to adoption information");
            Console.WriteLine("Enter 3 to record animal maintence");

            int response = Convert.ToInt32(Console.ReadLine());

            if (response == 1)
            {
                    inputAnimalInfo();
            }
                   
            else if (response == 2)
            { 
                    getAdopterName();
            }
            else if (response == 3)
            {
                kennel.performAnimalMaintence();
            }

            else
            { 
                Console.WriteLine("You can only enter 1,2, or 3");
                enterChoiceToAdmitOrAdopt();
            }

        }
        public string enterType()
        {
            Console.WriteLine("Please enter the type of the animal?");

            return Console.ReadLine();
        }
        public string enterAnimalName()
        {
            Console.WriteLine("What is the name of the animal?");
            
            return Console.ReadLine();
        }

        public string enterBreed()
        {
            Console.WriteLine("What is the breed of the animal?");

            return Console.ReadLine();
        }
        
        public bool enterShotStatus()
        {
            Console.WriteLine("Are the animal's shots up todate?");
            string shotsStatus = Console.ReadLine();
            if (shotsStatus == "yes")
            {
                return true;
            }
            else if (shotsStatus == "no")
            {
                return false;
            }
            else
            {
                enterShotStatus();
                return false;
            }
        }

        public string enterFoodType()
        {
            Console.WriteLine("What type of food does the animal eat?");
            return Console.ReadLine();

        }

        public int enterFoodAmount()
        {
            Console.WriteLine("How many cups of food does the animal eat in a feeding?");

            return Convert.ToInt32(Console.ReadLine());
        }

        public int enterNumberOfFeedingsPerDay()
        {
            Console.WriteLine("How many times a day does the animal eat?");
            
            return Convert.ToInt32(Console.ReadLine());
        }

        public Animal inputAnimalInfo()
        {

            if (enterType() == "dog")

            {
 
                Dog animalName = new Dog(enterAnimalName(),enterBreed(), enterShotStatus(), enterFoodType(), enterFoodAmount(), enterNumberOfFeedingsPerDay(), true);
                kennel.assignCageNumber(animalName);
                return animalName;
            }
            else if (enterType() == "cat")
            {
                Cat animalName = new Cat(enterAnimalName(), enterBreed(), enterShotStatus(), enterFoodType(), enterFoodAmount(), enterNumberOfFeedingsPerDay(), true);

                kennel.assignCageNumber(animalName);
                return animalName;
            }
            else
            {
                return inputAnimalInfo();
            }
        }

        public void beginAdoptionProcess ()
        {
            getAdopterName();
            createAdopterProfile();
        }
        public string getAdopterName()
        {
            Console.WriteLine("Enter the name of the adopter!");
            return Console.ReadLine();
        }

        public Adopter createAdopterProfile()
        {
            Adopter adopter = new Adopter();

            return adopter;
        }
        
        public void adoptAnimal(Adopter adopter, Animal animal)
        {
            //adopter.money -= 50;
            money += 50;
            kennel.removeAnimal(animal);

        }

        public void feedAnimal ()
        {
            Console.WriteLine("Do you want to feed an animal?");
        }
    }

}

