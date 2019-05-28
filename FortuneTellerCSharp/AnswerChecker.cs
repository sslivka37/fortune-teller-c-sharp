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

        public void checkRetirmentYears()
        {
             if (fortuneAsker.AgeNumber % 2 == 1)
            {
                retirementYears = 30;
            }
            else
            {
                retirementYears = 100;
            }
        }
    }
}
