using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Static_field_method
{
    // static, const, readonly - лише читання
    enum Position { None, Manager = 1, Developer, QA, Economist, Director}
    internal class Emploee
    {
        public string Name { get; set; } = "Noname";
        public DateTime Birth { get; set; }
        public Position Position { get; set; }

        private static int lastId;
        public readonly int ID = ++lastId;

        public static int LasdId { get => lastId; }
        public static bool SomePosition(Emploee emp1, Emploee emp2) => emp1.Position == emp2.Position;

        public override string ToString() => $"ID : {ID} Name : {Name,-10}, Position : {Position,-5}; Birth : {Birth.ToShortDateString(), -20} Age : {Age}";

        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
        
        static Emploee() {
            Console.WriteLine("\t\t static ctor");
            lastId = new Random().Next(1, 10) * 1000;
        }
    }
}
