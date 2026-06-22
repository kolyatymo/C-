using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class TV : Device
    {
        public int Diagonal { get; set; } = 42;
        public override bool HasBattery => false;

        public TV(string brand = "Nobrand", int year = 2020, int diagonal = 42)
            :base(brand, year)
        {
            /*this.Year = year;
            this.Brand = brand;*/
            Diagonal = diagonal;
        }
        // not virtual
        public void PrintModel()
        {
            Console.WriteLine($"{this.GetType().Name} {brand} can show tv-channels");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Diagonal : {Diagonal}";
        }
    }
}
