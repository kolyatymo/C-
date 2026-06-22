using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_task
{
    abstract class Shape
    {
        protected Position basePoint;

        public ConsoleColor Color { get; set; }
        public Shape()
        {
            basePoint = new Position();
            Color = ConsoleColor.Blue;
        }
        public Shape(Position basePoint, ConsoleColor color)
        {
            this.basePoint = basePoint;
            Color = color;
        }

        public Shape(Position basePoint) 
        {
           this.basePoint = basePoint;
        }

        public abstract int Area();
        public abstract int Length();

        public virtual void Print()
        {
            Console.WriteLine($"shape   --> {this.GetType().Name};\nArea    --> {Area()};\nLength  --> {Length()}");
        }

        public abstract void Draw();


    }
}
