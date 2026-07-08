using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task
{
    internal class Management
    {
        Dictionary<string, string> management = new Dictionary<string, string>()
        {
            ["opGmail.com"] = "OPgsayuc214",
            ["JHjaadGmail.com"] = "t35gsayuc214"
        };

        public void AddTomanagement()
        {
            Console.WriteLine("Enetr Login");
            string login = Console.ReadLine();
            Console.WriteLine("Enetr PAsword");
            string pasword = Console.ReadLine();
            if (management.ContainsKey(login))
                Console.WriteLine($"login --> {login} already exists");
            else
                management.Add(login, pasword);
        }

        public void RemoveLogin()
        {
            Console.WriteLine("Enetr Login for delete ");
            string login = Console.ReadLine();
            if (management.ContainsKey(login))
                management.Remove(login);
            else
                Console.WriteLine($"login --> {login} already exists");
        }
        public void ChangeInformation()
        {
            Console.WriteLine("Eneter (1) - change login and password\nEnter (2) - change password");
            int i = int.Parse(Console.ReadLine());
            switch(i)
            {
                case 1:
                    {
                        RemoveLogin();
                        AddTomanagement();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter login where you want to change the password");
                        string login = Console.ReadLine();
                        foreach (var item in management)
                        {
                            if (item.Key == login)
                            {
                                Console.WriteLine("Enter new pasword");
                                string password = Console.ReadLine();
                                /*item.Value = password;*/
                            }
                        }
                        break;
                    }

            }
            /*Console.WriteLine("Enter the login and password you want to change");
            Console.WriteLine("Enetr Login");
            //string login = Console.ReadLine();
            Console.WriteLine("Enetr PAsword");
            string pasword = Console.ReadLine();
            management.Remove(login);*/

            /*Console.WriteLine("Eneter new login and pasword");
            Console.WriteLine("Enetr Login");
            string log = Console.ReadLine();
            Console.WriteLine("Enetr PAsword");
            string pas = Console.ReadLine();
            management.Add(log, pas);*/
        }

        public void PrintInfo(string login)
        {
            foreach (var item in management.Keys)
            {
                if (management.ContainsKey(login))
                    Console.WriteLine($"{item,-10} {management[item]}");
                else
                    Console.WriteLine("The login does not exist");
            }
        }
        public void Print()
        {
            foreach (var item in management)
            {
                Console.WriteLine($"Login --> {item.Key,-10}Pasword --> {item.Value}");
            }
        }

    }
}
