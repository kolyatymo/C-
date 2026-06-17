using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task
{
    internal class Website
    {
        private string nameSite;
        private string description;
        private string pathSite;
        private uint ipAddress;
        public Website() { }

        public string NameSite
        {
            get
            {
                return nameSite;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nameSite = value;
            }

        }

        public string PathSite
        {
            get
            {
                return pathSite;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                    pathSite = value;
            }
        }

        public string Description
        {
            get 
            { 
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

        public uint IPAddress { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter Name site --> ");
            NameSite = Console.ReadLine();

            Console.WriteLine("Enter path site --> ");
            PathSite = Console.ReadLine();

            Console.WriteLine("description site --> ");
            Description = Console.ReadLine();

            Console.WriteLine("Enter ip site --> ");
            IPAddress = uint.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Name site --> {NameSite}");
            Console.WriteLine($"Path site --> {PathSite}");
            Console.WriteLine($"desc site --> {Description}");
            Console.WriteLine($"Ip   site --> {IPAddress}");
        }
    }
}
