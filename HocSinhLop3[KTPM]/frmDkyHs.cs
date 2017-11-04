using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HocSinhLop3_KTPM_
{
    public partial class frmDkyHs : Form
    {
        XuLyThongTinChung x = null;
        public frmDkyHs()
        {
            InitializeComponent();
        }

        private void frmDkyHs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHocSinhLop3DataSet1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLHocSinhLop3DataSet1.Lop);
            int x = Int32.Parse(DateTime.Now.Year.ToString());
            int y = Int32.Parse(DateTime.Now.Year.ToString()) + 1;
            txtNkhoa.Text = x + "-" + y;
        }

        private void btDKyHs_Click(object sender, EventArgs e)
        {
            x = new XuLyThongTinChung();
            string taiKhoan = txtDkyTkhoanHs.Text.ToLower();
            string matKhau = txtDkyMkhauHs.Text.ToLower();
            string nhapLaiMatKhau = txtDkyNlaiMkhauHs.Text.ToLower();
            string tenLop = cbLopHoc.Text;
            string maLop = cbLopHoc.SelectedValue.ToString();
            string ho = x.VietHoa(txtDkyHoHs.Text);
            string ten = x.VietHoa(txtDkyTenHs.Text);
            string tenDem = x.VietHoa(txtDkyTdemHs.Text);
            string diaChi = x.VietHoa(txtDchiHs.Text);
            string dienThoaiPhuHuynh = txtDthoaiPhuynhHs.Text;
            string nienKhoa = txtNkhoa.Text;
            dtNsinhHs.Format = DateTimePickerFormat.Custom;
            dtNsinhHs.CustomFormat = "dd/MM/yyyy";
            DateTime ngaySinh = dtNsinhHs.Value;

            if (x.ChoPhepDangKy(taiKhoan, matKhau, nhapLaiMatKhau, ho, ten,ngaySinh, maLop, "Hs", tenDem, diaChi, dienThoaiPhuHuynh) != "")
            {
                MessageBox.Show(x.ChoPhepDangKy(taiKhoan, matKhau, nhapLaiMatKhau, ho, ten, ngaySinh, maLop, "Hs", tenDem, diaChi, dienThoaiPhuHuynh));
            }
            else
            {
                string table = "SELECT * FROM HocSinh";
                DataSql data = new DataSql();
                try
                {
                    data.InsertHuman(taiKhoan, matKhau, ho, ten, ngaySinh, maLop, table, tenDem, diaChi, dienThoaiPhuHuynh);
                    MessageBox.Show("Thông tin \n" + "Tài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\nLớp: " + tenLop + "\nHọ: " + ho + "\nTên: " + ten + "\nNgày sinh: " + ngaySinh.ToString() + "\nTên đệm: " + tenDem + "\nĐịa chỉ: " + diaChi + "\nĐiện thoại: " + dienThoaiPhuHuynh + "\nNiên khoá: " + nienKhoa);
                    data.InsertDanhSach(maLop, taiKhoan, nienKhoa);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: Tài khoản đã tồn tại.\n" + ex);
                }
            }
        }
    }
}
