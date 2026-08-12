using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_practical1
{
    internal class Logger
    {
        private DateTime Time;

        private static Logger instance; 
        private Logger(DateTime startTime) 
        {
            Time = startTime;
        }

        public void Log(string message)
        {
            Console.WriteLine($"{message} --> [{Time}]");
        }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                    instance = new Logger(DateTime.Now);

                return instance;
            }
        }
    }
}
