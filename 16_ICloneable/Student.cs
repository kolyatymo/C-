using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ICloneable
{
    internal class Student : ICloneable
    {
        public string Name { get; set; }

        private int[] marks;

        public Student(string name = "Noname", int numMarks = 5)
        {
            Name = name;
            marks = new int [numMarks];
        }

        public Student(string name = "Noname", params int[] marks) // Student("Olia", 11,10,11,12)   params - після string збирає всі параметри і вносить їх в масив
        {
            Name = name;
            this.marks = (int[])marks.Clone();
        }

        public int this[int index]
        {
            get => marks[index];
            set => marks[index] = value >= 0 && value <= 12 ? value : throw new ArgumentOutOfRangeException($"Bad value for mark {value}");
        }

        public override string ToString()
        {
            return $"Name :: {Name, -15} Marks : {String.Join(",",marks)}";
        }

        public object Clone()
        {
            //return new Student(this); - якщо є конструктор копіювання 
            return new Student(Name, marks);
        }
    }
}
