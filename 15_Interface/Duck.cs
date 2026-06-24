using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    internal class Duck : ISwim, IMove, IFly
    {
        // 1 - way - одна реалізація для всіх interface
        // public int Speed => 3;

        // 2 way - явна реалізація для кожного інтерфейсу
        int IMove.Speed => 3;
        int IFly.Speed => 10;

        public int Weight { get; set; }
        public void Move()
        {
            Console.WriteLine($"Duck with weight {Weight} can walk with speed {((IMove)this).Speed}");
        }

        virtual public void Fly()
        {
            Console.WriteLine($"Duck can fly with speed {((IFly)this).Speed}");
        }

        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }
    }
}
