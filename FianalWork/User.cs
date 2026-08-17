namespace FianalWork
{
    delegate void DrinkDelegate(string description);
    internal class User
    {
        public Machine Machine { get; set; }

        public Cart Cart { get; set; }

        public int Money { get; set; }

        public event DrinkDelegate DrinkAdded;

        public User(Machine machine, int money)
        {
            Machine = machine;
            Cart = new Cart();
            Money = money;
        }
        public void ShowDrinks()
        {
            Check check = new Check(Machine, Cart);

            Console.WriteLine("\nAvailable drinks\n");

            Console.ForegroundColor = ConsoleColor.Green;

            // TODO: refactor code
            //foreach (var drink in Machine.HotDrinks) 
            //{
            //    drink.Check();
            //}

            check.CheckCoffee();
            check.CheckCapu();
            check.CheckEspre();
            check.CheckGreanTea();
            check.CheckBlackTea();

            Console.ResetColor();


            Console.WriteLine("\nUnavailable drinks\n");

            Console.ForegroundColor = ConsoleColor.Red;
            
            check.CheckUnavailableCoffee();
            check.CheckUnavailableCapu();
            check.CheckUnavailableEspre();
            check.CheckUnavailableGreanTea(); 
            check.CheckUnavailableBlackTea();

            Console.ResetColor();
        }
        public void AddToCart()
        {
            ShowDrinks();

            Console.WriteLine("Enter drink number");
            int number = int.Parse(Console.ReadLine());


            HotDrink hotDrink = Machine.HotDrinks[number - 1];

            Check check = new Check(Machine, Cart);

            if (check.CheckDrink(hotDrink))
            {
                Cart.AddDrink(hotDrink);

                Console.ForegroundColor = ConsoleColor.Green;
                DrinkAdded?.Invoke($"{hotDrink.Name} added to cart");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{hotDrink.Name} is unavailable!");
                Console.ResetColor();
            }
        }

        public void ShowCart()
        {
            Cart.ShowCart();
        }

        public void ByeCart()
        {
            Console.WriteLine($"1 --> Add ice?\n2 --> Add Sugar\n3 --> not necessary");
            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"Ice added");
                Console.ResetColor();
                Machine.Ingredients.Ice -= 20;
            }
            if(i == 2)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"Sugar added");
                Console.ResetColor();
                Machine.Ingredients.Sugar -= 20;
            }
            if (i == 3)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("(Bon appetit)");
                Console.ResetColor();
            }
            if (Cart.HotDrinks.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }

            double total = Cart.MOney();

            if (Money < total)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not enough money!");
                Console.ResetColor();
                return;
            }

            foreach (var drink in Cart.HotDrinks)
            {
                if (drink is Coffee)
                {
                    Machine.Ingredients.Coffee -= 50;
                    Machine.Ingredients.Milk -= 50;
                }

                if (drink is Cappuccino)
                {
                    Machine.Ingredients.Coffee -= 40;
                    Machine.Ingredients.Milk -= 60;
                }

                if (drink is Espresso)
                {
                    Machine.Ingredients.Coffee -= 100;
                }

                if (drink is GreanTea)
                {
                    Machine.Ingredients.Water -= 80;
                }

                if (drink is BlackTea)
                {
                    Machine.Ingredients.Water -= 80;
                }
            }

            Money -= (int)total;

            Machine.Money += total;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Item purchased successfully");
            Console.WriteLine($"You paid {total} UAH");
            Console.WriteLine($"Your money --> {Money} UAH");

            Console.ResetColor();

            Cart.HotDrinks.Clear();
        }
    }
}

/*public void ShowDrinks()
{
    Console.WriteLine($"\nAvailable drinks\n");

    if(Machine.Ingredients.Coffee >= 50 && Machine.Ingredients.Milk >= 50)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Coffee coffee = new Coffee();
        Console.WriteLine($"{coffee.Name} {coffee.Price} UAH");
    }
    if(Machine.Ingredients.Coffee >= 40 && Machine.Ingredients.Milk >= 60)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Cappuccino cappuccino = new Cappuccino();
        Console.WriteLine($"{cappuccino.Name} {cappuccino.Price} UAH");
    }
    if(Machine.Ingredients.Coffee >= 100)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Espresso espresso = new Espresso();
        Console.WriteLine($"{espresso.Name} {espresso.Price} UAH");
    }
    if(Machine.Ingredients.Water >= 80)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        GreanTea greanTea = new GreanTea();
        Console.WriteLine($"{greanTea.Name} {greanTea.Price} UAH");
    }
    if(Machine.Ingredients.Water >= 80)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        BlackTea blackTea = new BlackTea();
        Console.WriteLine($"{blackTea.Name} {blackTea.Price} UAH");
    }
    Console.WriteLine($"\nUnavailable drinks\n");


    if (!(Machine.Ingredients.Coffee >= 50 && Machine.Ingredients.Milk >= 50))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Coffee coffee = new Coffee();
        Console.WriteLine($"{coffee.Name} {coffee.Price} UAH");
    }
    if (!(Machine.Ingredients.Coffee >= 40 && Machine.Ingredients.Milk >= 60))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Cappuccino cappuccino = new Cappuccino();
        Console.WriteLine($"{cappuccino.Name} {cappuccino.Price} UAH");
    }
    if (!(Machine.Ingredients.Coffee >= 100))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Espresso espresso = new Espresso();
        Console.WriteLine($"{espresso.Name} {espresso.Price} UAH");
    }
    if (!(Machine.Ingredients.Water >= 80))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        GreanTea greanTea = new GreanTea();
        Console.WriteLine($"{greanTea.Name} {greanTea.Price} UAH");
    }
    if (!(Machine.Ingredients.Water >= 80))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        BlackTea blackTea = new BlackTea();
        Console.WriteLine($"{blackTea.Name} {blackTea.Price} UAH");
    }
    Console.ResetColor();

}*/