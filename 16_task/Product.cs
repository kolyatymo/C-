using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_task
{
    internal class Product
    {
        public int Data { get; set; }

        public int Price { get; set; }

        public string Country { get; set; }

        public string Category { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Date --> {Data}\tPrice --> {Price}\tCountry --> {Country}\tCategory --> {Category}\tProducts --> {Name}";
        }
    }
}
