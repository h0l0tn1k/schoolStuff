using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Music
    {
        public string Name { get; private set; }
        public string Author { get; private set;}
        public Rating Rating { get; private set; }
        public Music(string nameOfSong, string author, Rating rating)
        {
            if (nameOfSong == null || author == null)
                throw new ArgumentNullException("argument is null");
            Name = nameOfSong;
            Author = author;
            Rating = rating;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}, Rated:{2}", Author, Name, Rating);
        }
        public string ToPrint()
        {
            return String.Format("{0};{1};{2}", Name, Author, Rating.ToString());
        }
    }
}
