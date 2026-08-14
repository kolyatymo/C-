using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    public class Cart
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_______Cart______");
            Console.ResetColor();

            foreach (var item in HotDrinks)
            {
                Console.WriteLine($"{item.Name} {item.Price} UAH");
            }

            Console.WriteLine($"Total UAH = {MOney()} UAH");
        }
    }
}
