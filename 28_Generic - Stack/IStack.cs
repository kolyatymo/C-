using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Generic___Stack
{
    internal interface IStack<T>
    {
        void Push(T elem);
        void Pop();
        T Peek();
        int Count {  get; }
    }
}
