using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
enum Draw { DrawTriangle, DrawSquare }

namespace _10_task
{
    internal class DelegateTask
    {
        Action<uint, ConsoleColor, char> act;
        int X { get; set; }
        int Y { get; set; }
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public  void DrawSqure(uint height, ConsoleColor color, char s)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.SetCursorPosition(X + j, Y + i);
                    Console.Write(s);
                }
            }
            Console.ResetColor();
        }
        public void DrawTriangle(uint height, ConsoleColor color, char s)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(X, Y + i);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s);
                }
            }
            Console.ResetColor();
        }

        public void SetDraw(Draw dr)
        {
            if (dr == Draw.DrawTriangle)
                this.act = DrawTriangle;
            if(dr == Draw.DrawSquare)
                this.act = DrawSqure;
        }
        public void AddDraw(Draw dr)
        {
            if (dr == Draw.DrawSquare)
                act += DrawSqure;
            else if (dr == Draw.DrawTriangle)
                act += DrawTriangle;
        }

        public void Print(uint height, ConsoleColor color, char s)
        {
            act?.Invoke(height, color, s);
        }


    }
}
