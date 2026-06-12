


using System.Text;

internal class Program
{
    static int sum(int a, int b) => a + b;
    static int sum(int a, int b, int c) => a + b + c;
    /*static int sum(int text,params int[] numb) => numb.Sum() / text;*/

    static int sum(int text, params int[] numb)
    {
        Console.WriteLine($"Sum     :: {numb.Sum()}");
        Console.WriteLine($"Min     :: {numb.Min()}");
        Console.WriteLine($"Max     :: {numb.Max()}");
        Console.WriteLine($"Average :: {numb.Average()}");
        return text;
    }
    private static void Main(string[] args)
    {
        // класи

        // string - тільки для читання
        // StringBuilder - System.Text.StringBuilder - працює швидше і для багато змін підходить краще, рядок можна змінювати
        /*string text = "lorem ipsum dolor C#";
        Console.WriteLine(text[0]);
        *//*text[0] = 'L'; *//*// string тільки для читання

        StringBuilder text2 = new StringBuilder(text);
        text2[0] = 'L';
        Console.WriteLine(text2[0]);*/

        string text = "lorem ipsum dolor C#";
        char[] chars = text.ToCharArray();
        chars[0] = Char.ToUpper(chars[0]);
        Console.WriteLine(text);
        Console.WriteLine(chars);

        text = new string(chars);
        Console.WriteLine(text);

        // Methods

        string word = "C#";
        Console.WriteLine($"Contains '{word}' :: {text.Contains(word)}"); // true false
        Console.WriteLine($"Indexof '{word}' :: {text.IndexOf(word)}"); // -1 not found 
        Console.WriteLine($"Startswich '{word}' :: {text.StartsWith(word)}"); // -1 not found
        Console.WriteLine($"Endswich '{word}' :: {text.EndsWith(word)}"); // -1 not found

        string letters = "ips";
        int index = text.IndexOfAny(letters.ToCharArray()); // -1 not found
        if(index != -1)
        {
            Console.WriteLine($" \n Index of first from '{letters}' :: {index}. letter :: {text[index]}");
        }

        string one = "Apple", two = "Apricot"; // one < two
        Console.WriteLine($"{one} == {two} --> {one == two}");
        Console.WriteLine($"{one} CompareTo({two}) --> {one.CompareTo(two)}"); // -1 if one < two, 0 if one == two, 1 one > two
        two = "apple";
        Console.WriteLine($"{one} CompareTo({two}) --> {string.CompareOrdinal(one, two)}"); // 1 ( a(97) > A(65)
        Console.WriteLine($"{one} CompareTo({two}) --> {string.Compare(one, two, true)}"); // ігнор регістру символів

        Console.WriteLine($"Origina Text :: {text}");
        Console.WriteLine($"tezt.Remove --> {text.Remove(5, 10)}");
        Console.WriteLine($"tezt.Remove --> {text.Replace("C#", "JavaScript")}"); // заміна текста
        Console.WriteLine($"tezt.Remove --> {text.Insert(0, "Next text")}"); // вставлення тексту в індех
        Console.WriteLine($"tezt.Remove --> {text.Substring(5, 10)}"); // від я кого символа до якого 


        string number = "1,2,3,4, 5,6,7,8,9";
        string[] numbers = number.Split(',', ' ', StringSplitOptions.TrimEntries);
        foreach (var @char in numbers)
        {
            Console.WriteLine(@char);
        }

        string[] color = { "red", "grean", "yellow" };
        Console.WriteLine(String.Join("---", color));

        Console.WriteLine(sum(1,2));
        Console.WriteLine(sum(1,2,3));
        Console.WriteLine(sum(100, 1,2,3,4,5,6, 100, 123));

        StringBuilder text2 = new StringBuilder();
        Console.WriteLine(text2);
        text2.Append("test test test");
        Console.WriteLine(text2);
        text2.Insert(0, "test");
        Console.WriteLine(text2);
        text2.Replace("test", "C#");
        Console.WriteLine(text2);
        text2.Remove(10, 5);
        Console.WriteLine(text2);


    }
}