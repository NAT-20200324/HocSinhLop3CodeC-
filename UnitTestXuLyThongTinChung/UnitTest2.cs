using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HocSinhLop3_KTPM_;

namespace UnitTestXuLyThongTinChung
{
    [TestClass]
    public class UnitTest2
    {
        private calculation c = null;
        [TestInitialize]
        public void SetUp()
        {
            c = new calculation(5, 6);
        }
        [TestMethod]
        public void TestCong()
        {
            Assert.AreEqual(c.tinhToan("+"), 11);
        }
        [TestMethod]
        public void TestTru()
        {
            Assert.AreEqual(c.tinhToan("-"), -1);
        }
        [TestMethod]
        public void TestNhan()
        {
            Assert.AreEqual(c.tinhToan("*"), 30);
        }
        [TestMethod]
        public void TestChia()
        {
            Assert.AreEqual(c.tinhToan("/"), 0);
        }
    }
}
