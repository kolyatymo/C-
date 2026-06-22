using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class SmartTV : TV
    {
        //new string brand; 
        public SmartTV(string brand = "NoBrand", int year = 2020, int diagonal = 42)
            :base(brand, year, diagonal) {}
        new public void PrintModel() // new - перекриває метод базового типу
        {
            base.PrintModel();
            Console.WriteLine($"Smart TV {Brand} can surf in internet");
        }
    }
}
