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
        public void DrinkAddedM(string Mess)
        {
            Console.WriteLine($"Admin notified about --> {Mess}");
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
            Console.WriteLine($"\n_________Ingredients________");
            Console.WriteLine($"Water  --> {Machinee.Ingredients.Water}");
            Console.WriteLine($"Milk   --> {Machinee.Ingredients.Milk}");
            Console.WriteLine($"Coffee --> {Machinee.Ingredients.Coffee}");
            Console.WriteLine($"Ice    --> {Machinee.Ingredients.Ice}");
            Console.WriteLine($"Sugar  --> {Machinee.Ingredients.Sugar}\n");
        }
        public void TakeMoney()
        {
            Console.WriteLine($"\nmoney taken {Machinee.Money} UAH\n");
            Machinee.Money = 0;
        }
    }
}
