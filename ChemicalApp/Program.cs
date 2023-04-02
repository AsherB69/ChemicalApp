//imports
using System;
using System.Threading;

namespace ChemicalApp
{
    class Program
    {
        //global varieables

        //methods or functions
        static void OneChemical()
        {

            //Randomly generate a number for the live germs present
            Random rndNumber = new Random();
            int b4GermCount = rndNumber.Next(1000, 10000);

            Console.WriteLine($"there are currently {b4GermCount} germs in the dish");

            //Chemical user is testing is added
            Console.WriteLine("choose which chemical you would like to test/n 1. cyanide/n 2. chlorine /n 3. propane");
            string userchoice = Console.ReadLine();

            if (userchoice.Equals("cyanide"))
            {
                Console.WriteLine("you have chosen cyanide");
            }

            if (userchoice.Equals("chlorine"))
            {
                Console.WriteLine("you have chosen chlorine");
            }

            if (userchoice.Equals("propane"))
            {
                Console.WriteLine("you have chosen propane");
            }




            //Wait some time
            static void Main()
            {
                //will sleep for 5 sec
                Thread.Sleep(5000); 
            }


            //Determine the efficiency rating of the chemical killed the germs by subtracting the two amounts and dividing by the time.


            //Loop 5 times

            //display final efficiency rating, this will be an average of the 5 tests

        }


        //when run or main process
        static void Main(string[] args)
        {
            OneChemical();
        }
    }
}
