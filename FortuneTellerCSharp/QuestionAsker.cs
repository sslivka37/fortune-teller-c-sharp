using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneTellerCSharp
{
    class QuestionAsker        
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AgeNumber { get; set; }
        public int BirthMonth { get; set; }
        public string FavoriteColor { get; set; }
        public int SiblingsNumber { get; set; }

        



        public void AskFirstName()
        {
            Console.WriteLine("Enter your first name:");        
        }

        public void AskLastName()
        {
            Console.WriteLine("Enter your last name:");
        }

        public void AskAge()
        {
            Console.WriteLine("Enter your age in years:");
        }

        public void AskBirthMonthNumber()
        {
            Console.WriteLine("Enter your birth month number:");
        }

        public void AskFavoriteColor()
        {
            Console.WriteLine("Enter your favorite ROYGBIV color:");
            Console.WriteLine("Type 'help' to list the ROYGBIV colors.");
        }

        public void AskNumberOfSiblings()
        {
            Console.WriteLine("Enter your number of siblings:");
        }
    }
}
