using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _09_task
{
    internal class Comp
    {
        int countDisk;
        int countPrintDevice;
        Disk[] disks;
        IPrintInformation[] printInformation;

        public void AddDevice(int index, IPrintInformation si)
        {
             try
             {
                 if(index < 0 || index >= countPrintDevice)
                     throw new IndexOutOfRangeException("Error Index");

                 printInformation[index] = si;
             }
             catch(Exception ex)
             {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine(ex.Message);
                Console.ResetColor();
             }
        }

        public void AddDisk(int index, Disk d)
        {
            if(index >= 0 && index < countDisk)
                disks[index] = d;
        }

        public bool CheckDisk(string device)
        {
            foreach (var item in disks)
            {
                if(item != null && item.GetName() == device)
                    return true;
            }
            return false;




            /*if(device == "CD" || device == "DVD" || device == "Flash" || device == "HDD")
                return true;
            return false;*/
        }

        public Comp(int d, int pd)
        {
            countDisk = d;
            countPrintDevice = pd;

            disks = new Disk[countDisk];
            printInformation = new IPrintInformation[countPrintDevice];
        }

        public void InsertReject(string device, bool b)
        {
            foreach (var item in disks)
            {
                if(item != null && item.GetName() == device && item is IRemovebleDisk r)
                {
                    if (b)
                        r.Insert();
                    else 
                        r.Reject();
                }
            }
        }

        public bool PrintInfo(string text, string device)
        {
            foreach (var item in printInformation)
            {
                if(item != null && item.GetName() == device)
                {
                    item.Print(text);
                    return true;
                }
            }
            return false;
        }

        public string ReadInfo(string device)
        {
            foreach (var item in disks)
            {
                if (item != null && item.GetName() == device)
                {
                    Console.WriteLine(item.GetName() + item.Read());
                }
            }
            return " There is no Info";
        }

        public void ShowDisk()
        {
            foreach (var item in disks)
            {
                if (item != null)
                {
                    Console.WriteLine(item.GetName());
                }
            }
        }

        public void ShowPrintDevice()
        {
            foreach (var item in printInformation)
            {
                if(item != null)
                    Console.WriteLine(item.GetName());
            }
        }

        public bool WriteInfo(string text, string showDevice)
        {
            foreach (var item in disks)
            {
                if (item != null && item.GetName() == showDevice)
                {
                    Console.WriteLine(item.GetName());
                    item.Write(text);
                    return true;
                }
            }
            return false;
        }
    }
}
