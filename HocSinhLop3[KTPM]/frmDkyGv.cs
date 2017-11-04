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
    public partial class frmDkyGv : Form
    {
        XuLyThongTinChung x = null;

        public frmDkyGv()
        {
            InitializeComponent();
        }

        private void frmDkyGv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHocSinhLop3DataSet.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLHocSinhLop3DataSet.Lop);

        }

        private void btDKyGv_Click(object sender, EventArgs e)
        {
            x = new XuLyThongTinChung();
            string taiKhoan = txtDkyTkhoanGv.Text.ToLower();
            string matKhau = txtDkyMkhauGv.Text.ToLower();
            string nhapLaiMatKhau = txtDkyNlaiMkhauGv.Text.ToLower();
            string tenLop = cbLopPtrach.Text;
            string maLop = cbLopPtrach.SelectedValue.ToString();
            string ho = x.VietHoa(txtDkyHoGv.Text);
            string ten = x.VietHoa(txtDkyTenGv.Text);
            string tenDem = x.VietHoa(txtDkyTdemGv.Text);
            string diaChi = x.VietHoa(txtDchiGv.Text);
            string dienThoai = txtDthoaiGv.Text;
            dtNsinhGv.Format = DateTimePickerFormat.Custom;
            dtNsinhGv.CustomFormat = "dd/MM/yyyy";
            DateTime ngaySinh = dtNsinhGv.Value;

            if (x.ChoPhepDangKy(taiKhoan, matKhau, nhapLaiMatKhau, ho, ten, ngaySinh, maLop, "Gv", tenDem, diaChi, dienThoai) != "")
            {
                MessageBox.Show(x.ChoPhepDangKy(taiKhoan, matKhau, nhapLaiMatKhau, ho, ten, ngaySinh, maLop, "Gv", tenDem, diaChi, dienThoai));
            }
            else
            {
                string table = "SELECT * FROM GiaoVien";
                DataSql data = new DataSql();
                try
                {
                    data.InsertHuman(taiKhoan, matKhau, ho, ten, ngaySinh, maLop, table, tenDem, diaChi, dienThoai);
                    MessageBox.Show("Thông tin \n" + "Tài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\nLớp: " + tenLop + "\nHọ: " + ho + "\nTên: " + ten + "\nNgày sinh: " + ngaySinh.ToString() + "\nTên đệm: " + tenDem + "\nĐịa chỉ: " + diaChi + "\nĐiện thoại: " + dienThoai); 

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: Tài khoản đã tồn tại.\n" + ex);
                }
            }
        }
    }
}
