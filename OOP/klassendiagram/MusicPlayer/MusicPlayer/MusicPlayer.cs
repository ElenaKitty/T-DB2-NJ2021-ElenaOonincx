using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public class MusicPlayer
    {
        public Song CurrentSong;
        public  List<Artist> Artists;
        public  List<Song> Songs;
        public  List<Playlist>Playlists;
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        public MusicPlayer()
        {
            CurrentSong = null;
            Songs = new List<Song>();
            Artists = new List<Artist>();
            Playlists = new List<Playlist>();
        }
        public void Add(Artist artist)
        {
            Artists.Add(artist);
        }
        public void Add(Song song)
        {
            Songs.Add(song);
        }
        public void Add(Playlist playlist)
        {
            Playlists.Add(playlist);
        }
        public void Remove(Song song)
        { 
            Songs.Remove(song);
        }
        public void Remove(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }
        public void Play(Song song)
        {
            player.URL = song.PathToFile ;
            player.controls.play();

            CurrentSong = song;
        }
        public void Play(Playlist playlist)
        {
            player.URL = playlist.Songs[0].PathToFile;
            player.controls.play();

            CurrentSong = playlist.Songs[0];

        }
        public Song IsPlaying()
        {
            return CurrentSong;
        }
        public void StopPlaying()
        {
            player.controls.stop();
            CurrentSong = null;
        }
    }
}
