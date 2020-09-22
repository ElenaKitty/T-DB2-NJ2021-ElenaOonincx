using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private MusicPlayer player;
        public Form1()
        {
            InitializeComponent();
            player = new MusicPlayer();
        }
        //Add buttons
        private void addSongButton_Click(object sender, EventArgs e)
        {
            string[] fullPaths = null;
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            file.Filter = "(*.mp3)|*.mp3";
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.FileNames != null)
                {
                    fullPaths = file.FileNames;
                }
            }
            int i = 0;
            foreach (string fullPath in fullPaths)
            {
                int songFound = 0;
                int artistFound = 0;
                string path = fullPath.Substring(0, fullPath.LastIndexOf(@"\"));
                string title = fullPath.Substring(fullPath.LastIndexOf(@"\") + 1, fullPath.IndexOf('.') - fullPath.LastIndexOf(@"\"));
                string artistName = title.Substring(0, title.IndexOf('-'));
                DateTime birthday = new DateTime(2020, 12, 9);
                Artist artist = new Artist(artistName, birthday);
                string songName = fullPath.Substring(fullPath.IndexOf('-') + 1, fullPath.IndexOf('.') - fullPath.IndexOf('-') - 1);

                Song song = new Song(songName, 000, artist, fullPath);

                for (int j = 0; j < player.Songs.Count; j++)
                {
                    if (player.Songs[j].Name == song.Name)
                    {
                        songFound++;
                    }
                }
                if(songFound == 0)
                {
                    songListBox.Items.Add(song);
                    player.Songs.Add(song);
                    for (int j = 0; j < player.Artists.Count; j++)
                    {
                        if (player.Artists[j].Name == artist.Name)
                        {
                            artistFound++;
                        }
                    }
                    if (artistFound == 0)
                    {
                        artistListBox.Items.Add(artist);
                        player.Artists.Add(artist);
                    }  
                }
                else
                {
                    MessageBox.Show("This song has already been added");
                }
                i++;
            }
        }
        private void addPlaylistBtn_Click(object sender, EventArgs e)
        {
            if (songListBox.SelectedItems != null)
            {
                using (PlaylistForm playForm = new PlaylistForm())
                {
                    if (playForm.ShowDialog() == DialogResult.OK)
                    {
                        Playlist playlist = new Playlist(playForm.playlistName);
                        for (int i = 0; i < songListBox.SelectedItems.Count; i++)
                        {
                            playlist.Add((Song)(songListBox.SelectedItems[i]));
                        }
                        player.Playlists.Add(playlist);
                        playListBox.Items.Add(playlist);           
                    }
                }
            }
        }

        //Control buttons
        private void playBtn_Click(object sender, EventArgs e)
        {
            if (songListBox.SelectedItem != null)
            { 
                player.Play((Song)(songListBox.SelectedItem));
                songLbl.Text = songListBox.SelectedItem.ToString(); 
            }
            else if(playListBox.SelectedItem != null)
            {
                Playlist list = (Playlist)playListBox.SelectedItem;
                player.Play(list.Songs[0]);
                songLbl.Text = list.Songs[0].ToString();
            }
            else
            {
                MessageBox.Show("Please select a song to play");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.StopPlaying();
            songLbl.Text = "No song playing";
        }

        //Remove buttons
        private void removeSongBtn_Click(object sender, EventArgs e)
        {
            if(songListBox.SelectedItem != null)
            {
                songListBox.Items.RemoveAt(songListBox.SelectedIndex);
                player.Remove((Song)(songListBox.SelectedItem));
            }
            else
            {
                MessageBox.Show("Please select a song to remove");
            }
            
        }
        private void removePlaylistBtn_Click(object sender, EventArgs e)
        {
            player.Remove((Playlist)(playListBox.SelectedItem));
            playListBox.Items.Clear();
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            int maxIndex = songListBox.Items.Count;
            Random rnd = new Random();
            int number = rnd.Next(0, maxIndex);

            player.Play((Song)(songListBox.Items[number]));
            songLbl.Text = songListBox.Items[number].ToString();
        }
    }
}