using _16_task;
using System.Collections;
using static System.Reflection.Metadata.BlobBuilder;


internal class Program
{
    static void Print<T>(IEnumerable<T> list, string prompt)
    {
        Console.WriteLine(prompt);
        foreach (var item in list)
        {
            Console.Write($"{item,-10}");
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        Product[] products =
        {
            new Product { Name="Laptop",      Data=2026, Price=1200, Country="Ukraine", Category="Electronics" },
            new Product { Name="Smartphone",  Data=2026, Price=900,  Country="Germany", Category="Sport" },
            new Product { Name="Football",    Data=2025, Price=350,  Country="Poland",  Category="Sports" },
            new Product { Name="Bread",       Data=2026, Price=180,  Country="Ukraine", Category="Food" },
            new Product { Name="Sofa",        Data=2024, Price=1500, Country="USA",     Category="Furniture" },
            new Product { Name="Table",       Data=2026, Price=2500, Country="Italy",   Category="Furniture" },
            new Product { Name="Jacket",      Data=2025, Price=700,  Country="China",   Category="Clothes" },
            new Product { Name="T-Shirt",     Data=2026, Price=650,  Country="Turkey",  Category="Clothes" },
            new Product { Name="Sneakers",    Data=2026, Price=300,  Country="Ukraine", Category="Shoes" },
            new Product { Name="Sandals",     Data=2025, Price=450,  Country="Vietnam", Category="Sport" }
        };




        while (true)
        {
            Console.WriteLine("\n____________ MENU ___________");
            Console.WriteLine("1 --> Show products from 2026 sorted by price");
            Console.WriteLine("2 --> Count products by country");
            Console.WriteLine("3 --> Show max price product");
            Console.WriteLine("4 --> Show min price product");
            Console.WriteLine("5 --> Show categories not manufactured in Ukraine");
            Console.WriteLine("6 --> Show number of products in each category");
            Console.WriteLine("0 --> Exit");
            Console.Write("Choose --> ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    var res1 = from i in products
                               where i.Data == 2026
                               orderby i.Price descending
                               select i;

                    foreach (var item in res1)
                    {
                        Console.WriteLine($"{item,-10}");
                    }
                    Console.WriteLine();
                    break;


                case 2:
                    Console.Write($"Enter Country --> ");
                    string countr = Console.ReadLine();

                    var res2 = (from i in products
                                where i.Country == countr
                                select i.Name).Count();
                    Console.WriteLine($"The number of products in {countr} --> {res2}");
        
                    break;
                case 3:
                    var resmax = products.Max(i => i.Price);
                    var res3 = from i in products
                               where i.Price == resmax
                               select i.Name;

                    foreach (var item in res3)
                    {
                        Console.Write($"Max price product --> '{item}'\tPrice --> '{resmax}'");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    var resmin = products.Min(i => i.Price);
                    var res3_2 = from i in products
                                 where i.Price == resmin
                                 select i.Name;

                    foreach (var item in res3_2)
                    {
                        Console.Write($"Min price product --> '{item}'\tPrice --> '{resmin}'");
                    }
                    Console.WriteLine();
                    break;
                case 5:
                    var res4 = (from i in products
                                where i.Country != "Ukraine"
                                select i.Category).Distinct();
                    Print(res4, "Print categories not manufactured in Ukraine");
                    break;
                case 6:
                    var res5 = products.GroupBy(i => i.Category).Distinct().Select(i => new { Category = i.Key, Count = i.Count() });
                    foreach (var item in res5)
                    {
                        Console.WriteLine($"Category --> {item.Category} --> {item.Count}");
                    }
                    break;
                case 0:
                    Console.WriteLine("Bye (-_-)");
                    return;
            }
        }
    }   
}







/* var res1 = from i in products
                 where i.Data == 2026 
                 orderby i.Price descending
                 select i;

         foreach (var item in res1)
         {
             Console.WriteLine($"{item,-10}");
         }
         Console.WriteLine();

         Console.Write($"Enter Country --> ");
         string countr = Console.ReadLine();

         var res2 = (from i in products
                    where i.Country == countr
                    select i.Name).Count();
         Console.WriteLine($"The number of products in {countr} --> {res2}");

         var resmax = products.Max(i => i.Price);
         var res3 = from i in products
                     where i.Price == resmax
                     select i.Name;

         foreach (var item in res3)
         {
             Console.Write($"Max price product --> '{item}'\tPrice --> '{resmax}'");
         }
         Console.WriteLine();

         var resmin = products.Min(i => i.Price);
         var res3_2 = from i in products
                    where i.Price == resmin
                    select i.Name;

         foreach (var item in res3_2)
         {
             Console.Write($"Min price product --> '{item}'\tPrice --> '{resmin}'");
         }
         Console.WriteLine();


         var res4 = (from i in products
                    where i.Country != "Ukraine"
                    select i.Category).Distinct();
         Print(res4, "Print categories not manufactured in Ukraine");

         var res5 = products.GroupBy(i => i.Category).Distinct().Select(i => new { Category = i.Key, Count = i.Count()});


         foreach (var item in res5)
         {
             Console.WriteLine($"Category --> {item.Category} --> {item.Count}");
         } */
