using System;
using System.Collections.Generic;
using System.Text;

namespace HabbitTracker_DB_Services
{
    class Validation
    {
        public void ErrorMsg(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public bool ValidateString (string value, int range)
        {
            if (value.Length < range) return false;
            return true;
        }
        public int ValidatPositiveNumber(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                ErrorMsg("Please enter a number!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if (result < 1 || result > range)
            {
                ErrorMsg("The number that you entered is out of range, please enter a valid number!");
                Console.WriteLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
        public bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Would you like to try again? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "Y") return true;
                if (answer.ToLower() == "N") return false; 

            }
        }
    }
}
