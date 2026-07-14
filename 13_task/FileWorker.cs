using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task
{
    internal class FileWorker
    {
        public static void SaveStudents(Student[] student, string filename)
        {
            using(BinaryWriter bw = new BinaryWriter(new FileStream(filename, FileMode.Create)))
            {
                bw.Write(student.Length);
                foreach (var item in student)
                {
                    bw.Write(item.Name);
                    bw.Write(item.SurName);
                    bw.Write(item.Specialty);
                    bw.Write(item.marks.Length);
                    foreach (var mark in item.marks)
                    {
                        bw.Write(mark);
                    }
                }
            }
        }

        public static Student[] LoadStudents(string filename)
        {
            using(BinaryReader br = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {

                int c = br.ReadInt32();

                Student[] student = new Student[c];

                for (int i = 0; i < c; i++)
                {
                    Student students = new Student();

                    students.Name = br.ReadString();
                    students.SurName = br.ReadString();
                    students.Specialty = br.ReadString();

                    int arrcount = br.ReadInt32();

                    students.marks = new int[arrcount];
                    for (int j = 0; j < arrcount; j++)
                    {
                        students.marks[j] = br.ReadInt32();

                    }
                    student[i] = students;
                }
             return student;
            }
        }
    }
}
