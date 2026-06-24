using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    internal interface IMove
    {
        int Speed { get; }
        void Move();
    }
}
