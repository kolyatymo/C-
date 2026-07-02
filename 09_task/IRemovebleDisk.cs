using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task
{
    internal interface IRemovebleDisk
    {
        bool HadDisk { get; }

        void Insert();
        void Reject();
    }
}
