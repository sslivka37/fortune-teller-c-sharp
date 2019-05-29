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

        public void CheckBankBalance()
        {
            switch (_fortuneAsker.BirthMonth)
            {
                case 1:
                    BankBalance = 100;
                    break;

                case 2:
                    BankBalance = 100;
                    break;

                case 3:
                    BankBalance = 100;
                    break;

                case 4:
                    BankBalance = 100;
                    break;

                case 5:
                    BankBalance = 1337;
                    break;

                case 6:
                    BankBalance = 1337;
                    break;

                case 7:
                    BankBalance = 1337;
                    break;

                case 8:
                    BankBalance = 1337;
                    break;
                case 9:
                    BankBalance = 1000000;
                    break;

                case 10:
                    BankBalance = 1000000;
                    break;

                case 11:
                    BankBalance = 1000000;
                    break;
                case 12:
                    BankBalance = 1000000;
                    break;

                default:
                    BankBalance = 0;
                    break;
            }

        }

        //vacation spot based on number of siblings

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

        public void CheckCarColor()
            {
            if (_fortuneAsker.FavoriteColor.Equals("red", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Mustang";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("orange", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Mercedes";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("yellow", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Subaru";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("green", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Honda";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("blue", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Toyota";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("indigo", StringComparison.InvariantCultureIgnoreCase))
            {
                CarColor = "Ford";
            }
            else if (_fortuneAsker.FavoriteColor.Equals("violet", StringComparison.InvariantCultureIgnoreCase))
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
