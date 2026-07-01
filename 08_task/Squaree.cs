using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task
{
    internal class Squaree : Shape
    {
        public int wight { get; set; }

        public ConsoleColor color { get; set; }

        public override int Area()
        {
            return wight * wight;
        }

        public override int Perimeter()
        {
            return 4 * wight;
        }



        public override void Print()
        {
            Console.WriteLine("Enter symbol");
            string s = Console.ReadLine();
            Console.ForegroundColor = color;
            for (int i = 0; i < wight; i++)
            {
                for (int j = 0; j < wight; j++)
                {
                    Console.SetCursorPosition(X + j, Y + i);
                    Console.Write(s);
                }
            }
            Console.ResetColor();
        }
    }
}
