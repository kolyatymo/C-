using _29_practical;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(20);
        list.Add(40);

        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        list.Insert(2, 999);
        Console.WriteLine("Insert - 2, 999 --> ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        list.Remove(20);
        Console.WriteLine("Remove - 20 --> ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        list.RemoveAt(1);
        Console.WriteLine("RemoveAt(1) --> ");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int found = list.Find(x => x > 25);
        Console.WriteLine($"\nFind (x > 25) --> {found}");

        var all = list.FindAll(x => x % 2 == 0);
        Console.WriteLine("\nFindAll even --> ");
        foreach (var item in all)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        Console.WriteLine($"Count --> {list.Count}");

        list.Clear();
        Console.WriteLine($"Clear - Count --> {list.Count}");
    }
}