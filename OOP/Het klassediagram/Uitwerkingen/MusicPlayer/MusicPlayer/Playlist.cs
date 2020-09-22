using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Playlist
    {
        private string Name;
        public List<Song> Songs { get; private set; }
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<Song>();
        }
        public void Add(Song song)
        {
            Songs.Add(song);
        }
        public void Add(List<Song> songs)
        {
            Songs = songs;
        }
        public void Remove(Song song)
        {
            Songs.Remove(song);
        }
        public override string ToString()
        {
            return Name + " it has " + Songs.Count + " songs";
        }
    }
}
