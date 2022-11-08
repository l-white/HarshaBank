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
            if (username == "system" && password=="manager")
            {
                Console.WriteLine("TO DO: Main menu here");
            }
            Console.WriteLine("Thank you! Visit again.");
        }
    }
}