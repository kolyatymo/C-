using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Pattern_factoryMethod
{
    public interface ITransport
    {
        void deliver(int weight);
    }

    public class Ship : ITransport // concrete product A
    {
        public void deliver(int weight)
        {
            Console.WriteLine("Deliver by ship with weight " + weight);
        }
    }

    public class Truck : ITransport // concrete product B
    {
        public void deliver(int weight)
        {
            Console.WriteLine("Deliver by LIGHT truck cargo with weight " + weight);
        }
    }

    public class HeavyTruck : ITransport // concrete product B
    {
        public void deliver(int weight)
        {
            Console.WriteLine("Deliver by HEAVY truck cargo with weight " + weight);
        }
    }

    // Factory Method

    abstract public class Logistics
    {
        abstract public ITransport CreateTransport(int weight);
        public void PlanDelivery(int weight)
        {
            ITransport transport = CreateTransport(weight);
            transport.deliver(weight);
        }
    }

    // concrete FactoryMethod

    public class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport(int weight)
        {
            if(weight < 5_000)
                return new Truck();
            else
                return new HeavyTruck();
        }
    }

    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport(int weight)
        {
            return new Ship();
        }
    }
}
