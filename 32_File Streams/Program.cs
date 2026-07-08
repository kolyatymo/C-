using System.Text;

internal class Program
{
    static void writeString(string value, string path)
    {
        /*using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            Console.WriteLine($"Test byte array : {String.Join(" ", bytes)}");
            fs.Write(bytes,0, bytes.Length);
        }*/
        
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            byte length = (byte)bytes.Length; // підходить якщо не перевищує 255 символів
            fs.WriteByte(length);
            Console.WriteLine($"Size :: {length}\nTest byte array : {String.Join(" ", bytes)}");

            fs.Write(bytes,0, bytes.Length);
        }
    }

    static void readString(string path)
    {
        string value = String.Empty;
        /*using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes,0,bytes.Length);
            value = Encoding.Unicode.GetString(bytes); // перетворення байтів в рядок
            Console.Write($"Result read file :: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value);
            Console.ResetColor();
        }*/

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte length = (byte)fs.ReadByte();
            byte[] bytes = new byte[length];
            fs.Read(bytes, 0, bytes.Length);
            value = Encoding.Unicode.GetString(bytes); // перетворення байтів в рядок
            Console.Write($"Size :: {length}\nResult read file :: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value);
            Console.ResetColor();
        }
    }

    static void writeInt(int value, string path)
    {
        using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] bytes = BitConverter.GetBytes(value); // конвертація в масив байтів
            Console.WriteLine($"Test byte array : {String.Join(" ", bytes)}");
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    static void readInt(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            int value = 0;
            //byte[] bytes = BitConverter.GetBytes(value);
            byte[] bytes = new byte[sizeof(int)];
            fs.Read(bytes,0, bytes.Length);

            value = BitConverter.ToInt32(bytes);
            Console.Write($"Result :: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(value);
            Console.ResetColor();
        }
    }
    private static void Main(string[] args)
    {
        /*string name = "Bytes.dat";

        using(FileStream file = new FileStream(name, FileMode.OpenOrCreate)) // using сам очищає файл і закриває
        {
            byte buteValue = 65;
            byte[] array = { 122, 123, 124, 125, 14, 15 }; // byte - ( 0 - 255 )

            file.WriteByte(buteValue);
            file.Write(array, 0, array.Length);
            Console.WriteLine($"Position file curser :: {file.Position}");

            file.Position = 0;
            //file.Seek(0, SeekOrigin.Begin);
            //file.Seek(-2, SeekOrigin.End);
            //file.Seek(5, SeekOrigin.Current);
            Console.WriteLine($"Position file curser :: {file.Position}");
            Console.WriteLine($"File sixe in bytes : {file.Length}");

            byte[] result = new byte[file.Length];
            file.Read(result, 0, result.Length); // читати з файлу

            Console.WriteLine($"File read :: {String.Join('\t', result)}");

            

        }*/

        /*FileStream file = new FileStream(name, FileMode.OpenOrCreate)
        byte buteValue = 65;
        byte[] array = { 122, 123, 124, 125, 14, 15 }; // byte - ( 0 - 255 )

        file.WriteByte(buteValue);
        file.Write(array, 0, array.Length);
        Console.WriteLine($"Position file curser :: {file.Position}");*/

        //file.Close();

        /*writeString("Lorem ipsum","string.dat");

        readString("string.dat");*/

        //writeInt(333, "number.dat");

        readInt("number.dat");


    }
}