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

namespace HocSinhLop3_KTPM_
{
    public partial class FrmDangNhap : Form
    {
        XuLyThongTinChung x = null;
        DataSql data = null;
        private string table = null;
        public delegate void delPass(string taiKhoan);

        public void funTable(string ft)
        {
            this.table = ft;
        }

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhapGv_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            x = new XuLyThongTinChung();
            data = new DataSql();
            string taiKhoan = txtTaiKhoan.Text.ToLower();
            string matKhau = txtMatKhau.Text.ToLower();
            if (x.ChoPhepDangNhap(taiKhoan, matKhau) != "")
                MessageBox.Show(x.ChoPhepDangNhap(taiKhoan, matKhau));
            else if(table == "DangNhapGv")
            {
                int kq = data.KiemTraDangNhap(taiKhoan, matKhau, table);
                if (kq == 0)
                {
                    frmGiaoVien frm = new frmGiaoVien();
                    frm.Show();
                    delPass del = new delPass(frm.funData);
                    del(taiKhoan);
                    this.Close();
                }
                else if (kq == 1)
                    MessageBox.Show("Mật khẩu không chính xác.");
                else MessageBox.Show("Tài khoản không tồn tại");
            }
            else if (table == "DangNhapHs")
            {
                int kq = data.KiemTraDangNhap(taiKhoan, matKhau, table);
                if (kq == 0)
                {
                    frmHocSinh frm = new frmHocSinh();
                    delPass del = new delPass(frm.funData);
                    del(taiKhoan);
                    frm.Show();
                    this.Close();
                }
                else if (kq == 1)
                    MessageBox.Show("Mật khẩu không chính xác.");
                else MessageBox.Show("Tài khoản không tồn tại");
            }
        }
    }
}
