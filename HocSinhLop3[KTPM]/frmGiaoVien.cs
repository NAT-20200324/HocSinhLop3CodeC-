using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HocSinhLop3_KTPM_
{
    public partial class frmGiaoVien : Form
    {
        private string taiKhoanGv, maLopGv;
        private DataSql data = null;
        private DataTable dt = null;
        public void funData(string tk)
        {
            cbTaiKhoan.Text = tk;
            taiKhoanGv = tk;
        }

        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHocSinhLop3DataSet2.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qLHocSinhLop3DataSet2.GiaoVien);
            txtLop.Text = cbTaiKhoan.SelectedValue.ToString();
        }

        private void btDanhSachLop_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            string taiKhoanXemDs = cbTaiKhoan.Text;
            data.DanhSachLop(taiKhoanXemDs);
            dt = data.getData("SELECT * FROM TAM");
            dataGridView1.DataSource = dt;
            txtMaBaiTap.Text = "";
            txtTaiKhoan.Text = "";
            
        }

        private void cbTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLop.Text = cbTaiKhoan.SelectedValue.ToString();
        }

        private void btLichSuLamBai_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            string maLop = cbTaiKhoan.SelectedValue.ToString();
            if (data.XemLichSuLamBaiTheoMaLop(maLop) == 0)
            {
                data.XemLichSuLamBaiTheoMaLop(maLop);
                dt = data.getData("SELECT * FROM TAM");
                dataGridView1.DataSource = dt;
            }
            else if (data.XemLichSuLamBaiTheoMaLop(maLop) == 1)
                MessageBox.Show("Học sinh trong lớp không làm bài tập.");
            else MessageBox.Show("Không tìm thấy mã lớp."); //HOÀN CHỈNH

            /*txtMaBaiTap.DataBindings.Add("Text", dt, "MaBaiTap");
            txtTaiKhoan.DataBindings.Add("Text", dt, "TaiKhoan");
            LỖI: An unhandled exception of type 'System.ArgumentException' occurred in 
            System.Windows.Forms.dll
            Additional information: 
            This causes two bindings in the collection to bind to the same property.*/
        }

        private void txtMaBaiTap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btLuuNhanXet_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            if (txtMaBaiTap.Text == "")
                MessageBox.Show("Nhập mã bài tập cần nhận xét.");
            else if (data.KiemTraTruocKhiNhanXet(taiKhoanGv, Int32.Parse(txtMaBaiTap.Text)) == 1)
                MessageBox.Show("Giáo viên chỉ được nhận xét cho bài tập của học sinh trong lớp mình dạy.");
            else
            {
                int maBaiTap = Int32.Parse(txtMaBaiTap.Text);
                string ghiChu = txtGhiChu.Text;
                if (data.UpGhiChu(maBaiTap, ghiChu) == 0)
                {
                    data.UpGhiChu(maBaiTap, ghiChu);
                    MessageBox.Show("Đã nhận xét cho mã bài tập: " + maBaiTap);
                }
                else MessageBox.Show("Không tìm thấy mã bài tập.");
            }//HOÀN CHỈNH
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            string taiKhoan = txtTaiKhoan.Text.ToLower();
            if (data.XemThongTin(taiKhoan) == 0)
            {
                data.XemLichSuLamBai(taiKhoan);
                dataGridView1.DataSource = data.getData("SELECT * FROM TAM");
            }
            else MessageBox.Show("Không tìm thấy tài khoản.");  //HOÀN CHỈNH
        }

        private void btHsKlBt_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            string tk = cbTaiKhoan.Text;
            data.DanhSachHsKhongLamBt(tk);
            dataGridView1.DataSource = data.getData("SELECT * FROM TAM");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            /*DialogResult dlr = MessageBox.Show("Bạn muốn thoát tài khoản?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
                this.giaoVienTableAdapter.Connection.Close();
            }*/
            MessageBox.Show("Bị lỗi rồi, nhấn nút X đỏ ở trên đi. Tks!");
        }
    }
}
