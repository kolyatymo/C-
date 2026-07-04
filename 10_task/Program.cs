using _10_task;

internal class Program
{
    private static void Main(string[] args)
    {
        DelegateTask task = new DelegateTask();

        task.Move(5, 5);

        task.SetDraw(Draw.DrawSquare);
        task.Print(5, ConsoleColor.Green, '#');

        task.Move(5, 12);

        task.SetDraw(Draw.DrawTriangle);

        /*task.AddDraw(Draw.DrawTriangle);m
        task.AddDraw(Draw.DrawSquare);*/

        task.Print(6, ConsoleColor.Red, '*');

    }
}