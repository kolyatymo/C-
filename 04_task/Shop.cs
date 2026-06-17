using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task
{
    internal class Shop
    {
        private string nameShop;
        private uint address;
        private string discriptionsShop;
        private uint phone;
        private string email;

        public Shop() { }

        public string NameShop
        {
            get
            {
                return nameShop;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)) 
                    nameShop = value;
            }
        }

        public uint Address { get; set; }
        public string DiscriptionsShop
        {

        get 
            { 
                return discriptionsShop;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    discriptionsShop = value;
            }
        }
        public uint Phone { get; set; }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                    email = value;
            }
        }

        public void InputS()
        {
            Console.WriteLine("Enter name shop --> ");
            NameShop = Console.ReadLine();

            Console.WriteLine("Enter address shop --> ");
            Address = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter discription shop --> ");
            DiscriptionsShop = Console.ReadLine();

            Console.WriteLine("Enter phone shop --> ");
            Phone = uint.Parse(Console.ReadLine());

            Console.WriteLine("Enter email shop --> ");
            Email = Console.ReadLine();
        }

    }
}
