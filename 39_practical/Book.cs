using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_practical
{
    internal class Book
    {
        public enum Genre {  historical,horror }
        public string NameBook { get; set; }

        public string Author { get; set; }

        public Genre Genres { get; set; }

        public int CountPapers { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Name book --> {NameBook}\nAuthor --> {Author}\nGenre --> {Genres}\nCount papers --> {CountPapers}\n Year --> {Year}";
        }

    }
}
