using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task
{
    internal class Flash : Disk, IRemovebleDisk
    {
        bool hasDisk;
        public bool HadDisk { get => hasDisk; }
        public override string GetName()
        {
            return "Flash";
        }
        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }
    }
}
