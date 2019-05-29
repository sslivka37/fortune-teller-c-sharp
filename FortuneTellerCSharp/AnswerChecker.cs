using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneTellerCSharp
{
    class AnswerChecker
    {
        private QuestionAsker _fortuneAsker;

        public string VacationSiblings { get; set; }
        public string CarColor { get; set; }
        public int RetirementYears { get; set; }
        public int BankBalance { get; set; }

        public int intInput { get; set; }


        public AnswerChecker(QuestionAsker fortuneAsker)
        {
            this._fortuneAsker = fortuneAsker;
        }

       
        //retirement based on age

        public void CheckRetirmentYears()
        {
            if (_fortuneAsker.AgeNumber % 2 == 1)
            {
                RetirementYears = 30;
            }
            else
            {
                RetirementYears = 100;
            }
        }

        //bank balance based on birth month

        //refactored to reduce code, replaced switch with if/else conditional

        public void CheckBankBalance()
        {

            if (_fortuneAsker.BirthMonth > 0 && _fortuneAsker.BirthMonth <= 4)
            {
                BankBalance = 100;
            }
            else if (_fortuneAsker.BirthMonth >= 5 && _fortuneAsker.BirthMonth <= 8)
            {
                BankBalance = 1337;
            }
            else if (_fortuneAsker.BirthMonth >= 9 && _fortuneAsker.BirthMonth <= 12)
            {
                BankBalance = 1000000;
            }

        }

            //vacation spot based on number of siblings
            //refactor to bump out if negative integer, then continue as switch

            public void CheckVacationSpot()
            {
                if (_fortuneAsker.SiblingsNumber < 0)
                {
                    VacationSiblings = "Antarctica";
                }
                else if (_fortuneAsker.SiblingsNumber == 0)
                {
                    VacationSiblings = "Hawaii";
                }
                else if (_fortuneAsker.SiblingsNumber == 1)
                {
                    VacationSiblings = "Malibu";
                }
                else if (_fortuneAsker.SiblingsNumber == 2)
                {
                    VacationSiblings = "London";
                }
                else if (_fortuneAsker.SiblingsNumber == 3)
                {
                    VacationSiblings = "New Zealand";
                }
                else
                {
                    VacationSiblings = "Denver";
                }
            }
        

        //car driven based on favorite color
        //refactored to add temporary variable to lower case, removed all of the checking for equality ignore case

        public void CheckCarColor()
        {
            string favoriteColorLowerCase = _fortuneAsker.FavoriteColor.ToLower();
            if (favoriteColorLowerCase.Equals("red"))
            {
                CarColor = "Mustang";
            }
            else if (favoriteColorLowerCase.Equals("orange"))
            {
                CarColor = "Mercedes";
            }
            else if (favoriteColorLowerCase.Equals("yellow"))
            {
                CarColor = "Subaru";
            }
            else if (favoriteColorLowerCase.Equals("green"))
            {
                CarColor = "Honda";
            }
            else if (favoriteColorLowerCase.Equals("blue"))
            {
                CarColor = "Toyota";
            }
            else if (favoriteColorLowerCase.Equals("indigo"))
            {
                CarColor = "Ford";
            }
            else if (favoriteColorLowerCase.Equals("violet"))
            {
                CarColor = "Tesla";
            }
            else
            {
                CarColor = "beat-up scooter";
            }

        }
    }
}
