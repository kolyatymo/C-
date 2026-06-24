using _15_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck duck = new Duck() { Weight = 4 };

        Console.WriteLine("\n------------------ Duck as IMove ----------------");
        Console.WriteLine($"Duck weight : {duck.Weight}");
        duck.Move();
        duck.Fly();
        duck.Swim();
        /*Console.WriteLine($"Speed : {((IMove)duck).Speed}");*/
        Console.WriteLine("\n------------------ Duck as IMove ----------------");
        IMove im = duck;
        im.Move();
        Console.WriteLine($"Speed : {im.Speed}");

        Console.WriteLine("\n------------------ Duck as IFly ----------------");
        IFly ifl = duck;
        ifl.Fly();
        Console.WriteLine($"Speed : {ifl.Speed}");

        Console.WriteLine("\n------------------ SteamerDuck as IFly ----------------");

        SteamerDuck steamerDuck = new SteamerDuck();
        steamerDuck.Fly();

        Console.WriteLine("\n------------------ Array of ducks fly ----------------");

        Duck[] ducks = {duck, steamerDuck};
        foreach (var item in ducks)
        {
            item.Fly();
        }


    }
}