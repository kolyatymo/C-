using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class Cart
    {
        public List<HotDrink> HotDrinks = new List<HotDrink>();

        public void AddDrink(HotDrink drink)
        {
            HotDrinks.Add(drink);
        }

        public double MOney()
        {
            return HotDrinks.Sum(drink => drink.Price);
        }

        public void ShowCart()
        {
            Console.WriteLine("_______Cart______");

            foreach (var item in HotDrinks)
            {
                Console.WriteLine($"{item.Name} {item.Price} UAH");
            }

            Console.WriteLine($"Total UAH = {MOney()} UAH");
        }
    }
}
