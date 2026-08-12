using _41_Pattern_Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        CountryBudget budget = CountryBudget.getInstance(1_000_000);
        Console.WriteLine($"Start budget     :: {budget.getMoney} $ \t HashCode --> {budget.GetHashCode()}");

        budget.add(6000);
        Console.WriteLine($"Add money budget :: {budget.getMoney} $ \t HashCode --> {budget.GetHashCode()}");


        CountryBudget budget2 = CountryBudget.getInstance(400000);
        Console.WriteLine($"Start budget2    :: {budget2.getMoney} $ \t HashCode --> {budget2.GetHashCode()}");

        budget2.spend(6001);
        Console.WriteLine($"Start budget1    :: {budget.getMoney} $ \t HashCode --> {budget.GetHashCode()}");
        Console.WriteLine($"Start budget2    :: {budget2.getMoney} $ \t HashCode --> {budget2.GetHashCode()}");

        CountryBudget budget3 = budget;
        if (budget == budget2 && budget2 == budget3)
        {
            Console.WriteLine("Reference to a single object");
        }
        else
        {
            Console.WriteLine("Reference to not a single object");           
        }
    }
}