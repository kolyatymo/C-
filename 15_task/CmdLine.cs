using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _15_task
{
    internal class CmdLine
    {
        public void md(string foldername)
        {
            if(!Directory.Exists(foldername))
            {
                Directory.CreateDirectory(foldername);
                Console.WriteLine($"Folder '{foldername}' was created");
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }

        public void rd(string foldername)
        {
            if(Directory.Exists(foldername))
            {
                Directory.Delete(foldername,true);
                Console.WriteLine($"Folder '{foldername}' was deleted \n\n");
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }

        public void cd(string foldername)
        {
            if (Directory.Exists(foldername))
            {
                Directory.SetCurrentDirectory(foldername);
                Console.WriteLine($"Folder '{foldername}'");
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }
        public void dir(string patern = "*")
        {
            Console.WriteLine("Folders");
            foreach (var folder in Directory.GetDirectories(Directory.GetCurrentDirectory(), patern))
            {
                Console.WriteLine(Path.GetFileName(folder)); 
            }
            Console.WriteLine("File");
            foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory(),patern))
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }

        public void create(string fname)
        {

            Console.Write($"Enter text for file '{fname}'");
            string text = Console.ReadLine();

            File.WriteAllText(fname, text);

            Console.WriteLine($"File '{fname}' was created");
        }
        public void type(string fname)
        {
            if(File.Exists(fname))
            {
                Console.WriteLine(File.ReadAllText(fname));
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }

        public void copy(string fname, string fcopy)
        {
            if(File.Exists(fname))
            {
                File.Copy(fname, fcopy,true);
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }

        public void del(string fname)
        {
            if (File.Exists(fname))
            {
                File.Delete(fname);
                Console.WriteLine($"File '{fname}' wad deleted");
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }

        public void append(string fname)
        {
            if (File.Exists(fname))
            {
                Console.WriteLine($"Enter info in File '{fname}'");
                var text = Console.ReadLine();
                File.AppendAllText(fname, text);
            }
            else
            {
                Console.WriteLine("Eroor");
            }
        }
    }   
}
