
// static class; 1 - може вмістити лише статичні поля та методи; 2 - не може створити екземпляр
static class AreaShapes
{
    const double PI = 3.14; // const - є неявно статичний
    public static double TrianArea(double heigth, double side) => heigth * side / 2;
    public static double CircleArea(double radius) => PI * Math.Pow(radius,2); 

}
internal class Program
{
    private static void Main(string[] args)
    {
        /* AreaShapes test = new AreaShapes(*/
        Console.WriteLine($"Trial area :: {AreaShapes.TrianArea(10,20)}");
    }
}