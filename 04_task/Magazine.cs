using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04_task
{
    internal class Magazine
    {
        private string nameMagazine;
        private uint yearFoundation;
        private string descriptionMagazine;
        private uint phone;
        private string email;

        public Magazine() { }
        public string NameMagazine
        {
            get
            {
                return nameMagazine;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)) 
                    nameMagazine = value;
            }
        }
        public uint YearFoundation { get; set; }

        public string DescriptionMagazine
        {
            get
            {
                return descriptionMagazine;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    descriptionMagazine = value;
            }
        }
        public uint PhoneFoundation { get; set; }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                    email = value;
            }
        }

        public void InputM()
        {
            Console.WriteLine("Enter Name Magazine --> ");
            NameMagazine = Console.ReadLine();

            Console.WriteLine("Enter Year Foundation --> ");
            YearFoundation = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter Description Magazine --> ");
            DescriptionMagazine = Console.ReadLine();

            Console.WriteLine("Enter Phone --> ");
            PhoneFoundation = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email --> ");
            Email = Console.ReadLine();


        }

        public void PrintM()
        {
            Console.WriteLine($"Name magazine        --> {NameMagazine}");
            Console.WriteLine($"Year foundation      --> {YearFoundation}");
            Console.WriteLine($"Description magazine --> {DescriptionMagazine}");
            Console.WriteLine($"Phone                --> {PhoneFoundation}");
            Console.WriteLine($"Email                --> {Email}");
        }
    }
}
