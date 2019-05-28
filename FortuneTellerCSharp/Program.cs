using System;

namespace FortuneTellerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fortune Teller Application!");

            QuestionAsker fortuneAsker = new QuestionAsker();
            AnswerChecker fortuneChecker = new AnswerChecker();

            fortuneAsker.AskFirstName();
            fortuneAsker.FirstName = Console.ReadLine();
            
            

            fortuneAsker.AskLastName();
            fortuneAsker.LastName = Console.ReadLine();

            fortuneAsker.AskAge();
            string ageInput = Console.ReadLine();
            int ageNumber;
            fortuneAsker.AgeNumber = Int32.TryParse(ageInput, out ageNumber);

            fortuneAsker.AskBirthMonthNumber();
            string birthInput = Console.ReadLine();
            int birthNumber;
            fortuneAsker.BirthMonth = Int32.TryParse(birthInput, out birthNumber);

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
            string siblingsInput = Console.ReadLine();
            int siblingsNumber;
            fortuneAsker.SiblingsNumber = Int32.TryParse(siblingsInput, out siblingsNumber);

                    

            //retirement based on age
            fortuneChecker.checkRetirmentYears();
           

            //bank balance based on birth month

            switch (birthNumber)
            {
                case 1:
                    bankBalance = 100;
                    break;

                case 2:
                    bankBalance = 100;
                    break;

                case 3:
                    bankBalance = 100;
                    break;

                case 4:
                    bankBalance = 100;
                    break;

                case 5:
                    bankBalance = 1337;
                    break;

                case 6:
                    bankBalance = 1337;
                    break;

                case 7:
                    bankBalance = 1337;
                    break;

                case 8:
                    bankBalance = 1337;
                    break;
                case 9:
                    bankBalance = 1000000;
                    break;

                case 10:
                    bankBalance = 1000000;
                    break;

                case 11:
                    bankBalance = 1000000;
                    break;
                case 12:
                    bankBalance = 1000000;
                    break;

                default:
                    bankBalance = 0;
                    break;
            }

            //vacation spot based on number of siblings

            if (siblingsNumber < 0)
            {
                vacationSiblings = "Antarctica";
            }
            else if (siblingsNumber == 0)
            {
                vacationSiblings = "Hawaii";
            }
            else if (siblingsNumber == 1)
            {
                vacationSiblings = "Malibu";
            }
            else if (siblingsNumber == 2)
            {
                vacationSiblings = "London";
            }
            else if (siblingsNumber == 3)
            {
                vacationSiblings = "New Zealand";
            }
            else
            {
                vacationSiblings = "Denver";
            }

            //car driven based on favorite color

            if (colorInput.Equals("red", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Mustang";
            }
            else if (colorInput.Equals("orange", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Mercedes";
            }
            else if (colorInput.Equals("yellow", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Subaru";
            }
            else if (colorInput.Equals("green", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Honda";
            }
            else if (colorInput.Equals("blue", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Toyota";
            }
            else if (colorInput.Equals("indigo", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Ford";
            }
            else if (colorInput.Equals("violet", StringComparison.InvariantCultureIgnoreCase))
            {
                carColor = "Tesla";
            }
            else
            {
                carColor = "beat-up scooter";
            }

            //the final concatenation
            Console.WriteLine(fortuneAsker.FirstName + " " + lastName + " will retire in " + retirementYears + " years, with $" + bankBalance + " in their bank account, and will have a vacation home in " + vacationSiblings + ", and will drive a " + carColor + ".");

        }







    }
    
}
