using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20_practical
{
    internal class Train
    {
        private int NumberOfTrain;
        private string TypeTrain;

        protected Wagon[] wagons;

        private string КouteТame;
        private DateTime DateOfDispatch;
        private DateTime DateOfArrival;

        public Train(){}

        public Train(int number, string type, Wagon[] wagons, string route, DateTime dispatch, DateTime arrival)
        {
            NumberOfTrain = number;
            TypeTrain = type;
            this.wagons = wagons;
            КOuteТame = route;
            DateOfDispatch = dispatch;
            DateOfArrival = arrival;
        }

        public override string ToString()
        {
            return $"Train --> {NumberOfTrain}\n" + $"Type --> {TypeTrain}\n" + $"Route --> {КOuteТame}\n" + $"Wagons --> {wagons.Length}\n" + $"Dispatch --> {DateDispatch}\n" + $"Arrival --> {DateArrival}";  
        }

        public void TimeToArrival()
        {
            Console.WriteLine($"Time to arrival --> {DateOfArrival - DateTime.Now}");
        }

        public void TotalNumOfWagonAndSeats()
        {
            Console.WriteLine($" Numb wagons --> {wagons.Length}");
            int sum = 0;
            foreach (var item in wagons)
            {
                sum += item.NumbSeats();
            }
            Console.WriteLine($"total number of cities --> {sum}");

        }

        public double AveragePassegare()
        {
            return wagons.Average(p => p.NumbOfPasseng);
        }

        public int DateDispatch { get; set; }
        public int DateArrival { get; set; }

        public string КOuteТame 
        {
            get => КouteТame;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentNullException();
                    Console.ResetColor();
                }
                КouteТame = value;
            }
        }


    }

    struct Wagon
    {
        private int number;
        private string TypeWagon;
        private int NumberOfSeats;
        private int NumberOfPassenger;

        public int Number 
        {
            get => number;
            set => number = value;
        }

        public Wagon(int number, string TypeWago, int NumSeats, int NumPassenger)
            :this() 
        {
            Number = number;
            TypeWag = TypeWago;
            NumbOfSeats = NumSeats;
            NumberOfPassenger = NumPassenger;
        }

        public string TypeWag 
        {
            get => TypeWagon;
            set 
            { if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new ArgumentNullException();
                    Console.ResetColor();
                }
                TypeWagon = value;
            }
        }

        public int NumbOfSeats 
        {
            get => NumberOfSeats; 
            set => NumberOfSeats = value;
        }

        public int NumbOfPasseng 
        {
            get => NumberOfPassenger;
            set => NumberOfPassenger = value;
        }

        public int NumbSeats()
        {
            return NumberOfSeats - NumberOfPassenger;
        }

        public override string ToString()
        {
            return $"Wagon number --> {Number}\t Type wagons --> {TypeWag}\n" + $"Seats --> {NumbOfSeats}\n " + $"Passengers -->  {NumbOfPasseng}";
        }
    }
}
