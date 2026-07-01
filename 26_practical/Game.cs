using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_practical
{
    delegate void Finish(string description);
    delegate void Start(string description);
    delegate void PositinCar(string description);
    internal class Game
    {
        public List<Car> car = new List<Car>();
        public string NameGame { get; set; }

        public event Start PositionStart;
        public event Finish PositionFinish;
        public event PositinCar PositionCar;


        public void GameEvent(string description)
        {
            PositionStart?.Invoke(description);
            
            bool finish = false;

            while(!finish)
            {
                foreach (var item in car)
                {
                    item.Go();

                    PositionCar?.Invoke($"car --> {item.Name}");

                    if(item.IsFinish)
                    {
                        finish = true;
                        break;
                    }
                }
            }
            PositionFinish?.Invoke(description);
        }

        
    }
}
