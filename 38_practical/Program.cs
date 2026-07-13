using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enetr name file --> ");
        string fname = Console.ReadLine();
        Console.WriteLine($"Enter text to the file {fname}");
        var text = Console.ReadLine();

        Console.Write("Enter name folder --> ");
        string foname = Console.ReadLine();

        Directory.CreateDirectory(foname);


        Console.WriteLine("Enter (1) for file operations\nEnter (2) for folder operations");
        int i = int.Parse(Console.ReadLine());
        if (i != 1 && i != 2)
        {
            Console.WriteLine("Bye!!!");
        }
        else
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter (1) --> CopyFile\nEnter (2) --> MoveFile");
                    int f = int.Parse(Console.ReadLine());
                    if (i != 1 && i != 2)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    else
                    {
                        switch(f)
                        {
                            case 1:
                                Console.Write("Enetr name new file --> ");
                                string fnamecopy = Console.ReadLine();
                                CopyFile(fname, fnamecopy);
                                break;
                            case 2:
                                Console.Write("write a place for Move --> ");
                                string fnamemove = Console.ReadLine();
                                MoveFile(fname, fnamemove);
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter (1) --> CopyFolder\nEnter (2) --> MoveFolder");
                    int fo = int.Parse(Console.ReadLine());
                    if (i != 1 && i != 2)
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    else
                    {
                        switch (fo)
                        {
                            case 1:
                                Console.Write("Enetr name new folder --> ");
                                string fonamecopy = Console.ReadLine();
                                CopyFolder(foname, fonamecopy);
                                break;
                            case 2:
                                Console.Write("write a place for Move --> ");
                                string fonamemove = Console.ReadLine();
                                MoveFolder(foname, fonamemove);
                                break;
                        }
                    }
                    break;
            }
        }
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
                string newfo = Path.Combine(destFolder, Path.GetFileName(item));
                File.Move(newfo, destFolder);
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