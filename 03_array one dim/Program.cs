internal class Program
{
    static void Print<T>(T[] arr, string prompt = "")
    {
        /*Console.Write(prompt + " :: ");*/
        /*for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i],5}");
        }
        Console.WriteLine();*/

        Console.Write(prompt + (prompt.Length == 0 ? "" : " :: "));
        foreach (var item in arr) // лише для читання
        {
            Console.Write($"{item,5}");
        }
        Console.WriteLine();
    }

    static void Fill(int[] arr, int min = 0, int max = 100) // ref type, масив приходить за посиланням 
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack(ref int[] arr, int value)
    {
        // number 1

        /*int[] tmp = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            tmp[i] = arr[i];
        }
        tmp[tmp.Length - 1] = value;
        arr = tmp;*/

        // number 2

        /*int[] tmp = new int[arr.Length + 1];
        
        arr.CopyTo(tmp, 0);
        tmp[tmp.Length - 1] = value;
        arr = tmp;*/

        // number 3

        Array.Resize(ref arr, arr.Length + 1);
        arr[arr.Length - 1] = value;
    }

    private static void Main(string[] args)
    {
        // class Array - абстрактний клас, від якого успадковується масив
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr2 = { 10, 20, 30, 40 };
        Print(arr,  "Print Array ");
        Print(arr2, "Print Array2");

        /*Console.Write("Enter size of array :: ");
        int size = int.Parse(Console.ReadLine());*/
        int size = 10;
        int arr4;
        int[] arr3 = new int[size];
        Fill(arr3, -5, 5);
        Print(arr3, "Print Array 3 ");

        PushBack(ref arr3, 333);
        Print(arr3, "Print Array 3 ");

        Console.WriteLine("Input value for search :: ");
        int value = int.Parse(Console.ReadLine());
        int index = Array.IndexOf(arr3, value);
        if(index != -1)
        {
            Console.WriteLine($"Value {value} was found in index {index}");
            int LastIndex = Array.LastIndexOf(arr3, value);
            Console.WriteLine($"Value {value} was found in index {LastIndex}");
        }
        else
        {
            Console.WriteLine($"Value {value}, not found");
        }

        // бібліотека Linq - методи розширення роботи з масивами
        Console.WriteLine();
        value = 3;
        if(arr.Contains(value)) // перевірка наявності true false
        {
            Console.WriteLine($"Value {value} was found");
        }
        else
        {
            Console.WriteLine($"Value {value} was not found");
        }

        Console.WriteLine();
        int indexPositive = Array.FindIndex(arr3, IsPositive);
        if (indexPositive != -1)
        {
            Console.WriteLine($"Found positive {arr3[indexPositive]}");
        }
        
        Console.WriteLine();
        Console.WriteLine($" number of positive elements :: {arr3.Count(IsPositive)}");

        Console.WriteLine();
        var positives = Array.FindAll(arr3, IsPositive);
        Print(positives, "Print all positive elements");

        Console.WriteLine(Array.TrueForAll(arr3, IsPositive));

        var even = Array.FindAll(arr3, (int e) => {
            e += 2;// ......
            return e % 2 == 0; }); // lambda
        Print(even, " Even elements");

        var odd = Array.FindAll(arr3, e => e % 2 != 0); // для легкої функції
        Print(odd, " odd elements");

        Console.WriteLine();
        Console.WriteLine();

        Array.Sort(arr3);
        Print(arr3, "Print sort array");

        Array.Reverse(arr3);
        Print(arr3, "Print reverse");

        string[] colors = { "red ", "grean ", "yellow ", "gold ", "Pink ", "aqua " };
        Print(colors, "Print Colors");
        Array.Sort(colors);
        Print(colors, "Print Colors sort");

        Array.Sort(colors, (s1, s2) => s1.Length.CompareTo(s2.Length)); // сорт по кількості символів 
        Print(colors, "Print Colors sort");




    }
    static bool IsPositive(int a)// предикат логічна функція
    {
        return a > 0;
    }
}