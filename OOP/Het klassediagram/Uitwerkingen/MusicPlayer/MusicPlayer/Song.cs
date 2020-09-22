using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public string Name { get; private set; }
        private int Year;
        public string PathToFile { get; private set; }
        private string Lyrics;
        private Artist Artist;

        public Song(string name, int year, Artist artist, string pathToFile)
        {
            Name = name;
            Year = year;
            Artist = artist;
            PathToFile = pathToFile;
        }
        public override string ToString()
        {
            return Name + " - " + Artist;
        }
    }
}
