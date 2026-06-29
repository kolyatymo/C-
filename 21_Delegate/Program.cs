

// визначили тип делегату = тип (компілятор зробить клас) який містить посилання на метож або (лямбда функції) з певною сигнатурою
delegate void MsgDelegate(string message); // обєкт MsDelegate - може посилатися на статік методи та non static

static class Greeting
{
    public static void Hello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }
    public static void Bye(string name)
    {
        Console.WriteLine($"Bye, {name}");
    }
    public static void HowAreYou(string name)
    {
        Console.WriteLine($"How are you, {name}");
    }
    public static void DrawLine(int len, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(new string('*',len));
        Console.ResetColor();
    }
}

delegate double CalcDelegate(double a, double b);

class Calculator
{
    public static double Sum(double a, double b) => a + b;
    public static double SuB(double a, double b) => a - b;
    public double Mult(double a, double b) => lastResult = a + b;
    public double Div(double a, double b) => a / b;

    private double lastResult = 1;

    public override string ToString()
    {
        return $"Last multiplication result = {lastResult}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Greeting.DrawLine(40, ConsoleColor.Red);

        Greeting.Hello("Alex"); // (invok) - явний

        MsgDelegate del = new MsgDelegate(Greeting.Hello);

        Console.WriteLine($"________ Del reference to method : {del.Method}");
        Console.WriteLine($"________ Del target to method    : {del.Target}");
        del.Invoke("Maria");
        del("Olia");

        del = Greeting.HowAreYou;
        del = null;
        if (del != null)
        {
            del.Invoke("Pavlo");
        }
        // ?? ?.
        del?.Invoke("Alex");
        Console.WriteLine();
        Greeting.DrawLine(40, ConsoleColor.Red);


        MsgDelegate groupDel = Greeting.Hello;

        groupDel += Greeting.HowAreYou;
        groupDel += Greeting.Bye;
        groupDel += Greeting.HowAreYou;

        groupDel("Olia");

        groupDel -= Greeting.Bye;
        groupDel -= Greeting.HowAreYou;

        Console.WriteLine();
        Greeting.DrawLine(40, ConsoleColor.Red);

        groupDel("Olia");

        groupDel = new MsgDelegate(Greeting.HowAreYou) + Greeting.Hello;
        groupDel("Vitalia");

        Console.WriteLine();
        Greeting.DrawLine(40, ConsoleColor.Red);

        CalcDelegate deleg = Calculator.Sum;
        Console.WriteLine($"Method :: {deleg.Method}");
        Console.WriteLine($"Result :: {deleg(2,3)}");

        deleg += Calculator.SuB;
        Console.WriteLine($"Method :: {deleg.Method}");
        Console.WriteLine($"Result :: {deleg(2, 3)}");

        Console.WriteLine("\n Get result from Invocation list");

        foreach(Delegate d in deleg.GetInvocationList()) // GetInvocationList() - повертає масив
        {
            Console.WriteLine($"Operator {d.Method} :: {d.DynamicInvoke(10,15)}");
        }

        Console.WriteLine();
        Greeting.DrawLine(40, ConsoleColor.Red);

        Calculator calc = new Calculator();
        deleg = calc.Mult;
        Console.WriteLine($"________ Del reference to method : {deleg.Method}");
        Console.WriteLine($"________ Del target to method    : {deleg.Target}");
        deleg(4,10);
        Console.WriteLine(calc);

    }
}