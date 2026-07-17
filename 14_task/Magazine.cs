using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _14_task
{
    public class Magazine
    {
        public string Name { get; set; }
        public string NamePublishing{ get; set; }

        public DateTime Date { get; set; }

        public int Pages { get; set; }

        public void FillMagazine()
        {
            Console.WriteLine($"Enter name magazine ");
            Name = Console.ReadLine();
            Console.WriteLine($"Enter namePublishing ");
            NamePublishing = Console.ReadLine();
            Console.WriteLine($"Enter Date ");
            Date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Enter count Pages ");
            Pages = int.Parse(Console.ReadLine());
        }
        public void PrintMagazine()
        {
            Console.WriteLine($"Name magazine --> {Name}");
            Console.WriteLine($"Name Publishe --> {NamePublishing}");
            Console.WriteLine($"Date          --> {Date}");
            Console.WriteLine($"Count Pages   --> {Pages}");
        }

        public void SerializationMagazine()
        {
            string Fname = "Magazine.xml";

            XmlSerializer xs = new XmlSerializer(typeof(Magazine));
            using(FileStream fs = new FileStream(Fname, FileMode.Create))
            {
                xs.Serialize(fs, this);
            }

        }

        public void DeserializationMagazine()
        {
            string Fname = "Magazine.xml";
            XmlSerializer xsL = new XmlSerializer(typeof(Magazine));


            using (TextReader tr = new StreamReader(Fname))
            {
                var magazine = xsL.Deserialize(tr) as Magazine;

                Console.WriteLine($"Recoverd");

                magazine.PrintMagazine();
            }
        }
    }
}
