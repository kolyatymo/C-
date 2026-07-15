using System.Text.RegularExpressions;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter Email --> ");
        string email = Console.ReadLine();

        string patternEmail = @"^[A-Za-z0-9._-]{4,}@[A-Za-z0-9]{2,}\.[A-Za-z]{2,}$";

        var regex = new Regex(patternEmail);
        
        Match match = regex.Match(email);
        if (match.Success)
        {
            Console.WriteLine($"Email --> {email}");
        }
        else
        {
            Console.WriteLine($"Email {email} is bad");
        }

        if(match.Success)
        {
            Console.Write("Enter password --> ");
            string password = Console.ReadLine();

            Match match2 = regex.Match(password);

            bool success = Regex.IsMatch(password, @".{6,}") && Regex.IsMatch(password, @"[A-Z]+") && Regex.IsMatch(password, @"[a-z]+") && Regex.IsMatch(password, @"[0-9]+") && Regex.IsMatch(password, @"[_-]+") && Regex.IsMatch(password, @"[A-Z]+") && Regex.IsMatch(password, @"^[A-Za-z0-9_-]+$");
            if (success)
            {
                Console.WriteLine($"password --> {password}");
            }
            else
            {
                Console.WriteLine($"password {password} is bad");
            }
        }
    }
}