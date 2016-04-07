using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class Dog : Animal
    {
      

        public Dog (string AnimalName, string AnimalType, bool ShotsStatus, string FoodType, int FoodAmount, int FeedingsPerDay, bool AnimalStatus)
        {
            animalName = AnimalName;
            animalType = AnimalType;
            shotsStatus = ShotsStatus;
            foodType = FoodType;
            foodAmount = FoodAmount;
            feedingsPerDay = FeedingsPerDay;
            animalStatus = AnimalStatus;

        }
    }
}
