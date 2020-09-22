using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MusicPlayerTests
{
    using MusicPlayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.ExceptionServices;

    [TestClass]
    public class MusicPlayerTest
    {
        [TestMethod]
        public void AddArtistTest()
        {
            // Arrange
            DateTime birthday = new DateTime(2020, 12, 9);
            Artist hans = new Artist("Hans", birthday);
            MusicPlayer player = new MusicPlayer();
            List<Artist> expected = new List<Artist>();
            expected.Add(hans);

            // Act
            player.Add(hans);

            // Assert

            CollectionAssert.AreEqual(expected, player.Artists);
        }

        [TestMethod]
        public void AddSongTest()
        {
            // Arrange
            DateTime birthday = new DateTime(2020, 12, 9);
            Artist hans = new Artist("Hans", birthday);
            string path = @"C:\Users\joeyo\OneDrive\Music";
            Song song = new Song("Test", 2020, hans, path);
            MusicPlayer player = new MusicPlayer();
            List<Song> expected = new List<Song>();
            expected.Add(song);

            // Act
            player.Add(song);

            // Assert

            CollectionAssert.AreEqual(expected, player.Songs);
        }

        [TestMethod]
        public void AddPlaylistTest()
        {
            // Arrange
            MusicPlayer player = new MusicPlayer();
            Playlist playlist = new Playlist("TestList");
            List<Playlist> expected = new List<Playlist>();
            expected.Add(playlist);

            // Act
            player.Add(playlist);

            // Assert

            CollectionAssert.AreEqual(expected, player.Playlists);
        }

        [TestMethod]
        public void RemoveSongTest()
        {
            // Arrange
            MusicPlayer player = new MusicPlayer();
            DateTime birthday = new DateTime(2020, 12, 9);
            Artist hans = new Artist("Hans", birthday);
            string path = @"C:\Users\joeyo\OneDrive\Music";
            Song song = new Song("Test", 2020, hans, path);
            List<Song> expected = new List<Song>();
            player.Add(song);

            // Act
            player.Remove(song);

            // Assert

            CollectionAssert.AreEqual(expected, player.Songs);
        }
        [TestMethod]
        public void RemovePlaylistTest()
        {
            // Arrange
            MusicPlayer player = new MusicPlayer();
            Playlist playlist = new Playlist("Test");
            List <Playlist> expected = new List<Playlist>();
            player.Add(playlist);

            // Act
            player.Remove(playlist);

            // Assert

            CollectionAssert.AreEqual(expected, player.Playlists);
        }
        [TestMethod]
        public void IsPlayingTest()
        {
            // Arrange
            MusicPlayer player = new MusicPlayer();
            DateTime birthday = new DateTime(2020, 12, 9);
            Artist hans = new Artist("Hans", birthday);
            string path = @"C:\Users\joeyo\OneDrive\Music";
            Song expected = new Song("Test", 2020, hans, path);
            player.CurrentSong = expected;

            // Act
            Song actual = player.IsPlaying();

            // Assert

            Assert.AreEqual(expected, actual);
        }
        public void StopPlayingTest()
        {
            // Arrange
            MusicPlayer player = new MusicPlayer();
            DateTime birthday = new DateTime(2020, 12, 9);
            Artist hans = new Artist("Hans", birthday);
            string path = @"C:\Users\joeyo\OneDrive\Music";
            Song song = new Song("Test", 2020, hans, path);
            player.CurrentSong = song;
            Song expected = null;

            // Act
            player.StopPlaying();

            // Assert

            Assert.AreEqual(expected, player.CurrentSong);
        }
    }
}
