using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task
{
    internal class Disk : IDisk
    {
        string memory;
        int memSize;

        public int MemSize 
        { 
            get => memSize; 
            set => memSize = value; 
        }

        public string Memory 
        { 
            get => memory;
            set => memory = value; 
        }

        public Disk(){}

        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public virtual string GetName()
        {
            return "Disk";
        }
        public string Read()
        {
            return Memory;
        }

        public void Write(string text)
        {
            Memory = text;
        }
    }
}
