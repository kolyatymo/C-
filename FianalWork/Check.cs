namespace FianalWork
{
    public class Check
    {
        public Machine Machine { get; set; }

        public Cart Cart { get; set; }

        public Check(Machine machine, Cart cart)
        {
            Machine = machine;
            Cart = cart;
        }
        public void CheckCoffee()
        {
            if (Machine.Ingredients.Coffee >= 50 && Machine.Ingredients.Milk >= 50)
            {
                Coffee coffee = new Coffee();
                Console.WriteLine($"{coffee.Name} {coffee.Price} UAH");
            }
        }
        public void CheckCapu()
        {
            if (Machine.Ingredients.Coffee >= 40 && Machine.Ingredients.Milk >= 60)
            {
                Cappuccino cappuccino = new Cappuccino();
                Console.WriteLine($"{cappuccino.Name} {cappuccino.Price} UAH");
            }
        }
        public void CheckEspre()
        {
            if (Machine.Ingredients.Coffee >= 100)
            {
                Espresso espresso = new Espresso();
                Console.WriteLine($"{espresso.Name} {espresso.Price} UAH");
            }
        }
        public void CheckGreanTea()
        {
            if (Machine.Ingredients.Water >= 80)
            {
                GreanTea greanTea = new GreanTea();
                Console.WriteLine($"{greanTea.Name} {greanTea.Price} UAH");
            }
        }
        public void CheckBlackTea()
        {
            if (Machine.Ingredients.Water >= 80)
            {
                BlackTea blackTea = new BlackTea();
                Console.WriteLine($"{blackTea.Name} {blackTea.Price} UAH");
            }
        }

        public void CheckUnavailableCoffee()
        {
            if (Machine.Ingredients.Coffee < 50 || Machine.Ingredients.Milk < 50)
            {
                Coffee coffee = new Coffee();
                Console.WriteLine($"{coffee.Name} {coffee.Price} UAH");
            }
        }

        public void CheckUnavailableCapu()
        {
            if (Machine.Ingredients.Coffee < 40 || Machine.Ingredients.Milk < 60)
            {
                Cappuccino cappuccino = new Cappuccino();
                Console.WriteLine($"{cappuccino.Name} {cappuccino.Price} UAH");
            }
        }

        public void CheckUnavailableEspre()
        {
            if (Machine.Ingredients.Coffee < 100)
            {
                Espresso espresso = new Espresso();
                Console.WriteLine($"{espresso.Name} {espresso.Price} UAH");
            }
        }

        public void CheckUnavailableGreanTea()
        {
            if (Machine.Ingredients.Water < 80)
            {
                GreanTea greanTea = new GreanTea();
                Console.WriteLine($"{greanTea.Name} {greanTea.Price} UAH");
            }
        }

        public void CheckUnavailableBlackTea()
        {
            if (Machine.Ingredients.Water < 80)
            {
                BlackTea blackTea = new BlackTea();
                Console.WriteLine($"{blackTea.Name} {blackTea.Price} UAH");
            }
        }
        public bool CheckDrink(HotDrink drink)
        {
            int coffee = 0;
            int milk = 0;
            int water = 0;

            foreach (var item in Cart.HotDrinks)
            {
                if (item is Coffee)
                {
                    coffee += 50;
                    milk += 50;
                }

                if (item is Cappuccino)
                {
                    coffee += 40;
                    milk += 60;
                }

                if (item is Espresso)
                {
                    coffee += 100;
                }

                if (item is GreanTea)
                {
                    water += 80;
                }

                if (item is BlackTea)
                {
                    water += 80;
                }
            }


            if (drink is Coffee)
            {
                if (Machine.Ingredients.Coffee - coffee >= 50 && Machine.Ingredients.Milk - milk >= 50)
                    return true;
            }


            if (drink is Cappuccino)
            {
                if (Machine.Ingredients.Coffee - coffee >= 40 && Machine.Ingredients.Milk - milk >= 60)
                    return true;
            }


            if (drink is Espresso)
            {
                if (Machine.Ingredients.Coffee - coffee >= 100)
                    return true;
            }


            if (drink is GreanTea)
            {
                if (Machine.Ingredients.Water - water >= 80)
                    return true;
            }


            if (drink is BlackTea)
            {
                if (Machine.Ingredients.Water - water >= 80)
                    return true;
            }

            return false;
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