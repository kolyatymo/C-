/*class MyString : String
{
    
}*/

static class IntExtesion
{
    public static int ConstDigit(this int number)
    {
        return Math.Abs(number).ToString().Length;
    }
}

static class ArrayExtension
{
    public static int SumPositive(this int[] arr)
    {
        return Array.FindAll(arr, x => x > 0).Sum();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int value = 12341546;
        Console.WriteLine($"{value} has {value.ConstDigit()}");
        int[] arr = { 1, 2, 3, -4, -5, };
        Console.WriteLine(arr.SumPositive());
    }
}