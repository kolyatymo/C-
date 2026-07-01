using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_EventHandler
{
    /*delegate void PositionDelegate(string description); // 1) визначили тип делегату для події newPosition у класі Company*/

    class MyArgs : EventArgs
    {
        public string Descripton { get; set; }
        public DateTime Date => DateTime.Today; 
    }
    internal class Company // publisher
    {
        public string Name { get; set; }

        /*public event PositionDelegate NewPosition; // 2) подія = екзеспляр делегату*/
        public event EventHandler<MyArgs> NewPosition; // 2) подія = екзеспляр делегату

        public void AddPosition(string description) // 3) bussinnes logic method
        {
            MyArgs args = new MyArgs()
            {
                Descripton = description
            };
            NewPosition?.Invoke(this, args); // 4) ініціювання (запуск) події NewPosition --> вклик методів які приєднанні до делегату
        }

    }
}
