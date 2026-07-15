using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // numbers

        /*string pattern = @"\d";
        var reg = new Regex(pattern);
        bool flag = true;
        while (flag)
        {
            string str = Console.ReadKey().KeyChar.ToString();
            if(str == " ")
                flag = false;

            bool success = reg.IsMatch(str);
            Console.WriteLine(success ? $" --> match found {pattern}" : $" --> match not found {pattern}");
        }*/

        var array = new[] { "test", "123", "test123test", "123test", "test123", "123test123" };
        //string pattern = @"\d"; // одна цифра
        //string pattern = @"\d+"; // одна і більше
        //string pattern = @"\d*"; // 0 і більше
        //string pattern = @"\d?"; // 0 або 1
        //string pattern = @"^\d"; // початок з цифри
        //string pattern = @"^\d+$"; // лише цифри не менше 1
        //string pattern = @"^\d{3}$"; // рядок з 3 цифр
        //string pattern = @"\d{3}"; // рядок шукає 3 цифри
        //string pattern = @"^\d{3}"; // рядок починається 3 цифр
        //string pattern = @"\d{1,2}"; // рядок шукає 1 або 2 цифри
        //string pattern = @"\d{1,2}\w"; // 
        //string pattern = @"\d{1,2}t"; // шукає 1 чи 2 цифри а після них буква t
        //string pattern = @"\d{1,2}[abcdefg]"; // шукає 1 чи 2 цифри а після них [шукатиме одну із цих символів] 
        //string pattern = @"\d{1,2}[a-z]"; // шукає 1 чи 2 цифри а після них [шукатиме від a до z] 
        //string pattern = @"\d{1,2}[A-Za-z0-9*?/.]"; // шукає 1 чи 2 цифри а після них [шукатиме від A до Z від a - z так далі] 
        //string pattern = @"\d{1,2}[^A-Za-z0-9*?/.]"; // шукає 1 чи 2 цифри а після них [ ^ шукатиме всі символи крім записаних] 
        //string pattern = @"\d{1,2}[A-Za-z0-9]{5,}$"; // шукає 1 чи 2 цифри а після них [5 букв] 
        /*string pattern = @"\d{1,2}[A-Za-z0-9]{5}"; // шукає 1 чи 2 цифри а після них [5 букв] 

        var regex = new Regex(pattern,RegexOptions.IgnoreCase);
        foreach (var element in array)
        {
            *//*Console.WriteLine(
                regex.IsMatch(element)
                ? $"String '{element}' matched '{pattern}'"
                : $"String '{element}' NOT matched '{pattern}'"
                );
            Console.WriteLine(new string('-',50));*//*


            Match match = Regex.Match(element, pattern);
            while(match.Success) // показує тільки ті що підходять
            {
                Console.WriteLine($"{element, -20} '{pattern, -10}' {regex.IsMatch(element), -5} --> {match.Value}");
                match = match.NextMatch();
            }

        }*/

        /*Match m = Regex.Match("123 Axx-1xxy \n Axyx-2-xyyxy", @"A.*y"); // . все крім перенесення на новий рядок
        while(m.Success)
        {
            Console.WriteLine($"Value :: {m.Value}");
            Console.WriteLine($"Lengt :: {m.Length}");
            Console.WriteLine($"Index :: {m.Index}");
            Console.WriteLine(new string('-', 50));

            m = m.NextMatch();
        }*/


        /*string str = "saidsaid said see spread super said";
        var matches = Regex.Matches(str, @"s\w+d");
        Console.WriteLine(str);
        Console.WriteLine();
        foreach (Match match1 in matches)
        {
            Console.WriteLine($"match --> {match1.Value, -15} index --> {match1.Index, -5} length --> {match1.Length, -5}");
        }*/

        /*var str = "Dont replace Dot Net replaced Net Net dots";
        string output = Regex.Replace(str, @"N.t", "NET"); // 1 - рядок 2 - патерн 3 - на що замінити
        Console.WriteLine(str);
        Console.WriteLine(output);*/

        string text = "test test 458796589 args args 512556374 test test 345675684 test";
        // +38(045)-12-45-458
        //var output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})", "+38(0$1)-$2-$3-$4");
        var output = Regex.Replace(text, @"\d{9}", (m) => String.Format("0:+38(0##)-##-##-###", Convert.ToInt64(m.Value)));
        Console.WriteLine(text);
        Console.WriteLine(output);

    }
}