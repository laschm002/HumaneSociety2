using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kennel kennel = new Kennel();
            HumaneSociety humaneSociety = new HumaneSociety();
            Adopter adopter = new Adopter();
            humaneSociety.enterChoiceToAdmitOrAdopt();
            //kennel.generateCages();
            kennel.assignCageNumber(kennel.marvin);
            kennel.assignCageNumber(kennel.killer);
           // humaneSociety.adoptAnimal(humaneSociety.nina ,kennel.marvin);
            //kennel.feed(kennel.marvin);
            //kennel.changeShotStatus(kennel.marvin);
            Console.ReadKey();
        }
    }
}
