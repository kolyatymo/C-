using _09_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Comp comp = new Comp(5,2);

        comp.AddDisk(0, new DVD());
        comp.AddDisk(1, new DVD());
        comp.AddDisk(2, new CD());
        comp.AddDisk(3, new Flash());
        comp.AddDisk(4, new HDD());

        Console.WriteLine($" HDD --> {comp.CheckDisk("HDD")}");

        comp.ShowDisk();

    }
}