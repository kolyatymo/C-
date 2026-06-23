using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_task
{
    internal class Account
    {
        string gmail;
        string password;

        public string Gmail
        {
            get => gmail;
            set
            {

                if (string.IsNullOrEmpty(value) || value.Length < 4 || value.Length > 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("must be between 4 and 50 characters");
                }
                if (!value.Contains("@"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("the address must contain (@)");
                }
                if (value.Any(c => !(char.IsLetterOrDigit(c) || c == '_' || c == '@')))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("Invalid Gmail address");
                }

                gmail = value;
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("must be not null");
                }
                if (value.Length < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("at least 6 characters");
                }
                if (!value.Any(c => char.IsLetter(c)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("must contain letters");
                }
                if (!value.Any(value => char.IsDigit(value)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentException("must contain numbers");
                }
                password = value;
            }
        }

        public void Input()
        {
            while (true)
            {
                try 
                {
                    Console.WriteLine("Enter gmail ");
                    Gmail = Console.ReadLine();
                    break;

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Try again");
                    Console.ResetColor();
                }

            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter password ");
                    Password = Console.ReadLine();
                    break;

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Try again");
                    Console.ResetColor();
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"gmail    --> {Gmail};");
            Console.WriteLine($"Password --> {Password};");
            Console.ResetColor();
        }
    }
}
