using System;

namespace FortuneTellerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fortune Teller Application!");

            QuestionAsker fortuneAsker = new QuestionAsker();
            AnswerChecker fortuneChecker = new AnswerChecker(fortuneAsker);

            fortuneAsker.AskFirstName();
            fortuneAsker.FirstName = Console.ReadLine();
            
            

            fortuneAsker.AskLastName();
            fortuneAsker.LastName = Console.ReadLine();

            //if person replies with non-number, inform them to choose a number and try again Try parse?

            //fortuneAsker.AskAge();
            //string ageInput = Console.ReadLine();
            //int ageNumber;
            //bool checkInt = Int32.TryParse(ageInput, out ageNumber);
            int ageNumber;
            bool checkInt;
            do
            {
                fortuneAsker.AskAge();
               string ageInput = Console.ReadLine();
               checkInt = Int32.TryParse(ageInput, out ageNumber);

                if (!checkInt)
                {
                    Console.WriteLine("Entry invalid, please enter a number");
                }
                else
                {
                    fortuneAsker.AgeNumber = int.Parse(ageInput);
                }
            } while (!checkInt);


            fortuneAsker.AskBirthMonthNumber();
            fortuneAsker.BirthMonth = int.Parse(Console.ReadLine());

            //maybe see how to do this
            do
            {
                fortuneAsker.AskFavoriteColor();
                fortuneAsker.FavoriteColor = Console.ReadLine();
                if (fortuneAsker.FavoriteColor.Equals("help", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("The ROYGBIV colors are Red, Orange, Green, Blue, Indigo, and Violet.");
                }
            } while (fortuneAsker.FavoriteColor.Equals("help", StringComparison.InvariantCultureIgnoreCase));

            fortuneAsker.AskNumberOfSiblings();            
            fortuneAsker.SiblingsNumber = int.Parse(Console.ReadLine());                    

            //retirement based on age

            fortuneChecker.CheckRetirmentYears();
           

            //bank balance based on birth month

            fortuneChecker.CheckBankBalance();
            
            //vacation spot based on number of siblings

            fortuneChecker.CheckVacationSpot();
           

            //car driven based on favorite color
            fortuneChecker.CheckCarColor();
            
            //the final concatenation
            Console.WriteLine(fortuneAsker.FirstName + " " + fortuneAsker.LastName + " will retire in " + fortuneChecker.RetirementYears + " years, with $" + fortuneChecker.BankBalance + " in their bank account, will have a vacation home in " + fortuneChecker.VacationSiblings + ", and will drive a " + fortuneChecker.CarColor + ".");

        }

    }
    
}
