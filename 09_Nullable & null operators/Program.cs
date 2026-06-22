class Person
{
    string name;
    public string Name
    {
        get => name;
        set => name = value ?? "Noname"; // перевірка чи не null
    }

}
internal class Program
{

    private static void Main(string[] args)
    {
        // value types --> по памятю розташовані в статичній ділянці памятті (int, double, bool, enum, struc) != null - не мають null
        // reference types --> динамічній (class, array, string, stringBuilder) містять посилання на обєкт = null
        /*int a = null;*/
        /*string str = null;*/

        Nullable<int> a = 10;
        int? j = 155; // ? перетворення у Nullable type

        /*int value = (int)a;*/
        int value;

        Console.WriteLine($"Value :: {a}");
        if(a.HasValue)
        {
            value = (int)a;
            Console.WriteLine($"Value :: {value}");
        }
        else
        {
            Console.WriteLine("Has not value");
        }

        Console.WriteLine($" a + j = {a.GetValueOrDefault() + j.GetValueOrDefault()}");
        Console.WriteLine($" a * j = {a.GetValueOrDefault(1) * j.GetValueOrDefault(1)}"); // числові типи деф = 0, но можна задавати значення дефолта

        int? sum = a + j;
        Console.WriteLine("Sume = " + (sum ?? 0)); // ?? скорочений тернарний оператор перевіряє значення на null
        a = null;
        sum = (a ?? 0) + j;
        Console.WriteLine("Sume = " + (sum ?? 0)); // ?? скорочений тернарний оператор перевіряє значення на null або GetValueOrDefault()

        Person person = new Person() { Name = null };
        Person person2 = new Person() { Name = "Sergiy" };
        Person person1 = null;
        Console.WriteLine(person.Name);
        Console.WriteLine(person2.Name);
        Console.WriteLine(person1?.Name);


        string str = null;
        Console.WriteLine(str?.Length ?? -1);
        Console.WriteLine(str?.Replace('i', '*') ?? "Error");

        int[] arr = { 1, 2, 3 };
        Console.WriteLine($"First Element {arr[0]}");

        arr = null;
        Console.WriteLine($"First Element {arr?[0] ?? int.MinValue}");
        arr ??= new int[10];




    }
}