internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "info.txt";
        /*using(StreamWriter sw = new StreamWriter(fname))
        {
            string line = "Hello from C# Streams";
            int value = 123456;
            DateTime today = DateTime.Now;
            int[] arr = { 10, 20, 30, 40, 50 };

            sw.WriteLine(line);
            sw.WriteLine($"Value :: {value}");
            sw.WriteLine(today);
            sw.WriteLine(arr.Length);
            foreach (var item in arr)
            {
                sw.WriteLine(item);
            }
        }*/

        // 1 way
        Console.WriteLine($"Content RaedAllText :: {File.ReadAllText(fname)}"); // прочитати все в string
        // 2 way
        Console.WriteLine($"Content File.ReadAlllines \n"); // читає в масив
        var lines = File.ReadAllLines(fname);
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"#{i + 1} ::::: {lines[i]}");
        }
        Console.WriteLine();

        // 3 way
        using(StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"\n\nContent (ReadToEnd) :: {sr.ReadToEnd()}"); 
        }
        
        // 4 way
        using(StreamReader sr = new StreamReader(fname))
        {
            Console.WriteLine($"\n\nContent (line by line)");
            string line;
            //!sr.EndOfStream
            while((line = sr.ReadLine()) != null)
            {
                //line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("End read");
        
        // 5 way
        using(StreamReader sr = new StreamReader(fname)) // читання по символах
        {
            Console.WriteLine($"\n\nContent (char by char)");

            int symbol;

            while ((symbol = sr.Read()) != -1)
            {
                Console.WriteLine((char)symbol);
            }
        }

        
    }
}