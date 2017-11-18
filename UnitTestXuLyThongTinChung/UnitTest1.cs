using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HocSinhLop3_KTPM_;

namespace UnitTestXuLyThongTinChung
{
    [TestClass]
    public class UnitTest1
    {
        private XuLyThongTinChung x = new XuLyThongTinChung();

        [TestMethod]
        public void TestTextBoxCoDau()
        {
            Assert.AreEqual(x.textBoxCoDau("abcdef."), true);
            Assert.AreEqual(x.textBoxCoDau("abcdefé"), false); //có dấu
            Assert.AreEqual(x.textBoxCoDau("abcdef!"), false); //có kí tự đặt biệt
            Assert.AreEqual(x.textBoxCoDau("abc"), false); //bé hơn 6 kí tự
        }
        [TestMethod]
        public void TestTextBoxChieuDai100() //KHONG bi gioi han MIN
        {
            Assert.AreEqual(x.textBoxChieuDai100("abc"), true);
            Assert.AreEqual(x.textBoxChieuDai100("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), true); //100 từ
            Assert.AreEqual(x.textBoxChieuDai100("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), false); //101 từ
        }
        [TestMethod]
        public void TestTextBoxChieuDai50() //CO gioi han MIN (6-50)
        {
            Assert.AreEqual(x.textBoxChieuDai50("abc"), false);
            Assert.AreEqual(x.textBoxChieuDai50("abcdef"), true);
            Assert.AreEqual(x.textBoxChieuDai50("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), true); //50 từ
            Assert.AreEqual(x.textBoxChieuDai50("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), false); //51 từ
        }
        [TestMethod]
        public void TestTextBoxChieuDai20() //KHONG bi gioi han MIN
        {
            Assert.AreEqual(x.textBoxChieuDai20("abc"), true);
            Assert.AreEqual(x.textBoxChieuDai20("aaaaaaaaaaaaaaaaaaaa"), true); //20 từ
            Assert.AreEqual(x.textBoxChieuDai20("aaaaaaaaaaaaaaaaaaaaa"), false); //21 từ
        }
        [TestMethod]
        public void TestTextBoxIsEmpty()
        {
            Assert.AreEqual(x.textBoxIsEmpty(""), false);
            Assert.AreEqual(x.textBoxIsEmpty("a"), true);
        }
        [TestMethod]
        public void TestVietHoa() // su dung cho ho, ten, ten dem
        {
            Assert.AreEqual(x.VietHoa("đoàn tài"), "Đoàn Tài");
        }
        [TestMethod]
        public void TestChoPhepDangNhap() // su dung cho ho, ten, ten dem
        {
            Assert.AreEqual(x.ChoPhepDangNhap("abcdef!", "abcdef"), "Tài khoản: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự."); //Tai khoan FALSE
            Assert.AreEqual(x.ChoPhepDangNhap("abcdef", "abcdef!"), "Mật khẩu: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự."); //Mat khau FALSE
            Assert.AreEqual(x.ChoPhepDangNhap("abcdef", "abcdef"), ""); //TRUE
        }
    }
}
