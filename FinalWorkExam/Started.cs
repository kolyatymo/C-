namespace FinalWorkExam
{
    internal class Started
    {
        public void Start()
        {
            CreateAccount account = new CreateAccount();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("---- QUIZ ____");
                Console.WriteLine("1 --> Registration");
                Console.WriteLine("2 --> Login");
                Console.WriteLine("3 --> Exit");
                Console.Write("Choose --> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account.Registration();

                        if (!string.IsNullOrEmpty(CreateAccount.CurrentUser))
                        {
                            UserMenu();
                        }
                        break;

                    case 2:
                        account.Login();

                        if (!string.IsNullOrEmpty(CreateAccount.CurrentUser))
                        {
                            UserMenu();
                        }
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }

        private void UserMenu()
        {
            Victory victory = new Victory();

            while (!string.IsNullOrEmpty(CreateAccount.CurrentUser))
            {
                Console.Clear();

                Console.WriteLine("----- menu ----- ");
                Console.WriteLine($"User --> {CreateAccount.CurrentUser}\n");
                Console.WriteLine("1 --> Start new quiz");
                Console.WriteLine("2 --> My results");
                Console.WriteLine("3 --> Top 20");
                Console.WriteLine("4 --> Settings");
                Console.WriteLine("5 --> Leave");
                Console.Write("Choose --> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        victory.Run();
                        break;

                    case 2:
                        ShowMyResults();
                        Console.ReadKey();
                        break;

                    case 3:
                        ShowTop20();
                        Console.ReadKey();
                        break;

                    case 4:
                        Settings(victory);
                        break;

                    case 5:
                        CreateAccount.CurrentUser = null;
                        Console.WriteLine("Logout successful");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }

        private void ShowMyResults()
        {
            Console.Clear();
            Console.WriteLine("____ Results ____");

            string[] files =
            {
                "resultGeo.txt",
                "resultBiol.txt",
                "resultMath.txt"
            };

            foreach (string file in files)
            {
                if (!File.Exists(file))
                    continue;

                foreach (string line in File.ReadAllLines(file))
                {
                    if (line.StartsWith(CreateAccount.CurrentUser + " -->"))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        private void ShowTop20()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("___ (TOP 20) ___");
            Console.ResetColor();

            string[] files =
            {
                "resultGeo.txt",
                "resultBiol.txt",
                "resultMath.txt",
                "resultMixed.txt"
            };

            foreach (string file in files)
            {
                if (!File.Exists(file))
                    continue;

                Console.WriteLine($"\n ({file}) \n");

                string[] results = File.ReadAllLines(file);

                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
            }
        }
        private void Settings(Victory victory)
        {
            CreateAccount account = new CreateAccount();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("----- SETTINGS _____\n");
                Console.WriteLine("1 --> Change password");
                Console.WriteLine("2 --> Change birth date");
                Console.WriteLine("3 --> Edit quiz");
                Console.WriteLine("4 --> Back");
                Console.Write("Choose --> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account.ChangePassword();
                        Console.ReadKey();
                        break;

                    case 2:
                        account.ChangeDate();
                        Console.ReadKey();
                        break;
                    case 3:
                        victory.EditingVictory();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}

