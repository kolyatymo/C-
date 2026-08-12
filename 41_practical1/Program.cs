using _41_practical1;

internal class Program
{
    private static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;

        logger1.Log("First message");
        logger2.Log("message");

        Console.WriteLine(ReferenceEquals(logger1, logger2));
    }
}