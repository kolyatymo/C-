internal class Program
{
    static void SumTwo(int a, int b, out int res)
    {
        res = a + b;
    }
    private static void Main(string[] args)
    {
        int first = 5;
        int second = 10;
        Console.WriteLine("Bad swap");
        Console.WriteLine($" before first :: {first} \t second :: {second}");
        BadSwap(first, second);
        Console.WriteLine($" after   swap :: {first} \t second :: {second}");

        Console.WriteLine("Swap");
        Console.WriteLine($" before first :: {first} \t second :: {second}");
        Swap(ref first,ref second);
        Console.WriteLine($" after   swap :: {first} \t second :: {second}");

        int res;
        Console.WriteLine("Test out params");
        SumTwo(first, second, out res);
        Console.WriteLine($"Result :: {res}");
    }

    // ref, out - передача аргументів за посиланням
    // ref - переданий фактичний параметр ПОВИНЕН БУТИ ПРОІНІЦІАЛІЗОВАНИЙ
    // out - переданий фактичний параметр може БУТИ не ПРОІНІЦІАЛІЗОВАНИЙ використовується для збереження результату

    static void Swap(ref int a, ref int b)
    {
        var tmp = a;
        a = b;
        b = tmp;
    }
    static void BadSwap(int a, int b)
    {
        var tmp = a;
        a = b;
        b = tmp;
    }

}