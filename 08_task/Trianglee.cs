using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task
{
    internal class Trianglee : Shape
    {
        public int A {  get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public int Heigth { get; set; }

        public override int Area()
        {
            return (A * Heigth) / 2;
        }

        public override int Perimeter()
        {
            return A + B + C;
        }

        public override void Print()
        {
            Console.WriteLine("Enter symbol");
            string s = Console.ReadLine();
            Console.ForegroundColor = color;
            for (int i = 0; i < Heigth; i++)
            {
                Console.SetCursorPosition(X, Y + i);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s);
                }
            }
            Console.ResetColor();

        }

    }
}
