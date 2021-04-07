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
    }
}