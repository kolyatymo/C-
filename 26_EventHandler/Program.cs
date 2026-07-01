using _26_EventHandler;

internal class Program
{
    private static void Main(string[] args)
    {
        Company softServe = new Company { Name = "SoftServe" };
        Company honeyComb = new Company { Name = "HoneyComb" };

        Interviwer ann = new Interviwer { Name = "Ann" };
        Interviwer alex = new Interviwer { Name = "Alex" };


        softServe.NewPosition += ann.DoSomething; // підписка Анни на softServe
        softServe.NewPosition += alex.DoSomething;

        honeyComb.NewPosition += ann.DoSomething;
        honeyComb.NewPosition += alex.DoSomething;

        softServe.AddPosition("Intern C++");
        Console.WriteLine();
        honeyComb.AddPosition("Junior .NET");
        Console.WriteLine();

        honeyComb.NewPosition -= ann.DoSomething; // відписка Анни на honeyComb
        Console.WriteLine();
        honeyComb.AddPosition("Middle Frontent");
    }
}