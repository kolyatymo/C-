using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _35_XML_Serialization
{
    /*
     1. клас має бути паблік для серіалізації
     2. серілізувати можна public поля - властивості
     3. має бути явний конструктор по замовчуванню
     */
    public class Engine
    {
        public double Power { get; set; }
        public Engine(double power)
        {
            this.Power = power;
        }
        public Engine()
            :this(1.0)
        {
            
        }
        public override string ToString()
        {
            return $"Engine power : {Power}";
        }
    }
    public class Car
    {
        //[XmlAttribute()]
        //[XmlAttribute("Number")]
        //[XmlIgnore()]

        public int id;
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }

        public Car(int id, string brand, double power)
        {
            this.id = id;
            Brand = brand;
            Engine = new Engine(power);
        }

        public Car()
            :this(1,"Nobrand",1.0){}

        public override string ToString()
        {
            return $"Id {id}. \t Car brand {Brand} \t {Engine}";
        }
    }
}
