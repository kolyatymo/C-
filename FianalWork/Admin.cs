using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FianalWork
{
    internal class Admin
    {
        public Machine Machinee { get; set; }

        public Admin(Machine machinee)
        {
            Machinee = machinee;
        }
        public void AddWater(int water)
        {
            Machinee.Ingredients.Water += water;
        }
        public void AddMilk(int Milk)
        {
            Machinee.Ingredients.Milk += Milk;
        }
        public void AddSugar(int Sugar)
        {
            Machinee.Ingredients.Sugar += Sugar;
        }
        public void AddCoffee(int coffee)
        {
            Machinee.Ingredients.Coffee += coffee;
        }
        public void AddIce(int ice)
        {
            Machinee.Ingredients.Ice += ice;
        }
        public void Show()
        {
            Console.WriteLine("_________Ingredients________");
            Console.WriteLine($"Water  --> {Machinee.Ingredients.Water}");
            Console.WriteLine($"Milk   --> {Machinee.Ingredients.Milk}");
            Console.WriteLine($"Coffee --> {Machinee.Ingredients.Coffee}");
            Console.WriteLine($"Ice    --> {Machinee.Ingredients.Ice}");
            Console.WriteLine($"Sugar  --> {Machinee.Ingredients.Sugar}");
        }
        public void TakeMoney()
        {
            Console.WriteLine($"money taken {Machinee.Money} UAH");
            Machinee.Money = 0;
        }
    }
}
