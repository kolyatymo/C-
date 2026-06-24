using _17_IEnumerable;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Demo demo = new Demo();
        demo.Test();*/

        Item apple = new Item() { Name = "Apple", Price = 20 }; 
        Item Grapes = new Item() { Name = "Grapes", Price = 40 }; 
        Item Orange = new Item() { Name = "Orange", Price = 50 }; 
        Item Blueberry = new Item() { Name = "Blueberry", Price = 70 };

        // var bucket = new ShopBucket();
        ShopBucket bucket = new();
        bucket.AddItem(apple);
        bucket.AddItem(Grapes);
        bucket.AddItem(Orange);
        bucket.AddItem(Blueberry);

        Console.WriteLine(bucket);
        Console.ReadLine();
        Console.WriteLine("_________ foreach __ (GetEnumerator)_______");
        foreach (var product in bucket)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine();
        Console.WriteLine("_________ foreach __ (GetReverse)_______");
        foreach (var product in bucket.GetReverse())
        {
            Console.WriteLine(product);
        }
        
        Console.WriteLine();
        Console.WriteLine("_________ foreach __ (GetReverse)_______");
        foreach (var product in bucket.GetCheaperItem(40))
        {
            Console.WriteLine(product);
        }
    }
}