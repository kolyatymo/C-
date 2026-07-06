using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = "Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек. А це весела птиця-синиця, Яка часто краде пшеницю, Яка в темній комірці зберігається У будинку, Який побудував Джек;";
        string[] Text = text.Split(' ', ',', '.', ';');

        Dictionary<string, int> words = new Dictionary<string, int>();

        int TotalWords = 0;

        for (int i = 0; i < Text.Length; i++)
        {
            TotalWords++;
        }

        foreach (var w in Text)
        {
            string n = w.ToLower();
            if (words.ContainsKey(n))
            {
                words[n]++;
            }
            else
            {
                words.Add(n, 1);
            }
        }
        Console.OutputEncoding = Encoding.UTF8;

        int a = 1;
        foreach (var item in words)
        {
            Console.WriteLine($"{a, -20}Count --> {item.Value,-20} word --> {item.Key}");
            a++;
        }
        Console.WriteLine($"total words --> {TotalWords, -5} unique words --> {words.Count, -10}");  
    }
}