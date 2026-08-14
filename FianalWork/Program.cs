
using FianalWork;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Machine machine = new Machine();

        string FileName = "Finalwork.json";

        MachineSer machineSer = new MachineSer(machine);

        var json = JsonSerializer.Serialize<MachineSer>(machineSer);

        Console.WriteLine(json);

        /*Dictionary<int, Car> resdic = JsonSerializer.Deserialize<Dictionary<int, Car>>(json);
        foreach (var item in resdic)
        {
            Console.WriteLine(item.Key + " \t" + item.Value);
        }*/

        /*var json = JsonSerializer.Serialize<Car>(car); // only property!!!!
        Console.WriteLine(json);*/


        Admin admin = new Admin(machine);


        while (true)
        {
            Console.WriteLine("\n_________MENU________");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 --> Admin");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2 --> User");
            Console.ResetColor();
            Console.WriteLine("0 --> Exit");

            int i = int.Parse(Console.ReadLine());

            switch (i)
            {

                case 1:
                    {
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n________ADMIN________");
                            Console.ResetColor();
                            Console.WriteLine("1 --> Show Machine");
                            Console.WriteLine("2 --> Add Ingredients");
                            Console.WriteLine("3 --> Show Money");
                            Console.WriteLine("4 --> Back to Menu");
                            Console.WriteLine("0 --> Exit");

                            int adm = int.Parse(Console.ReadLine());

                            switch (adm)
                            {
                                case 1:

                                    admin.Show();

                                    break;


                                case 2:

                                    Console.WriteLine("\n1 --> Add Water");
                                    Console.WriteLine("2 --> Add Milk");
                                    Console.WriteLine("3 --> Add Sugar");
                                    Console.WriteLine("4 --> Add Ice");
                                    Console.WriteLine("5 --> Add Coffee");

                                    int sw2 = int.Parse(Console.ReadLine());

                                    switch (sw2)
                                    {
                                        case 1:
                                            Console.WriteLine("Enter Water");
                                            int water = int.Parse(Console.ReadLine());

                                            admin.AddWater(water);
                                            admin.Show();

                                            break;

                                        case 2:

                                            Console.WriteLine("Enter Milk");
                                            int milk = int.Parse(Console.ReadLine());

                                            admin.AddMilk(milk);
                                            admin.Show();
                                            break;

                                        case 3:

                                            Console.WriteLine("Enter Sugar");
                                            int sugar = int.Parse(Console.ReadLine());

                                            admin.AddSugar(sugar);
                                            admin.Show();

                                            break;


                                        case 4:

                                            Console.WriteLine("Enter Ice");
                                            int ice = int.Parse(Console.ReadLine());

                                            admin.AddIce(ice);
                                            admin.Show();
                                            break;

                                        case 5:

                                            Console.WriteLine("Enter Coffee");
                                            int coffee = int.Parse(Console.ReadLine());

                                            admin.AddCoffee(coffee);
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
                                    int inn = int.Parse(Console.ReadLine());
                                    if (inn == 1)
                                    {
                                        admin.TakeMoney();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"money was taken");
                                        Console.ResetColor();
                                    }
                                    else if (inn == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The money remained");
                                        Console.ResetColor();
                                    }
                                    break;


                                case 4:

                                    break;


                                case 0:

                                    return;
                            }

                            if (adm == 4)
                            {
                                break;
                            }
                        }

                        break;
                    }

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n________USER________");
                        Console.ResetColor();
                        Console.WriteLine("\nEnter your money");

                        int money = int.Parse(Console.ReadLine());

                        User user = new User(machine, money);

                        user.DrinkAdded += admin.DrinkAddedM;

                        while (true)
                        {
                            Console.WriteLine("\n_________USER________");

                            Console.WriteLine(
                                $"Your money --> {user.Money} UAH"
                            );

                            Console.WriteLine("1 --> Show Drinks");
                            Console.WriteLine("2 --> Add Drink To Cart");
                            Console.WriteLine("3 --> Show Cart");
                            Console.WriteLine("4 --> Buy Cart");
                            Console.WriteLine("5 --> Back to Menu");
                            Console.WriteLine("0 --> Exit");

                            int userChoice = int.Parse(Console.ReadLine());

                            switch (userChoice)
                            {
                                case 1:
                                    user.ShowDrinks();
                                    break;
                                case 2:
                                    user.AddToCart();
                                    break;
                                case 3:
                                    user.ShowCart();
                                    break;
                                case 4:
                                    user.ByeCart();
                                    break;
                                case 5:
                                    break;
                                case 0:
                                    return;
                            }

                            if (userChoice == 5)
                            {
                                break;
                            }
                        }

                        break;
                    }
                case 0:
                    return;
            }
        }
    }
}



/*using FianalWork;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine($"enetr 1 --> Admin\nEnter 2 --> man");
        int i = int.Parse(Console.ReadLine());

        Machine machine = new Machine();
        Admin admin = new Admin(machine);

        while (true)
        {
            switch (i)
            {
                case 1:
                    {

                        Console.WriteLine($"1 --> Show Machine\n2 --> Add Ingredients\n3 --> show Monye\n");
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
                                        admin.AddMilk(Milk);
                                        admin.Show();
                                        break;
                                    case 3:
                                        Console.WriteLine("\nEnter Sugar");
                                        int Sugar = int.Parse(Console.ReadLine());
                                        admin.AddSugar(Sugar);
                                        admin.Show();
                                        break;
                                    case 4:
                                        Console.WriteLine("\nEnter Ice");
                                        int Ice = int.Parse(Console.ReadLine());
                                        admin.AddIce(Ice);
                                        admin.Show();
                                        break;
                                    case 5:
                                        Console.WriteLine("\nEnter Coffee");
                                        int Coffee = int.Parse(Console.ReadLine());
                                        admin.AddCoffee(Coffee);
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
}*/