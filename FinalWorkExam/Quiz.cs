using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalWorkExam
{
    internal class Quiz
    {
        public string Title { get; set; }
        public int QuestionCount => Questions?.Count ?? 0;
        public List<Question> Questions { get; set; } = new List<Question>();

        public Quiz()
        {
            Questions = new List<Question>(QuestionCount);
        }
        public void menu()
        {
            Console.WriteLine($"write");
        }
    }
}
