using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_practical
{
    internal class Worker
    {
        string surname;
        string name;
        string patronymic;
        int age;
        int price;
        static int monthPrice = 300;
        DateTime date;

        public string Surname
        {
            get => surname;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Name must be not null or writespace");
                if (!value.All(c => char.IsLetter(c)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Exception ex = new Exception("Bad name :: must be all letters");
                    throw ex;
                }
                surname = value;
                Console.ResetColor();

            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name must be not null or writespace");
                if (!value.All(c => char.IsLetter(c)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Exception ex = new Exception("Bad name :: must be all letters");
                    throw ex;
                }
                name = value;
                Console.ResetColor();

            }
        }

        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name must be not null or writespace");
                if (!value.All(c => char.IsLetter(c)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Exception ex = new Exception("Bad name :: must be all letters");
                    throw ex;
                }
                patronymic = value;
                Console.ResetColor();

            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Age must be more than 18");
                }
                if (value >= 120)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Age must be under 120");
                }

                age = value;
                Console.ResetColor();

            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value <= monthPrice)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception($"Price must be more than {monthPrice}");
                }
                price = value;
                Console.ResetColor();

            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                if (value > DateTime.Now)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Date must be less than now");
                }
                date = value;
                Console.ResetColor();
            }
        }

        public int Experince
        {
            get { return DateTime.Now.Year - Date.Year; }
        }

        public void Input()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Input worker surname :: ");
                    Surname = Console.ReadLine();
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
                    Console.WriteLine("Input worker name :: ");
                    Name = Console.ReadLine();
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
                    Console.WriteLine("Input worker patronymic :: ");
                    Patronymic = Console.ReadLine();
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
                    Console.WriteLine("Input worker age :: ");
                    Age = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Input worker price :: ");
                    Price = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("Input worker date :: ");
                    Date = DateTime.Parse(Console.ReadLine());
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
            Console.WriteLine($"Experience --> {Experince}");
            
        }
    }
}
