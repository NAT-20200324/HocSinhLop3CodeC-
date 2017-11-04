using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinhLop3_KTPM_
{
    public class XuLyThongTinChung
    {
        public XuLyThongTinChung() { }
        public bool textBoxCoDau(string txtString)//chi cho nhap ki tu chu thuong(hoa), so va dau cham. ko duoc nhap ki tu dac biet abc
        {
            char[] txtArray = txtString.ToCharArray();
            for (int i = 0; i < txtString.Length; i++)
            {
                if (txtArray[i] < 'a' || txtArray[i] > 'z')
                {
                    if (txtArray[i] != '.' && txtArray[i]<'0' || txtArray[i] > '9')
                        return false;
                }
            }
            if (txtString.Length < 6 || txtString.Length > 50)
                return false;
            return true;
        }
        public bool textBoxChieuDai100(string txtString)//dia chi
        {
            if (txtString.Length > 100)
                return false;
            return true;
        }
        public bool textBoxChieuDai50(string txtString)//tai khoan mat khau
        {
            if (txtString.Length < 6 || txtString.Length > 50)
                return false;
            return true;
        }
        public bool textBoxChieuDai20(string txtString)
        {
            if (txtString.Length > 20)
                return false;
            return true;
        }
        public bool textBoxIsEmpty(string txtString)
        {
            if (txtString == "")
                return false;
            return true;
        }
        public string VietHoa(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;

            string result = "";

            //lấy danh sách các từ  

            string[] words = s.Split(' ');

            foreach (string word in words)
            {
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }

            }
            return result.Trim();
        }

        public string ChoPhepDangNhap(string taiKhoan, string matKhau)
        {
            //KIEM TRA TAI KHOAN
            if (textBoxCoDau(taiKhoan) == false)
                return "Tài khoản: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự.";
            if (textBoxChieuDai50(taiKhoan) == false)
                return "Tài khoản: Chiều dài phải từ 6 đến 50 ký tự.";


            //KIEM TRA MAT KHAU
            if (textBoxCoDau(matKhau) == false)
                return "Mật khẩu: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự.";
            if (textBoxChieuDai50(matKhau) == false)
                return "Mật khẩu: Chiều dài phải từ 6 đến 50 ký tự.";

            return "";
        }

        public string ChoPhepDangKy(string taiKhoan, string matKhau,
            string nhapLaiMatKhau, string ho, string ten, DateTime ngaySinh, string maLop, string vaiTro, string tenDem, string diaChi, string dienThoai)
        {
            //KIEM TRA TAI KHOAN
            if (textBoxCoDau(taiKhoan) == false)
                return "Tài khoản: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự.";
            if (textBoxChieuDai50(taiKhoan) == false)
                return "Tài khoản: Chiều dài phải từ 6 đến 50 ký tự.";


            //KIEM TRA MAT KHAU
            if (textBoxCoDau(matKhau) == false)
                return "Mật khẩu: Vui lòng chỉ sử dụng chữ cái (a-z), số và dấu chấm.\nChiều dài phải từ 6 đến 50 ký tự.";
            if (textBoxChieuDai50(matKhau) == false)
                return "Mật khẩu: Chiều dài phải từ 6 đến 50 ký tự.";

            //KIEM TRA NHAP LAI MAT KHAU
            if (matKhau != nhapLaiMatKhau)
                return "Nhập lại mật khẩu không đúng.";

            //KIEM TRA LỚP
            if (textBoxIsEmpty(maLop) == false)
                return "Lớp: Chưa chọn.";

            //KIEM TRA HỌ
            if (textBoxIsEmpty(ho) == false)
                return "Họ: Chưa nhập.";
            if (textBoxChieuDai20(ho) == false)
                return "Họ: Chiều dài phải bé hơn hoặc bằng 20.";

            //KIEM TRA TÊN
            if (textBoxIsEmpty(ten) == false)
                return "Tên: Chưa nhập.";
            if (textBoxChieuDai20(ten) == false)
                return "Tên: Chiều dài phải bé hơn hoặc bằng 20.";

            //KIEM TRA NGAY SINH
            if (vaiTro == "Gv")
            {
                if (DateTime.Now.Year - ngaySinh.Year < 22 || DateTime.Now.Year - ngaySinh.Year > 65)
                    return "Năm sinh: Không hợp lệ(từ 22 đến 65 tuổi).";
            }

            if (vaiTro == "Hs")
            {
                if (DateTime.Now.Year - ngaySinh.Year < 6 || DateTime.Now.Year - ngaySinh.Year > 13)
                    return "Năm sinh: Không hợp lệ(từ 6 đến 13 tuổi).";
            }

            //KIEM TRA TEN DEM (CHO NULL)
            if (textBoxChieuDai20(tenDem) == false)
                return "Tên đệm: Chiều dài phải bé hơn hoặc bằng 20.";

            //KIEM TRA DIA CHI (CHO NULL)
            if (textBoxChieuDai100(diaChi) == false)
                return "Địa chỉ: Chiều dài phải bé hơn hoặc bằng 100.";

            //KIEM TRA DIEN THOAI (CHO NULL)
            if (textBoxChieuDai20(dienThoai) == false)
                return "Điện thoại: Chiều dài phải bé hơn hoặc bằng 20.";

            //HOÀN THÀNH KIỂM TRA
            return "";
        }
    }
}
