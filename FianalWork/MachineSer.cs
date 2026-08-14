using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class MachineSer
    {
        public Ingredients Ingredients { get; set; }

        public double Money { get; set; }

        public MachineSer() { }

        public MachineSer(Machine machine)
        {
            Ingredients = machine.Ingredients;
            Money = machine.Money;
        }
    }
}
