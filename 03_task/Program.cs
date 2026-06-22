internal class Program
{
    static void Print<T>(T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],-5}");
            }
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {

        // task 1

        const int ROW = 5, COL = 5;

        Random rand = new Random();

        int[,] arr = new int[ROW, COL];
       

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                arr[i,j] = rand.Next(-100, 100);
            }
        }

        int min = arr[0,0];
        int max = arr[0,0];
        int minI = 0;
        int minJ = 0;
        int maxI = 0;
        int maxJ = 0;

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    minI = i;
                    minJ = j;
                }
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    maxI = i;
                    maxJ = j;
                }

            }
        }

        int sum = 0;

        for (int i = minI; i < maxI; i++)
        {
            for (int j = minJ; j < maxJ; j++)
            {
                sum += arr[i,j];
            }
        }

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                Console.Write(arr[i,j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine(sum);

        // task 2

        /*Console.WriteLine("Enter text");
        string str = Console.ReadLine();
        char[] char_ = str.ToCharArray();

        Console.WriteLine("Enter landslide");
        uint n = uint.Parse(Console.ReadLine());

        for (int i = 0; i < char_.Length; i++)
        {
            if (char_[i] >= 'a' && char_[i] <= 'z')
            {
                char_[i] = (char)(char_[i] + n);
                if (char_[i] > 'z')
                    char_[i] = (char)(char_[i] - 26);
            }
            if (char_[i] >= 'A' && char_[i] <= 'Z')
            {
                char_[i] = (char)(char_[i] + n);
                if (char_[i] > 'Z')
                    char_[i] = (char)(char_[i] - 26);
            }

        }

        Console.WriteLine(char_);

        Console.WriteLine("decoding?\n(1) - yes;\n(2) - no;");
        uint a = uint.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                for (int i = 0; i < char_.Length; i++)
                {
                    if (char_[i] >= 'a' && char_[i] <= 'z')
                    {
                        char_[i] = (char)(char_[i] - n);
                        if (char_[i] < 'a')
                            char_[i] = (char)(char_[i] + 26);
                    }
                    if (char_[i] >= 'A' && char_[i] <= 'Z')
                    {
                        char_[i] = (char)(char_[i] - n);
                        if (char_[i] < 'A')
                            char_[i] = (char)(char_[i] + 26);
                    }
                    
                }
                Console.WriteLine(char_);
                break;
            case 2:
                Console.WriteLine(char_);
                break;
        }  */


        // task 3

        /*const int ROW = 5, COL = 5;

        Random rand = new Random();

        int[,] arr2 = new int[ROW, COL];
        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                arr2[i, j] = rand.Next(1, 10);
            }
        }


        int[,] arr = new int[ROW, COL];
        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COL; j++)
            {
                arr[i, j] = rand.Next(1, 10);
            }
        }
        Console.WriteLine("---- arr (1) ----");
        Print(arr);
        Console.WriteLine();
        Console.WriteLine("---- arr (2) ----");
        Print(arr2);
        Console.WriteLine();

        Console.WriteLine("(matrix)\n(1) - Multiplying a matrix by a number;\n(2) - Adding matrices;\n(3) - Product of matrices;");
        uint a = uint.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Enter the number to multiply");
                int n = int.Parse(Console.ReadLine());


                for (int i = 0; i < ROW; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        arr[i, j] = arr[i, j] * n;
                    }
                }
                Print(arr);
                break;
            case 2:
                for (int i = 0; i < ROW; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        arr[i, j] = arr[i, j] + arr2[i, j];
                    }
                }

                Print(arr);
                break;
            case 3:
                for (int i = 0; i < ROW; i++)
                {
                    for (int j = 0; j < COL; j++)
                    {
                        arr[i, j] = arr[i, j] * arr2[i, j];
                    }
                }
                Print(arr);
                break;
        }*/


        // task 4

        /*Console.WriteLine("write the expression");
        string expr = Console.ReadLine();

        char[] chars = expr.ToCharArray();

        char q = ' ';
        int p = -1;

        for (int i = 0; i < expr.Length; i++)
        {
            if (chars[i] == '+' || chars[i] == '-')
            {
                q = chars[i];
                p = i;
            }
        }
        int a = Convert.ToInt32(expr.Substring(0, p));
        int b = Convert.ToInt32(expr.Substring(p + 1));

        int result = 0;

        switch (q)
        {
            case '+': result = a + b;
                Console.WriteLine("res -->  " + result);
                break;
            case '-': result = a - b;
                Console.WriteLine("res -->  " + result);
                break;
        }*/


        // task 5

        /*Console.WriteLine("Enter Text");
        string a = Console.ReadLine();

        char[] arr = a.ToCharArray();

        arr[0] = char.ToUpper(arr[0]);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '.' || arr[i] == '!')
                arr[i + 2] = char.ToUpper(arr[i + 2]);
        }
        Console.WriteLine(arr);*/


        // task 6


        /*string a = @"To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; die and by a sleep to heir say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, heir to sleep";


        string[] bad = { "die", "heir" };

        foreach (var item in bad)
        {
            a = a.Replace(item, "***");
        }
        Console.WriteLine(a);*/

    }
}




/*Дано двовимірний масив розмірністю 5×5, заповнений випадковими
числами з діапазону від -100 до 100. Визначити суму елементів масиву,
розташованих між мінімальним і максимальним елементами.*/