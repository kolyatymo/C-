using FianalWork;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine($"enetr 1 --> Admin\nEnter 2 --> man");
        int i = int.Parse(Console.ReadLine());

        while (true)
        {
            switch (i)
            {
                case 1:
                    {
                        Machine machine = new Machine();
                        Admin admin = new Admin(machine);

                        Console.WriteLine($"1 --> Show Machine\n2 --> Add Ingredients\n 3 --> show Monye\n");
                        int adm = int.Parse(Console.ReadLine());

                        switch (adm)
                        {
                            case 1:
                                admin.Show();
                                break;
                            case 2:
                                Console.WriteLine($"1 --> add Water\n2 --> add Milk\n3 --> add Sugar\n4 --> add Ice\n5 --> add Coffe\n");
                                int sw2 = int.Parse(Console.ReadLine());
                                switch (sw2)
                                {
                                    case 1:
                                        Console.WriteLine("\nEnter water");
                                        int water = int.Parse(Console.ReadLine());
                                        admin.AddWater(water);
                                        admin.Show();
                                        break;
                                    case 2:
                                        Console.WriteLine("\nEnter Milk");
                                        int Milk = int.Parse(Console.ReadLine());
                                        admin.AddWater(Milk);
                                        admin.Show();
                                        break;
                                    case 3:
                                        Console.WriteLine("\nEnter Sugar");
                                        int Sugar = int.Parse(Console.ReadLine());
                                        admin.AddWater(Sugar);
                                        admin.Show();
                                        break;
                                    case 4:
                                        Console.WriteLine("\nEnter Ice");
                                        int Ice = int.Parse(Console.ReadLine());
                                        admin.AddWater(Ice);
                                        admin.Show();
                                        break;
                                    case 5:
                                        Console.WriteLine("\nEnter Coffee");
                                        int Coffee = int.Parse(Console.ReadLine());
                                        admin.AddWater(Coffee);
                                        admin.Show();
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine($"Money --> {machine.Money}");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"withdraw the money?");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\n1 --> Yes");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n2 --> No");
                                Console.ResetColor();
                                int color = int.Parse(Console.ReadLine());
                                if (color == 1)
                                {
                                    admin.TakeMoney();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"money was taken");
                                    Console.ResetColor();
                                }
                                else if (color == 2)
                                {
                                    admin.TakeMoney();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"The money remained");
                                    Console.ResetColor();
                                }
                                break;

                        }

                        break;
                    }

            }
        }

    }
}