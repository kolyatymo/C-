using _14_practical;

internal class Program
{
    private static void Main(string[] args)
    {
        Worker[] workers = new Worker[5];
        for (int i = 0; i < workers.Length; i++)
        {
            workers[i] = new Worker();
            workers[i].Input();
        }
    }
}