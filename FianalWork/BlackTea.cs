using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class BlackTea : HotDrink, ITea
    {
        public string TypeTea { get; set; }
        public int WaterPercent { get; set; }
        public BlackTea()
        {
            Name = "5 --> Black Tea";
            Price = 20;
            WaterPercent = 80;
            TypeTea = "Black";
        }
        public override void Info()
        {
            Console.WriteLine($"Black Tea is being prepared");
        }
    }
}
