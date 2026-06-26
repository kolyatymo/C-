using _17_practical;

internal class Program
{
    private static void Main(string[] args)
    {
        IOutput arr = new MyArray(new int[] { 1, 2, 3, 4, 5 });
        arr.Show();
        arr.Show("Hello");

        IMath arr2 = new MyArray(new int[] { 6, 7, 8, 9 });
        Console.WriteLine($"{arr2.Max()}");
        arr2.Max();
        
    }
}