using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    internal class SteamerDuck : Duck, IFly
    {
        /*new public void Fly()
        {
            Console.WriteLine($"Steamer Duck can not fly");
        }*/

        public override void Fly()
        {
            Console.WriteLine($"Steamer Duck can not fly");
        }
    }
}
