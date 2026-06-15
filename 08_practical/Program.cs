using _08_practical;

internal class Program
{
    private static void Main(string[] args)
    {
        City city = new City();
        /*city.Namecity = "Rivne";
        city.Namecountry = "Ukraine";*/
        city.Input();
        city.Print();
    }
}