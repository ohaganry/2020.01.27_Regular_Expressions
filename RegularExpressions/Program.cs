using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"^[A-Z]\w{1,29} [A-Z']+\w{1,29}$";
            string emailPattern = @"^([\w\.\-]{5,30})@([(\w\-){5,30}]{5,30})((\.(\w){2,3}))$";
            string phonePattern = @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$";
            string datePattern = @"^(?:[012]?[0-9]|3[01])[./-](?:0?[1-9]|1[0-2])[./-](?:[0-9]{2}){1,2}$";

            Console.WriteLine("Welcome to my Regular Expressions Demo!");
            while(!ValidateInput("Please give me your first and last name", namePattern))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please use proper format <John Smith>");
                Console.ResetColor();
            }
            Console.WriteLine("Thank you\n");
            
            while(!ValidateInput("Please give me your email", emailPattern))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please use proper format <abcd123@xmail.com>");
                Console.ResetColor();
            }
            Console.WriteLine("Thank you\n");

            while(!ValidateInput("Please give me your phone number <xxx-xxx-xxxx>", phonePattern))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please use proper format <xxx-xxx-xxxx>");
                Console.ResetColor();
            }
            Console.WriteLine("Thank you\n");

            while(!ValidateInput("Please give me your birthday <dd/MM/yyyy>", datePattern))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please use proper format <dd/MM/yyyy>");
                Console.ResetColor();
            }
            Console.WriteLine("Thank you\n");

            
        }

        public static bool ValidateInput(string message, string pattern)
        {
            string userInput = GetUserInput(message);
            return Regex.IsMatch(userInput, pattern);
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
