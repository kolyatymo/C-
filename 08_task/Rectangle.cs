using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task
{
    internal class Rectanglee : Shape
    {
        public int wight {  get; set; }
        public int height { get; set; }

        public ConsoleColor color { get; set; }

        public override int Area()
        {
            return wight * height;
        }

        public override int Perimeter()
        {
            return 2 * (wight + height);
        }



        public override void Print()
        {
            Console.WriteLine("Enter symbol");
            string s = Console.ReadLine();
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
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


