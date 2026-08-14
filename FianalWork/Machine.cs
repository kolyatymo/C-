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

            Ingredients.Water = 200;
            Ingredients.Coffee = 20;
            Ingredients.Milk = 200;
            Ingredients.Sugar = 200;
            Ingredients.Ice = 200;

            HotDrinks = new List<HotDrink>
            {
                new Coffee(),
                new Cappuccino(),
                new Espresso(),
                new GreanTea(),
                new BlackTea()
            };
            Money = 0;
        }
    }
}
