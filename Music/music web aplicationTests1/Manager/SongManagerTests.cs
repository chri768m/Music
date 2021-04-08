using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music;
using music_web_aplication.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace music_web_aplication.Manager.Tests
{
    [TestClass()]
    public class SongManagerTests
    {
        private SongManager Manager = new SongManager();
        [TestMethod()]
        public void getallTest()
        {
            List<Song> Songs = Manager.getAll();
            Assert.AreEqual(3, Songs.Count);

        }
        //[TestMethod()]
        //public void addTest(Song newSong)
        //{
        //    string Title = "addtest";
        //    string Artist = "afafawfaw";
        //    int Duration = 10;
        //    int Yop = 2000;
        //    Song newsong = new Song(Title, Artist, Duration, Yop);
        //    List<Song> Songs = Manager.Add(newsong);
        //}
        [TestMethod()]
        public void addTest(Song newSong)
        {

            SongManager Manager = new SongManager();
            new Song { Title = "Øller1", Artist = "1212", Duration = 5, YOP = 1992 };

        }
    }
}