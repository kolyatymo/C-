using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_practical
{
    enum Namedistricts { Colodenka = 1, Mizoch, VelukiMus}
    internal class City
    {
        private string namecity = "NonameCity";
        private string namecountry = "Nonamecountry";
        private uint numbpeople = 0;
        private uint phonecity = 0;
        private Namedistricts districts;

        public City()
        {
            
        }
        public string Namecountry
        {
            get
            {
                return namecountry;
            }
            set
            {
                
                if (!String.IsNullOrWhiteSpace(value))
                    namecountry = value;
            }
        }

        public string Namecity
        {
            get
            {
                return namecity;
            }
            set
            {

                if (!String.IsNullOrWhiteSpace(value))
                    namecity = value;
            }
        }

        public void SetNumbPeople(uint value)
        {
            numbpeople = value;
        }

        public uint GetNumbPeople()
        {
            return numbpeople;
        }
        
        public void setPhonecity(uint value)
        {
            phonecity = value;
        }
        public void SetDistrict(Namedistricts value)
        {
            districts = value;
        }
        public Namedistricts GetDistrict()
        {
            return districts;
        }
       
        public void Input()
        {
            Console.WriteLine("Enter Name city --> ");
            Namecity = Console.ReadLine();
            
            Console.WriteLine("Enter Name country --> ");
            Namecountry = Console.ReadLine();
            
            Console.WriteLine("Enter number people --> ");
            numbpeople = uint.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Phone City --> ");
            phonecity = uint.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter name distrincts; 1 - Colodenka, 2 - Mizoch, 3 - VelukiMus --> ");
            districts = (Namedistricts)int.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("--------- City --------");
            Console.WriteLine($"Name city    --> {namecity}");
            Console.WriteLine($"Name country --> {namecountry}");
            Console.WriteLine($"Population   --> {numbpeople}");
            Console.WriteLine($"Phone city   --> {phonecity}");
            Console.WriteLine($"District     --> {districts}");
        }

    }
}
