using System;

namespace HabbitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to HabbitTracker");
                Console.WriteLine("Press 1 to log in to your account. If you are a new user, please press 2 and register.");
                string welcome = Console.ReadLine();
                int n = 0;
                bool welcomeChoice = int.TryParse(welcome, out n);
                if (welcomeChoice)
                {
                    if (n == 1)
                    {
                        Console.WriteLine("Enter your Username and Password and press Enter");
                    }
                    if (n == 2)
                    {
                        Console.WriteLine("");
                    }
                    
                }


             Console.ReadLine();
            }
            
        }
    }
}
