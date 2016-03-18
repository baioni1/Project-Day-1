using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            do
            {
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();
                firstName = firstName.ToUpper();

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();
                lastName = lastName.ToUpper();

                string ageInput = "0";
                int age = 0;
                do
                {
                    Console.WriteLine("What is your age?");
                    ageInput = Console.ReadLine();
                }
                while (int.TryParse(ageInput, out age) == false);
                int ageRetire = FindRetireAge(age);

                string birthMonth;
                do
                {
                    Console.WriteLine("What month were you born in?");
                    birthMonth = Console.ReadLine();
                    birthMonth = birthMonth.ToUpper();
                }
                while (birthMonth.Length<3);
                              
                string moneyBack = FindSavings(birthMonth, firstName, lastName);

                string color;
                do
                {
                    Console.WriteLine("What is your favorite ROYGBIV color?\n If you are unsure what ROYBIV is, ask for \"Help\"");
                    color = Console.ReadLine();
                    if (color.ToUpper() == "HELP")
                        Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet");
                }
                while (color.ToUpper() == "HELP" || (color.ToUpper() != "RED" && color.ToUpper() != "ORANGE"
                       && color.ToUpper() != "YELLOW" && color.ToUpper() != "GREEN" && color.ToUpper() != "BLUE"
                       && color.ToUpper() != "INDIGO" && color.ToUpper() != "VIOLET") );

                string transportation = FindTransportation(color);

                string siblingInput = "0";
                int siblingNum = 0;
                do
                {
                    Console.WriteLine("How many siblings do you have?");
                    ageInput = Console.ReadLine();
                }
                while (int.TryParse(siblingInput, out siblingNum) == false);
                string location = FindLocation(siblingNum);

                Console.WriteLine($"{firstName} {lastName} will retire in {ageRetire} years, with {moneyBack} in the bank,\n" + $"a vacation home in { location} and a {transportation}.");

                Console.WriteLine("Would you like to try again? (Yes/No)");
                userAnswer = Console.ReadLine();

            }
            while (userAnswer.ToUpper() == "YES");
                 
        }

        static int FindRetireAge(int age)
        {
            if (age % 2 ==0)
            {
                return 5;
            }
            else
            {
                return 50;
            }
        }

        static string FindLocation(int siblingNum)
        {
            switch (siblingNum)
            {
                case 0:
                    return "Mexico! Muy Bien!";
                    break;
                case 1:
                    return "Italy! Chow, bambino!";
                    break;
                case 2:
                    return "DisneyLand! Dreams Really Do Come True!";
                    break;
                case 3:
                    return "South Dakota, sorry!";
                    break;
                default:
                    return "You aint going nowhere, too many siblings!";
                    break;
            }
        }

        static string FindTransportation(string userColor)
        {
            switch (userColor.ToUpper())
            {
                case "RED":
                    return "tugboat";
                    break;
                case "ORANGE":
                    return "kayak";
                    break;
                case "YELLOW":
                    return "sailboat";
                    break;
                case "GREEN":
                    return "unicycle";
                    break;
                case "BLUE":
                    return "tricycle";
                    break;
                case "INDIGO":
                    return "razor scooter";
                    break;
                case "VIOLET":
                    return "jet pack";
                    break;
                default:
                    return "ticket for the RTA";
                    break;
            }
        }

        static string FindSavings(string birthMonth,string firstName,string lastName)
        {
            if ( firstName.IndexOf(birthMonth[0]) >= 0 || lastName.IndexOf(birthMonth[0]) >= 0)
            {
                return "$100,000.00";
            }
            else if( firstName.IndexOf(birthMonth[1])>= 0 || lastName.IndexOf(birthMonth[1]) >= 0)
            {
                return "$200,000.00";
            }
            else if (firstName.IndexOf(birthMonth[2]) >= 0 || lastName.IndexOf(birthMonth[2]) >= 0)
            {
                return "$300,000.00";
            }
            else
            {
                return "$1,000,000.00";
            }
            
        }

    }
}
