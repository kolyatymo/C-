internal class Program
{
    private static void Main(string[] args)
    {
        File.WriteAllText("A.txt", "hi");

        CopyFile("A.txt", "CopyA.txt");

        MoveFile("CopyA.txt", "MovedA.txt");

        Directory.CreateDirectory("A1");

        CopyFolder("A1", "CopyFolder");

        MoveFolder("CopyFolder", "MovedFolder");
        Console.ReadKey();

    }

    static void CopyFile(string sourcFile, string destFile)
    {
        if(!File.Exists(sourcFile))
        {
            Console.WriteLine("File not found");
            return;
            
        }
        try
        {
            File.Copy(sourcFile, destFile, true);
            Console.WriteLine("File Copy successful");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error copy!!!");
        }
    }
    
    static void MoveFile(string sourcFile, string destFile)
    {
        if(!File.Exists(sourcFile))
        {
            Console.WriteLine("File not found");
            return;
        }
        try
        {
            if (File.Exists(destFile))
            {
                File.Delete(destFile);
            }

            File.Move(sourcFile, destFile);
            Console.WriteLine("File Move successful");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error Move!!!");
        }
    }

    static void CopyFolder(string sourcFolder, string destFolder)
    {
        if (!Directory.Exists(sourcFolder))
        {
            Console.WriteLine("Folder not found");
            return;
        }
        try
        {
            Directory.CreateDirectory(destFolder);

            foreach (var item in Directory.GetFiles(sourcFolder))
            {
                Path.Combine(item, destFolder);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error copy!!!");
        }
    }

    static void MoveFolder(string sourcFile, string destFile)
    {
        if (!Directory.Exists(sourcFile))
        {
            Console.WriteLine("Folder not found");
            return;
        }
        try
        {
            if (Directory.Exists(destFile))
            {
                Directory.Delete(destFile, true);
            }
            Directory.Move(sourcFile, destFile);
            Console.WriteLine("Folder Move successful");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error Move!!!");
        }
    }
}