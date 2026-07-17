using _14_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Magazine magazine = new Magazine();

        while (true)
        {
            Console.WriteLine("______________ Menu ______________");
            Console.WriteLine("1 --> Enter magazine information");
            Console.WriteLine("2 --> Print magazine information");
            Console.WriteLine("3 --> Save magazine (Serialization)");
            Console.WriteLine("4 --> Load magazine (Deserialization)");
            Console.WriteLine("0 --> Exit");

            Console.Write("Choose --> ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    magazine.FillMagazine();
                    break;

                case 2:
                    magazine.PrintMagazine();
                    break;

                case 3:
                    magazine.SerializationMagazine();
                    break;

                case 4:
                    magazine.DeserializationMagazine();
                    break;

                case 0:
                    Console.WriteLine("Bye (-_-)");
                    return;
            }
        }
    }
}