using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_task
{
    internal class Vector
    {
        private double x;
        private double y;

        public Vector(double x)
        {
            this.x = x;
        }
        public Vector(double x, double y) :this(x)
        {
            this.y = y;
        }

        public override string ToString()
        {
            return $"x --> {x};\ny --> {y}";
        }

        public double Get(Vector a, Vector b)
        {
            return (a.x + b.x + a.y * b.y);
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y);
        }

        public static Vector operator *(Vector a, double num)
        {
            return new Vector(a.x * num, a.y * num);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y;
        }

        public override bool Equals(object? obj)
        {
            Vector other = obj as Vector;
            if (other == null)
                return false;
            if(this.x == other.x && this.y == other.y)
                return true;
            return false;
        }
        public static bool operator ==(Vector x, Vector y)
        {
            if (ReferenceEquals(x, y)) 
                return true;
            if (x is null || y is null)
                return false;
            return x.Equals(y);
        }

        public static bool operator !=(Vector x, Vector y)
        {
                return !(x == y);
        }

        public static explicit operator double(Vector a)
        {
            return a.x * a.x + a.y * a.y;
        }

        public static Vector operator ++(Vector a)
        {
            Vector fr = new Vector(1, 1);
            return a + fr;
        }

        public static Vector operator --(Vector a)
        {
            Vector fr = new Vector(1, 1);
            return a - fr;
        }

        public static bool operator true(Vector x)
        {
            return x.x != 0 || x.y != 0;
        }
        public static bool operator false(Vector x)
        {
            return x.x == 0 && x.y == 0;
        }

        public static Vector operator -(Vector a)
        {
            return new Vector(-a.x, -a.y);
        }

        public double this[int index]
        {
            get
            { 
                if(index == 0)
                    return x;
                if(index == 1)
                    return y;
                return -1;
            }
        }

    }
}
