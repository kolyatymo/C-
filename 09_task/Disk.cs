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
            get => Memory;
            set => Memory = value; 
        }

        public Disk(){}

        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }

        public string GetName()
        {
            return "f";
        }
        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
