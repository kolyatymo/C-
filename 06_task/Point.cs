using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06_task
{
    class Point : Shape
    {
        public Point(Position point, ConsoleColor color)
            : base(point, color) { }
        public override int Area()
        {
            return 0;
        }

        public override int Length()
        {
            return 0;
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(basePoint.X, basePoint.Y);
            Console.WriteLine(".");
            
        }
    }
}
