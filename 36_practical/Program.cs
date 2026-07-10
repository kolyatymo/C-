using _36_practical;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        WebClient wc = new WebClient();
        string json = wc.DownloadString("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");

        List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(json);

        Console.WriteLine("Enter the currency");
        string usa = Console.ReadLine().ToUpper();

        Currency cu = currencies.FirstOrDefault(c=> c.ccy == usa);

        if (cu != null)
        {
            Console.WriteLine($"{usa} bye --> {cu.Buy}");
            Console.WriteLine($"{usa} sale --> {cu.Sale}");













            Console.WriteLine($"Enetr the amount of {usa}");
            double money = double.Parse(Console.ReadLine());
            Console.Write($"Enter currency --> ");
            string cur = Console.ReadLine().ToUpper();
            Currency curs = currencies.FirstOrDefault(c => c.ccy == cur);

            if (cur != null )
            {
                double totalusa = money * cu.Buy;
                double totalcur = curs.Buy;
                double total = totalusa / totalcur;
                if (total >= 1.0)
                {
                    Console.WriteLine($"{money} {usa} You can exchange it for {total} {cur}");
                }
                else
                    Console.WriteLine("low money");

            }
        }
        else
            Console.WriteLine("currency Not found");



    }
}