using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class Coffee : HotDrink, ICoffee
    {
        public int CoffeePercent { get; set; }
        public int MilkPercent { get; set; }

        public Coffee()
        {
            Name = "1 --> Coffee";
            Price = 35;
            CoffeePercent = 50;
            MilkPercent = 50;
        }
        public override void Info()
        {
            Console.WriteLine($"Coffee is being prepared");
        }
    }
}
