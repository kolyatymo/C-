using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_practical
{
    internal abstract class Car
    {
        protected int race = 0;

        protected const int MaxRace = 100;
        public abstract string Name { get; set; }

        public bool IsFinish { get; set; }
        public abstract int speed { get; set; }

        public abstract int weight { get; set; }

        public abstract void Go();

        public void Finish(string desc)
        {
            Console.WriteLine($"{Name}: {desc}");
        }

        public void Start(string desc)
        {
            Console.WriteLine($"{Name}: {desc}");
        }
        public void Position(string desc)
        {
            Console.WriteLine($"{Name}: {desc}");
        }

        public void GetFinish()
        {
            if (race >= MaxRace)
            {
                IsFinish = true;
                Finish("Finish");
            }
        }
    }
}
