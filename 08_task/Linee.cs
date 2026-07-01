using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task
{
    internal class Linee : Shape
    {
        public int Length { get; set; }

        public override int Area()
        {
            return 0;
        }

        public override int Perimeter()
        {
            return Length;
        }

        public override void Print()
        {
            Console.WriteLine("Enter symbol");
            string s = Console.ReadLine();
            Console.ForegroundColor = color;

            Console.SetCursorPosition(X, Y);

            for (int i = 0; i < Length; i++)
                Console.Write(s);

            Console.ResetColor();
        }
    }
}
