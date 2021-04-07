using Microsoft.VisualStudio.TestTools.UnitTesting;
using music_web_aplication.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace music_web_aplication.Manager.Tests
{
    [TestClass()]
    public class SongManagerTests
    {
        [TestMethod()]
        public void getAllTest()
        {
            SongManager manager = new SongManager();
            List =  manager.getAll();
            Assert.Fail();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}