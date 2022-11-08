using System;

namespace HarshaBank.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Harsha Bank*******");
            Console.WriteLine("Login Page");

            // declare variables for username and password
            string username = null, password = null;
            Console.Write("Username: ");
            username = Console.ReadLine();

            // ask for and read password only if a username has been entered
            if (username != "")
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            // check username and password
            if (username == "system" && password == "manager")
            {
                //declare variable to store menu choice
                int mainMenuChoice = -1;

                do
                {
                    //show main menu
                    System.Console.WriteLine("\n:::Main menu:::");
                    System.Console.WriteLine("1. Customers");
                    System.Console.WriteLine("2. Accounts");
                    System.Console.WriteLine("3. Funds Transfer");
                    System.Console.WriteLine("4. Funds Transfer Statement");
                    System.Console.WriteLine("5. Account Statement");
                    System.Console.WriteLine("0. Exit");

                    //accept menu choice from keyboard
                    System.Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(System.Console.ReadLine());

                    //switch-case to check menu choice
                    switch (mainMenuChoice)
                    {
                        case 1: //TO DO: Display customers menu
                            break;
                        case 2: //TO DO: Display accounts menu
                            break;
                        case 3: //TO DO: Display funds transfer menu
                            break;
                        case 4: //TO DO: Display funds transfer statement menu
                            break;
                        case 5: //TO DO: Display account statement menu
                            break;
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                System.Console.WriteLine("Invalid username or password");
            }
            Console.WriteLine("Thank you! Visit again.");
        }
    }
}