﻿using System;

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

            
            //refactor to have a method that checks for int 

            int ageNumber;
            bool isInt;
            do
            {
               fortuneAsker.AskAge();
               string input = Console.ReadLine();
               isInt = Int32.TryParse(input, out ageNumber);

                if (!isInt)
                {
                    Console.WriteLine("Entry invalid, please enter a number");
                }
               
            } while (!isInt);

            fortuneAsker.AgeNumber = ageNumber;

            fortuneAsker.AskBirthMonthNumber();
            fortuneAsker.BirthMonth = int.Parse(Console.ReadLine());

            
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
            
            //the final concatenation, nothing fancy
            Console.WriteLine(fortuneAsker.FirstName + " " + fortuneAsker.LastName + " will retire in " + fortuneChecker.RetirementYears + " years, with $" + fortuneChecker.BankBalance + " in their bank account, will have a vacation home in " + fortuneChecker.VacationSiblings + ", and will drive a " + fortuneChecker.CarColor + ".");

            //using string.format
            string msg = string.Format("{0} {1} will retire in {2} years, with ${3} uin their bank account, will have a vacation home in {4} and will drive a {5}.", fortuneAsker.FirstName, fortuneAsker.LastName, fortuneChecker.RetirementYears, fortuneChecker.BankBalance, fortuneChecker.VacationSiblings, fortuneChecker.CarColor);
            Console.WriteLine(msg);

            //interpolated string
            Console.WriteLine($"{fortuneAsker.FirstName} {fortuneAsker.LastName} will retire in {fortuneChecker.RetirementYears} years, with ${fortuneChecker.BankBalance} in their bank account, will have a vacation home in {fortuneChecker.VacationSiblings} and will drive a {fortuneChecker.CarColor}.");




        }

    }
    
}
