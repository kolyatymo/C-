using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

// TODO: 
// - use enums
// - Rename: started - start method, class Start to ...
// create account class with CUrrentUser, Register, Login etc...

namespace FinalWorkExam
{
    internal class Start
    {
        public static string CurrentUser { get; set; }

        string fname = "Exam.txt";

        
        public void Started()
        {
            Console.WriteLine($"1 --> Registration\n2 --> Login\n3 --> change password or date");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Registration();
                    break;
                case 2:
                    Login();
                    break;
                case 3:
                    Console.WriteLine($"1 --> change password\n2 --> change date");
                    int n = int.Parse(Console.ReadLine());
                    switch(n)
                    {
                        case 1:
                            ChangePassword();
                            break;
                        case 2:
                            ChangeDate();
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!!Error!!!");
                    Console.ResetColor();
                    break;
            }
        }
        public void Registration()
        {
            Console.Write("Enter Email --> ");
            string email = Console.ReadLine();

            string patternEmail = @"^[A-Za-z0-9._-]{4,}@[A-Za-z0-9]{2,}\.[A-Za-z]{2,}$";

            var regex = new Regex(patternEmail);

            Match match = regex.Match(email);
            if (!match.Success)
            {
                Console.WriteLine($"Email --> {email} bad");
                return;
            }
            Console.WriteLine("Email is correct");

            if (File.Exists("Exam.txt"))
            {
                foreach (string line in File.ReadAllLines("Exam.txt"))
                {
                    string[] text = line.Split('^');

                    if (text[0] == email)
                    {
                        Console.WriteLine($"This email already {email} exists");
                        return;
                    }
                }
            }

            Console.WriteLine($"Email --> {email} is good");

            Console.Write("Enter date of birth --> ");
            string birthDate = Console.ReadLine();

            Console.Write("Enter password --> ");
            string password = Console.ReadLine();

            Match match2 = regex.Match(password);

            bool success = Regex.IsMatch(password, @".{6,}") && Regex.IsMatch(password, @"[A-Z]+") && Regex.IsMatch(password, @"[a-z]+") && Regex.IsMatch(password, @"[0-9]+") && Regex.IsMatch(password, @"[_-]+") && Regex.IsMatch(password, @"[A-Z]+") && Regex.IsMatch(password, @"^[A-Za-z0-9_-]+$");

            if (success)
            {
                Console.WriteLine($"password --> {password}");
                File.AppendAllText(fname, $"{email}^{password}^{birthDate}\n");
            }
            else
            {
                Console.WriteLine($"password {password} is bad");
            }
        }

        public void Login()
        {
            Console.Write("Enter Email --> ");
            string email = Console.ReadLine();

            string savedPassword = "";

            if (File.Exists("Exam.txt"))
            {
                foreach (string line in File.ReadAllLines("Exam.txt"))
                {
                    string[] data = line.Split('^');

                    if (data[0] == email)
                    {
                        savedPassword = data[1];
                        break;
                    }
                }
            }

            if (savedPassword == "")
            {
                Console.WriteLine($"this address {email} douse not exist");
                return;
            }

            Console.Write("Enter password --> ");
            string password = Console.ReadLine();

            if (File.Exists("Exam.txt"))
            {

                if (savedPassword != password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect password");
                    Console.ResetColor();
                    Console.WriteLine("create a new password ???");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n1 --> Yes");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n2 --> No");
                    Console.ResetColor();
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.Write("Enter password --> ");
                            string passwordd = Console.ReadLine();

                            bool success = Regex.IsMatch(passwordd, @".{6,}") && Regex.IsMatch(passwordd, @"[A-Z]+") && Regex.IsMatch(passwordd, @"[a-z]+") && Regex.IsMatch(passwordd, @"[0-9]+") && Regex.IsMatch(passwordd, @"[_-]+") && Regex.IsMatch(passwordd, @"[A-Z]+") && Regex.IsMatch(passwordd, @"^[A-Za-z0-9_-]+$");
                            if (success)
                            {
                                Console.WriteLine($"password --> {passwordd}");
                                File.AppendAllText(fname, $"{email}^{passwordd}^\n");
                            }
                            else
                            {
                                Console.WriteLine($"password {passwordd} is bad");
                            }
                            break;

                        case 2:
                            Console.WriteLine("You need to register");
                            Registration();
                            break;

                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login successful");
                    Console.ResetColor();

                    CurrentUser = email;
                }

            }

        }
        public void ChangePassword()
        {
            Console.Write("Enter Email --> ");
            string email = Console.ReadLine();

            string savedPassword = "";

            if (File.Exists("Exam.txt"))
            {
                foreach (string line in File.ReadAllLines("Exam.txt"))
                {
                    string[] data = line.Split('^');

                    if (data[0] == email)
                    {
                        savedPassword = data[1];
                        break;
                    }
                }
            }

            if (savedPassword == "")
            {
                Console.WriteLine($"this address {email} douse not exist");
                return;
            }

            Console.Write("Enter password --> ");
            string password = Console.ReadLine();

            if (File.Exists("Exam.txt"))
            {

                if (savedPassword != password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect password");
                    Console.ResetColor();
                    Console.WriteLine("create a new password ???");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n1 --> Yes");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n2 --> No");
                    Console.ResetColor();
                    int i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.Write("Enter password --> ");
                            string passwordd = Console.ReadLine();

                            bool success = Regex.IsMatch(passwordd, @".{6,}") && Regex.IsMatch(passwordd, @"[A-Z]+") && Regex.IsMatch(passwordd, @"[a-z]+") && Regex.IsMatch(passwordd, @"[0-9]+") && Regex.IsMatch(passwordd, @"[_-]+") && Regex.IsMatch(passwordd, @"[A-Z]+") && Regex.IsMatch(passwordd, @"^[A-Za-z0-9_-]+$");
                            if (success)
                            {
                                Console.WriteLine($"password --> {passwordd}");
                                File.AppendAllText(fname, $"{email}^{passwordd}^\n");
                            }
                            else
                            {
                                Console.WriteLine($"password {passwordd} is bad");
                            }
                            break;

                        case 2:
                            Console.WriteLine("You need to register");
                            Registration();
                            break;

                    }

                }
                else
                {
                    Console.Write("Enter new password --> ");
                    string passwordnew = Console.ReadLine();
                    bool success = Regex.IsMatch(passwordnew, @".{6,}") && Regex.IsMatch(passwordnew, @"[A-Z]+") && Regex.IsMatch(passwordnew, @"[a-z]+") && Regex.IsMatch(passwordnew, @"[0-9]+") && Regex.IsMatch(passwordnew, @"[_-]+") && Regex.IsMatch(passwordnew, @"[A-Z]+") && Regex.IsMatch(passwordnew, @"^[A-Za-z0-9_-]+$");
                    if (success)
                    {
                        Console.WriteLine($"password --> {passwordnew}");
                        string[] lines = File.ReadAllLines(fname);

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string[] data = lines[i].Split('^');

                            if (data[0] == email)
                            {
                                data[1] = passwordnew;
                                lines[i] = string.Join("^", data);
                                break;
                            }
                        }

                        File.WriteAllLines(fname, lines);
                    }
                    else
                    {
                        Console.WriteLine($"password {passwordnew} is bad");
                    }
                }

            }
        }

        public void ChangeDate()
        {
            Console.Write("Enter Email --> ");
            string email = Console.ReadLine();

            string savedPassword = "";

            if (File.Exists("Exam.txt"))
            {
                foreach (string line in File.ReadAllLines("Exam.txt"))
                {
                    string[] data = line.Split('^');

                    if (data[0] == email)
                    {
                        savedPassword = data[1];
                        break;
                    }
                }
            }

            if (savedPassword == "")
            {
                Console.WriteLine($"this address {email} douse not exist");
                return;
            }

            Console.Write("Enter password --> ");
            string password = Console.ReadLine();

            if (File.Exists("Exam.txt"))
            {

                if (savedPassword == password)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have logged in to your account");
                    Console.ResetColor();
                    Console.Write("Enter new date of birth --> ");
                    string birthDate = Console.ReadLine();

                    string[] lines = File.ReadAllLines(fname);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split('^');

                        if (data[0] == email)
                        {
                            data[2] = birthDate;
                            lines[i] = string.Join("^", data);
                            break;
                        }
                    }

                    File.WriteAllLines(fname, lines);
                }
                
            }
        }
    }
}

