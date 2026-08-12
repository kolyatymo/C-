using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class Espresso : HotDrink, ICoffee
    {
        public int CoffeePercent { get; set; }
        public int MilkPercent { get; set; }

        public Espresso() {
            Name = "Espresso";
            Price = 45;
            CoffeePercent = 100;
            MilkPercent = 0;
        }
        public override void Info()
        {
            Console.WriteLine($"espresso is being prepared");
        }
    }
}
