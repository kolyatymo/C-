using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public void AddDisk(int index, Disk d)
        {

        }

        public bool CheckDisk(string device)
        {
            return false;
        }

        public Comp(int d, int pd)
        {

        }

        public void InsertReject(string device, bool b)
        {

        }

        public bool PrintInfo(string text, string device)
        {
            return false; 
        }

        public string ReadInfo(string device)
        {
            return "f";
        }

        public void ShowDisk()
        {

        }

        public void ShowPrintDevice()
        {

        }

        public bool WriteInfo(string text, string showDevice)
        {
            return false;
        }
    }
}
