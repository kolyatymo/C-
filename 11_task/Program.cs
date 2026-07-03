using _11_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Hothouse house = new Hothouse(40, Weather.summer);

        Heater heater = new Heater();
        Cooler cooler = new Cooler();

        house.TooHot += cooler.Cool;
        house.TooCold += heater.Warm;

        house.Info();
        Console.WriteLine();

        house.CheckTemp();

        Console.WriteLine();

        house.Temperatures = 10;

        house.Info();
        Console.WriteLine();

        house.CheckTemp();

        house.Temperatures = 25;

        house.Info();
        Console.WriteLine();

        house.CheckTemp();

    }
}