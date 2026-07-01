using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task
{
    abstract class Shape : IColored, ILocated, IPrintable, IMovable
    {
        public ConsoleColor color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public abstract int Area();

        public virtual void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract int Perimeter();
        public abstract void Print();
    }
}
