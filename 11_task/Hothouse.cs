using _11_task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

enum Weather { winter, summer, autumn, spring }

delegate void HotHouseDeleg(Hothouse house);

namespace _11_task
{
    internal class Hothouse
    {
        private int temperatures;
        public int Temperatures 
        {
            get 
            {
                return weather == Weather.winter ? temperatures - 2 : temperatures + 2; 
            }
            set
            {
                temperatures = value;
            }
        }
        public Weather weather { get; set; }

        private const uint MaxTemperatur = 35;
        private const uint MinTemperatur = 15;

        public Hothouse(int temp, Weather weather)
        {
            Temperatures = temp;
            this.weather = weather;
        }

        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Well;

        public void CheckTemp()
        {
            if (Temperatures > MaxTemperatur)
            {
                Console.WriteLine($"Temperature = {Temperatures}, higher than the maximum");
                TooHot?.Invoke(this);
            }
            else if (Temperatures < MinTemperatur)
            {
                Console.WriteLine($"temperature --> {Temperatures}, below the minimum");
                TooCold?.Invoke(this);
            }
            else
            {
                Console.WriteLine($"temperature --> {Temperatures}, is normal");
                Well?.Invoke(this);
            }
        }

        public void Info()
        {
            Console.WriteLine($"Weather --> {weather};\nTemperature --> {Temperatures}");
        }

    }

    class Heater
    {
        public void Warm(Hothouse h)
        {
            h.Temperatures += 5;
            Console.WriteLine($"The temperature increased by 5 degrees --> {h.Temperatures} Temp");
        }
    }

    class Cooler
    {
        public void Cool(Hothouse h)
        { 
            h.Temperatures -= 5;
            Console.WriteLine($"The temperature is lower by 5 degrees --> {h.Temperatures} Temp");

        }
    }
}












/*public void TooHotHouse(Hothouse house) 
        {
            TooHot?.Invoke(house);
        }

        public void HigherTemperature()
        {
            if (Temperatures > MaxTemperatur)
            {
                Console.WriteLine($"Temperature = {Temperatures}, higher than the maximum");
                TooHot?.Invoke(this);
            }
        }

        public void TooColdHouse(Hothouse house) 
        {
            TooCold?.Invoke(house);
        }

        public void LowerTemperature()
        {
            if (Temperatures < MinTemperatur)
            {
                Console.WriteLine($"temperature --> {Temperatures}, below the minimum");
                TooCold?.Invoke(this);
            }
        }*/
