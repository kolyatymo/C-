using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_task
{
    class Rectangle : Shape
    {
        public Rectangle(Position point, int height, int length) 
            :base(point)
        { 
            this.height = height;
            this.length = length;
        }

        private int height = 0;
        private int length = 0;

        public override int Area()
        {
            return height * length;
        }

        public override int Length()
        {
            return 2*(height +  length);
        }
        public override void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.SetCursorPosition(basePoint.X + j, basePoint.Y + i);
                    Console.Write("*");
                }
            }
        }
    }
}
