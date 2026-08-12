using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    public abstract class HotDrink
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual void Info()
        {
            Console.WriteLine($"{Name} {Price} UAH");
        }
    }
}
