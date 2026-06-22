using _05_task;
internal class Program
{
    private static void Main(string[] args)
    {
        Vector v1 = new Vector(3, 4);
        Vector v2 = new Vector(1, 2);

        Console.WriteLine("v1('_') ");
        Console.WriteLine(v1);

        Console.WriteLine("v2; ");
        Console.WriteLine(v2);

        Vector sum = v1 + v2;
        Console.WriteLine("\nSum v1 + v2 = ");
        Console.WriteLine(sum);

        Vector sumM = v1 - v2;
        Console.WriteLine("\nSumMinus v1 - v2 = ");
        Console.WriteLine(sumM);

        Double sumMulti = v1 * v2;
        Console.Write("\nSumMultiplication v1 * v2 = ");
        Console.WriteLine(sumMulti);

        Vector sumMulti3 = v1 * 3;
        Console.WriteLine("\nSumMultiplication v1 * 3 = ");
        Console.WriteLine(sumMulti3);



    }
}
