using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void PositionDelegate(string description); // 1) визначили тип делегату для події newPosition у класі Company
    internal class Company // publisher
    {
        public string Name { get; set; }

        public event PositionDelegate NewPosition; // 2) подія = екзеспляр делегату

        public void AddPosition(string description) // 3) bussinnes logic method
        {
            NewPosition?.Invoke(description); // 4) ініціювання (запуск) події NewPosition --> вклик методів які приєднанні до делегату
        }

    }
}
