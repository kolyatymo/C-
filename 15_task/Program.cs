using _15_task;

internal class Program
{
    private static void Main(string[] args)
    {
        CmdLine cmd = new CmdLine();

        while (true)
        {
            Console.WriteLine("\n____________ MENU ___________");
            Console.WriteLine("1 --> Create folder (md)");
            Console.WriteLine("2 --> Delete folder (rd)");
            Console.WriteLine("3 --> Change current folder (cd)");
            Console.WriteLine("4 --> Show files and folders (dir)");
            Console.WriteLine("5 --> Create file (create)");
            Console.WriteLine("6 --> Show file content (type)");
            Console.WriteLine("7 --> Copy file (copy)");
            Console.WriteLine("8 --> Delete file (del)");
            Console.WriteLine("9 --> Append text to file (append)");
            Console.WriteLine("0 --> Exit");
            Console.Write("Choose --> ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter folder name --> ");
                    cmd.md(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter folder name --> ");
                    cmd.rd(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Enter folder name --> ");
                    cmd.cd(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Enter pattern (* for all) --> ");
                    string pattern = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(pattern))
                        cmd.dir();
                    else
                        cmd.dir(pattern);
                    break;

                case 5:
                    Console.Write("Enter file name --> ");
                    cmd.create(Console.ReadLine());
                    break;

                case 6:
                    Console.Write("Enter file name --> ");
                    cmd.type(Console.ReadLine());
                    break;

                case 7:
                    Console.Write("Enter source file --> ");
                    string source = Console.ReadLine();

                    Console.Write("Enter destination file --> ");
                    string destination = Console.ReadLine();

                    cmd.copy(source, destination);
                    break;

                case 8:
                    Console.Write("Enter file name --> ");
                    cmd.del(Console.ReadLine());
                    break;

                case 9:
                    Console.Write("Enter file name --> ");
                    cmd.append(Console.ReadLine());
                    break;

                case 0:
                    Console.WriteLine("Bye (-_-)");
                    return;
            }
        }
    }
}