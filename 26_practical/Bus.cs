using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_practical
{
    internal class Bus : Car
    {
        public override string Name { get; set; }
        public override int speed { get; set; }

        public override int weight { get; set; }
        public override void Go()
        {
            race += speed;

            if (race >= MaxRace)
                GetFinish();
        }

        public Bus(string name, int speed, int weight)
        {
            this.speed = speed;
            this.weight = weight;
            this.Name = name;
        }

        public void GetStart(string desc)
        {
            Start($"car --> {Name} {desc}");
        }
    }
}
