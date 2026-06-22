using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_task
{
    internal class Square : Shape
    {
        private int side = 0;

        public Square(Position point, int side)
            : base(point)
        {
            this.side = side;
        }
        public override int Area()
        {
            return side * side;
        }
        
        public override int Length()
        {
            return 4 * side;
        }

        public override void Draw()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.SetCursorPosition(basePoint.X + j, basePoint.Y + i);
                    Console.Write("*");
                }
            }
        }
    }
}
