using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinhLop3_KTPM_
{
    public partial class frmMenu : Form
    {
        private string mkDkyGv = "281017";
        public frmMenu()
        {
            InitializeComponent();
        }

        public delegate void delPass(string ft);

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void btDkyGv_Click(object sender, EventArgs e)
        {
            if (txtMkhauDkyGv.Text != mkDkyGv)
                MessageBox.Show("Nhập mật khẩu để đăng ký.");
            else {
                new frmDkyGv().Show();
            }
        }

        private void btDkyHs_Click(object sender, EventArgs e)
        {
            new frmDkyHs().Show();
        }

        private void btDnhapGv_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            delPass del = new delPass(frm.funTable);
            frm.Show();
            del("DangNhapGv");
        }

        private void btDnhapHs_Click(object sender, EventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            delPass del = new delPass(frm.funTable);
            frm.Show();
            del("DangNhapHs");
        }

    }
}
