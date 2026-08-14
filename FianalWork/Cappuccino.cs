using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class Cappuccino : HotDrink, ICoffee
    {
        public int CoffeePercent { get; set; }
        public int MilkPercent { get; set; }

        public Cappuccino()
        {
            Name = "2 --> Cappuccino";
            Price = 70;
            CoffeePercent = 40;
            MilkPercent = 60;
        }
        public override void Info()
        {
            Console.WriteLine($"Cappuccino is being prepared");
        }
    }
}
