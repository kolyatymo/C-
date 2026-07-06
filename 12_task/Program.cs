using _12_task;

internal class Program
{
    private static void Main(string[] args)
    {
        Management management = new Management();

        while (true)
        {
            Console.WriteLine("\n__________________________________\n");
            Console.WriteLine("1 --> Add employee");
            Console.WriteLine("2 --> Remove employee");
            Console.WriteLine("3 --> Change login/password");
            Console.WriteLine("4 --> Find password by login");
            Console.WriteLine("5 --> Show all employees");
            Console.WriteLine("0 --> Exit");
            Console.Write("Choose --> ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    management.AddTomanagement();
                    break;

                case "2":
                    management.RemoveLogin();
                    break;

                case "3":
                    management.ChangeInformation();
                    break;

                case "4":
                    Console.Write("Enter login --> ");
                    string login = Console.ReadLine();
                    management.PrintInfo(login);
                    break;

                case "5":
                    management.Print();
                    break;

                case "0":
                    return;
            }
        }
    }
}