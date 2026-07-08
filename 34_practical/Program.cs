using System.IO;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string fname = "practical.txt";
        int line = 1;
        int symbol = 0;
        int word = 0;
        int digit = 0;
        using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {

            int a;

            while ((a = br.Read()) != -1)
            {
                char b = (char)a;

                symbol++;
                
                if(b == '\n')
                    line++;
                if(char.IsDigit(b))
                    digit++;

                if(char.IsWhiteSpace(b))
                    word++;
            }

            Console.WriteLine($"Line   --> {line}");
            Console.WriteLine($"Symbol --> {symbol}");
            Console.WriteLine($"word   --> {word}");
            Console.WriteLine($"digit  --> {digit}");
        }

        string newfile = "resulr.txt";

        using (BinaryWriter bw = new BinaryWriter(new FileStream(newfile, FileMode.Create, FileAccess.Write)))
        {
            bw.Write($"line -->  {line}");
            bw.Write($"word -->  {word}");
            bw.Write($"digi -->  {digit}");
            bw.Write($"symb -->  {symbol}");
        }
    }
}