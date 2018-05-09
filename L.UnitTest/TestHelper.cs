using L.Test.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.UnitTest
{
    [TestClass]
    public class TestHelper
    {
        [TestMethod]
        public void TestReadFile()
        {
            var track = Helper.ReadTrack(@"C:\Users\Admin\Desktop\temp\15 Way Beyond.m4a");
            Assert.IsNotNull(track.TheLoaiId);
        }
    }
}
