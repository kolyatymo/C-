internal class Program
{
    static void PrintArray(int[] arr)
    {
        foreach (var item in arr) 
        {
            Console.Write($"{item,5}");
        }
        Console.WriteLine();
    }

    static void PrintArray(int[,] arr)
    {
        /*for (int i = 0; i < arr.GetLength(0); i++)
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

        int[] arr = new int[] { 1, 2, 3, 6, 3, 5, 6, 7, 2, 4, 6, 7, 2 };
        PrintArray(arr);

        // task 1

        var odd = Array.FindAll(arr, e => e % 2 != 0).Length; 
        Console.WriteLine("odd  --> " + odd);

        var even = Array.FindAll(arr, (int e) => {return e % 2 == 0;}).Length;
        Console.WriteLine("even --> " + even);

        int uniaue = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < uniaue; j++)
            {
                if (arr[i] == arr[j])
                {
                    found = true;
                    break;
                }

            }

            if(found == false)
                uniaue++;
        }


        Console.WriteLine("unique elements --> " + uniaue);*/


        // task 2

        /*Console.WriteLine("Enter number");
        int numb = int.Parse(Console.ReadLine());
        var eve = Array.FindAll(arr, (int e) => { return e < numb;});
        Console.WriteLine($"all numbers that are less than ({numb}) ");
        Console.WriteLine(string.Join(", ", eve));*/

        // task 3

        /*int count = 0;
        Console.WriteLine("Enter numbers");
        int numb = int.Parse(Console.ReadLine());
        if(numb >= 100 && numb <= 999)
        {
            int a = numb / 100;
            int b = (numb / 10) % 10;
            int c = numb % 10;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == a && arr[i + 1] == b && arr[i+2] == c)
                    count++;
            }
        }
        else
        {
            Console.WriteLine("must be 3 numbers");
        }
        Console.WriteLine("number of repetitions --> " + count);*/

        // task 4

        /*int[] arr2 = new int[3] { 1, 2, 3 };
        int[] arr3 = new int[3] { 2, 4, 5 };
        int[] arr4 = new int[arr2.Length + arr3.Length];
        int n = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < n; j++)
            {
                if (arr4[j] == arr2[i])
                {
                    found = true;
                    break;
                }

                    
            }
            if (found == false)
            {
                arr4[n] = arr2[i];
                n++;
            }
        }
        
        for (int i = 0; i < arr3.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < n; j++)
            {
                if (arr4[j] == arr3[i])
                {
                    found = true;
                    break;
                }

                    
            }
            if (found == false)
            {
                arr4[n] = arr3[i];
                n++;
            }
        }

        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            res[i] = arr4[i];
        }

        PrintArray(res);*/

        // task 5

/*        int[,] arr5 = new int[3, 4]
        {
            { 4, 2, 3, 4},
            {5,6,7,8 },
            {7,8,9,10}
        };

        PrintArray(arr5);

        int min = arr5[0,0];
        int max = arr5[0,0];

        for (int i = 0; i < arr5.GetLength(0); i++)
        {
            for (int j = 0; j < arr5.GetLength(1); j++)
            {
                if (arr5[i, j] < min)
                    min = arr5[i,j];
                if (arr5[i, j] > max)
                    max = arr5[i,j];
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);*/


    }
}