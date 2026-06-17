using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task
{
    internal class Reservoir
    {
        private uint volume;
        private string materials;
        private string state;

        public Reservoir() { }
        public Reservoir(uint volume = 0) :this(volume, "stone", "empty")
        {
            this.volume = volume;
        }
        public Reservoir(uint volume = 0, string materials = "ston") :this(volume,materials, "empty")
        {
            this.volume = volume;
            this.materials = materials;
        }
        public Reservoir(uint volume = 0, string materials = "ston", string state = "empty")
        {
            this.volume = volume;
            this.materials = materials;
            this.state = state;
        }



        public void FillRes()
        {
            if (this.volume <= 80)
            {
                this.volume += 20;
                Console.WriteLine($"Reservoir --> ({this.volume} %)");
            }
            else
            {
                this.volume = 100;
                this.state = "full";
                Console.WriteLine($"Reservoir is {this.state}  ({this.volume} %)");
            }
        }

        public void Devastation()
        {
            if (this.volume >= 20)
            {
                this.volume -= 20;
                Console.WriteLine($"Reservoir --> ({this.volume} %)");
            }
            else
            {
                this.volume = 0;
                this.state = "empty";
                Console.WriteLine($"Reservoir is {this.state} ({this.volume} %) ");
            }
        }

        public void PrintR()
        {
            Console.WriteLine($"Reservoir volume    --> {this.volume}");
            Console.WriteLine($"Reservoir materials --> {this.materials}");
            Console.WriteLine($"Reservoir state     --> {this.state}");
        }
    }

}
