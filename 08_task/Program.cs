
using _08_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectanglee rects = new Rectanglee();
        rects.Move(3, 3);
        rects.wight = 4;
        rects.height = 7;
        rects.color = ConsoleColor.Green;
        rects.Print();
        Console.WriteLine();
        

        Squaree squaree = new Squaree();
        squaree.Move(6, 3);
        squaree.wight = 4;
        squaree.color = ConsoleColor.Red;
        squaree.Print();
        Console.WriteLine();

        Linee line = new Linee();
        line.Length = 3;
        line.Move(8, 8);
        line.color = ConsoleColor.Blue;
        line.Print();
        Console.WriteLine();
        Console.WriteLine();

        Trianglee tri = new Trianglee();
        tri.Heigth = 5;
        tri.Move(9, 9);
        tri.color = ConsoleColor.Yellow;
        tri.Print();



    }
}