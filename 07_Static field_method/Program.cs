using _07_Static_field_method;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Main started");
        Console.WriteLine($"Last ID {Emploee.LasdId}");
        Emploee emp1 = new Emploee() { Name = "Pavlo", Birth = new DateTime(2000,10,21), Position = Position.QA };
        Console.WriteLine(emp1);

        Emploee emp2 = new Emploee()
        {
            Name = "Alex",
            Birth = new DateTime(2001, 9, 16),
            Position = Position.QA
        };

        Console.WriteLine(emp2);

        Console.WriteLine($"Same position :: {Emploee.SomePosition(emp1, emp2)}");
        Console.WriteLine(emp1.ID);

    }
}