using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class GreanTea : HotDrink, ITea
    {
        public string TypeTea { get; set; }
        public int WaterPercent { get; set; }
        public GreanTea()
        {
            Name = "Grean Tea";
            Price = 20;
            WaterPercent = 80;
            TypeTea = "Grean";
        }

        public override void Info()
        {
            Console.WriteLine($"Grean Tea is being prepared");
        }
    }
}
