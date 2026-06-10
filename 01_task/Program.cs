using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {

        // task 1 ----------------


        /*string position = "Teacher";
        string position2 = "joiner";
        string name = "Oleg";
        int hours = 10;
        int tarif = 0;

        switch (position)
        {
            case "Teacher":
                tarif = 10;
                break;

            case "joiner":
                tarif = 100;
                break;

            case "Director":
                tarif = 200;
                break;
        }


        int salary = tarif * hours;

        Console.WriteLine($"Name     --> {name}");
        Console.WriteLine($"position --> {position}");
        Console.WriteLine($"hours    --> {hours}");
        Console.WriteLine($"tariff   --> {tarif} $/hour");
        Console.WriteLine($"salary   --> {salary} $\n");

        int tarif2 = 0;

        switch (position2)
        {
            case "Teacher":
                tarif2 = 10;
                break;

            case "joiner":
                tarif2 = 100;
                break;

            case "Director":
                tarif2 = 200;
                break;
        }

        int salary2 = tarif2 * hours;

        Console.WriteLine($"position --> {position2}");
        Console.WriteLine($"hours    --> {hours}");
        Console.WriteLine($"tariff   --> {tarif2} $/hour");
        Console.WriteLine($"salary   --> {salary2} $");*/




        // task 2 ----------------


        /*Console.WriteLine("hwllo world");
        int a, b;
        Console.WriteLine("Enter first numb --> ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second numb --> ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }*/


        // task 3 ----------------

        /*int n = 867;
        int rev = 0;

        while (n > 0)
        {
            int number = n % 10;
            rev = rev * 10 + number;
            n /= 10;
        }

        Console.WriteLine(rev);*/


        // number two

        /*int one = n % 10;
        int two = n % 100 / 10;
        int three = n / 100;
        Console.WriteLine($"{one}{two}{three}");*/



        // task 4 ----------------

        /*int d = 0;
        int l = 0;
        int s = 0;
        int p = 0;
        do
        {
            Console.WriteLine("Enter symbol");
            char res = char.Parse(Console.ReadLine());
            *//*if(Console.WriteLine(char.IsLetter(res))*//*

            if (char.IsDigit(res))
                d++;
            if (char.IsLetter(res))
                l++;
            if (char.IsSymbol(res))
                s++;
            if (res == ' ')
                p++;

            if (res == '.')
            {
                Console.WriteLine($"Letter --> {l}\nDigit --> {d}\nSymbol --> {s}\nSpace --> {p}");
                break;
            }
        }*/


        // task 5 ----------------

        /*while (true)
        {
            Console.WriteLine("Enter symbol");
            char res = char.Parse(Console.ReadLine());
            if (char.IsLower(res))
            {
                Console.WriteLine(char.ToUpper(res));
            }
            else
                Console.WriteLine(char.ToLower(res));
        }*/


    }
}


