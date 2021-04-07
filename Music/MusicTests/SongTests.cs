using Microsoft.VisualStudio.TestTools.UnitTesting;
using Music;
using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Tests
{
    [TestClass()]
    public class SongTests
    {
        private Song song = new Song(1, "sejre", "tomle", 20, 2005);
        [TestMethod()]
        public void TitleTest()
        {
            song.Title = "ikill";
            Assert.AreEqual(expected: "ikill", actual: song.Title);
            Assert.ThrowsException<ArgumentException>(() => song.Title = "e");
        }
        public void ArtistTest()
        {
            song.Artist = "1234";
            Assert.AreEqual(expected: "1234", actual: song.Artist);
            Assert.ThrowsException<ArgumentException>(() => song.Artist ="e");
        }
        public void DuratationTest()
        {
            song.Duration = 19;
            Assert.AreEqual(expected: 19, actual: song.Duration);
            Assert.ThrowsException<ArgumentException>(() => song.Duration = 21);
        }
        public void YOPTest()
        {
            song.YOP = 2012;
            Assert.AreEqual(expected: 2012, actual: song.YOP);
            Assert.ThrowsException<ArgumentException>(() => song.YOP = 1899);
        }
    }
}