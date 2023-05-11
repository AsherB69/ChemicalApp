﻿//imports
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
            //display screen
            Console.WriteLine(@"        __                   _            _____" + "\n" +
                                 @"  _____/ /_  ___  ____ ___  (_)________ _/ /   |  ____  ____" + "\n" +
                                 @" / ___/ __ \/ _ \/ __ `__ \/ / ___/ __ `/ / /| | / __ \/ __ \" + "\n" +
                                 @"/ /__/ / / /  __/ / / / / / / /__/ /_/ / / ___ |/ /_/ / /_/ /" + "\n" +
                                 @"\___/_/ /_/\___/_/ /_/ /_/_/\___/\__,_/_/_/  |_/ .___/ .___/" + "\n" +
                                 @"                                              /_/   /_/" + "\n");

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

            else 
            {
                Console.WriteLine("please choose a chemical listed above");
                OneChemical();
            }



            float sumEfficency = 0;

            //Loop 5 times

            for (int i = 0; i < 5; i++)
            {
                //Randomly generate a number for the live germs present
                Random rndNumber = new Random();
                int b4GermCount = rndNumber.Next(1000, 10000);

                Console.WriteLine($"there are {b4GermCount} germs");

                Console.WriteLine($"adding {userchoice}");



                //Wait some time

                Console.WriteLine("wait 5 seconds");

                //will sleep for 5 sec
                Thread.Sleep(5000);


                int afterGermCount = rndNumber.Next(0, b4GermCount);


                //Determine the efficiency rating of the chemical killed the germs by subtracting the two amounts and dividing by the time.
                float efficency = (float)(b4GermCount - afterGermCount) / 2;

                sumEfficency += efficency;
            }
            float finalEfficency = sumEfficency / 5;


            //display final efficiency rating, this will be an average of the 5 tests
            Console.WriteLine($"the final efficency for {userchoice} is {finalEfficency}");
        }


        //when run or main process
        static void Main(string[] args)
        {
            OneChemical();
        }
    }
}
