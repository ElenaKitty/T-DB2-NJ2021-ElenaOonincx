using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Artist
    {
        public string Name { get; private set; }
        public DateTime BirthDay { get; private set; }
        private List<Song> createdSongs;
        public Artist(string name, DateTime birthday)
        {
            Name = name;
            BirthDay = birthday;
            createdSongs = new List<Song>();
        }
        public void Add(Song song)
        {
            createdSongs.Add(song);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
