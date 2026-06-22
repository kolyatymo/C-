using _06_task;


internal class Program
{
    private static void Main(string[] args)
    {

        Point p = new Point(new Position(5, 5),ConsoleColor.Yellow);

        Rectangle rect = new Rectangle(new Position(10, 3),4,8);

        Square square = new Square(new Position(25, 5),6);

        p.Print();
        p.Draw();

        Console.WriteLine();
        Console.WriteLine();

        rect.Print();
        rect.Draw();

        Console.WriteLine();
        Console.WriteLine();
        square.Print();
        square.Draw();

    }
}

