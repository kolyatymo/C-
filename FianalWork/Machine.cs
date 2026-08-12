using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    public class Machine
    {
        public Ingredients Ingredients { get; set; }

        public List<HotDrink> HotDrinks { get; set; }

        public double Money { get; set; } 

        public Machine()
        {
            Ingredients = new Ingredients();

            HotDrinks = new List<HotDrink>
            {
                new Espresso(),
                new Cappuccino(),
                new Coffee(),
                new GreanTea(),
                new BlackTea()
            };
            Money = 0;
        }
    }
}
