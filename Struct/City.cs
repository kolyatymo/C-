using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct City : IComparable, IComparable<City>
    {
        const int DefaultPopulation = 100_000;
        const int MaxPopulation = 10_1000_000;
        private int population;

        public string Name { get; set; } 
        public int Population
        {
            get => population;
            set => population = value <= MaxPopulation ? value : MaxPopulation;
        }

        public City(string name, int population = DefaultPopulation)
            :this()
        {
            Name = name;
            this.population = population;
        }

        public override string ToString()
        {
            return $"City : {Name, -10} Population : {population, -15}";
        }

        public int CompareTo(object? obj) // not protuctive boxing unboxing
        {
            Console.WriteLine("CompareTo");
            if (!(obj is City)) // not City
                throw new ArgumentException("CompareTo() : object is not city");
            City city = (City)obj; // unboxing
            // num 1
            /*if(this.population < city.population)
                return -1;
            if (this.population > city.population)
                return 1;
            return 0;*/

            // num 2
            //return this.population - city.population;

            // num 3
            return this.population.CompareTo(city.population);
        }

        public int CompareTo(City other)
        {
            Console.WriteLine("CompareTo");
            return this.population.CompareTo(other.population);
        }
    }

    struct ComparerByName : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    struct ComparerByNameDesc : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}
