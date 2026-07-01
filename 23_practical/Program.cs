
enum Operation { Plus, Minus, Mult, Div}
class Calculator
{
    Func<double, double, double> func;

    public static double Sum(double a, double b) => a + b;
    public static double SuB(double a, double b) => a - b;
    public static double Mult(double a, double b) => a * b;
    public static double Div(double a, double b) => a / b;


    public void setOperation(Operation op)
    {
        if (op == Operation.Plus)
            this.func = Sum;
        if (op == Operation.Minus)
            this.func = SuB;
        if (op == Operation.Mult)
            this.func = Mult;
        if (op == Operation.Div)
            this.func = Div;
    }

    public double calculator(double one, double two)
    {
        return func(one, two);
    }


}

internal class Program 
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.ForegroundColor = ConsoleColor.Green;

        calc.setOperation(Operation.Plus);
        Console.WriteLine($"Plus --> 10 + 5 = {calc.calculator(10, 5)}");

        Console.ForegroundColor = ConsoleColor.Magenta;

        calc.setOperation(Operation.Mult);
        Console.WriteLine(calc.calculator(10, 5)); 

        calc.setOperation(Operation.Div);

        Console.ResetColor();
        
    }
}