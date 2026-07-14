using _13_task;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        
        /*Student student = new Student();
        student.Name = "Test";
        student.SurName = "Test";
        student.Specialty = "Test";
        student.marks = new int[] { 12, 10, 12 };*/


        Student[] students = {
                new Student
                {
                    Name = "Iv",
                    SurName = "ppa",
                    Specialty = "C#",
                    marks = new int[] { 12, 11, 10 }
                },
                new Student
                {
                    Name = "An",
                    SurName = "Kl",
                    Specialty = "Soft",
                    marks = new int[] { 10, 9, 12 }
                }
            };

        FileWorker.SaveStudents(students, "stu.txt");

        Student[] loaded = FileWorker.LoadStudents("stu.txt");

        foreach (Student s in loaded)
        {
            Console.WriteLine($"{s.Name} {s.SurName} {s.Specialty}");
            Console.WriteLine("Marks --> " + string.Join("\t", s.marks));
        }
    }
}
