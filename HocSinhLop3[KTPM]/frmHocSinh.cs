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
    public partial class frmHocSinh : Form
    {
        show s = null;
        calculation c = null;
        private int n = 10;
        private int kq = 0;
        private string c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
        private string DorS = "";
        private string taiKhoan = "";
        private int dung = 0;
        private int sai = 0;
        DataSql data = null;

        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = taiKhoan;
            groupBox1.Text = "Xin chào " + taiKhoan;
        }

        public void funData(string tk)
        {
            this.taiKhoan = tk;
        }

        private void btTiepTuc_Click_1(object sender, EventArgs e)
        {
            s = new show();
            DateTime batDau = DateTime.Now;
            DateTime ketThuc = DateTime.Now;
            if (n == 10) //Lớn hơn 11
            {
                DialogResult dlr = MessageBox.Show("Bạn có muốn làm bài tập mới.\n", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    //RESET
                    n = 0;
                    txtSo1.Text = "";
                    txtSo2.Text = "";
                    txtKq.Text = "";
                    txtKq.ReadOnly = false;
                    listBox1.Items.Clear();
                    batDau = DateTime.Now.Date;
                    dung = 0;
                    sai = 0;

                    s.hienThi(txtSo1, txtSo2, lbDau);
                    int x = n + 1;
                    label1.Text = "Câu " + x;
                }
            }
            else if (n < 9)
            {
                if (txtKq.Text == "")
                {
                    MessageBox.Show("Bạn vui lòng điền kết quả.\n");
                }
                else
                {
                    kiemTrakq(n + 1);
                    n += 1;
                    int x = n + 1;
                    label1.Text = "Câu " + x;
                    s.hienThi(txtSo1, txtSo2, lbDau);
                    txtKq.Text = "";
                }
            }
            else if (n == 9) //n==10(đi từ 0)
            {
                kiemTrakq(10);
                txtKq.ReadOnly = true;
                ketThuc = DateTime.Now;
                MessageBox.Show("Bạn vừa hoàn thành xong 1 phần bài tập 10 câu.\nXem lại kết quả đã làm và nhấn tiếp tục để làm bài tập tiếp theo.");
                data = new DataSql();
                data.InsertBaiTap(taiKhoan, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, batDau, ketThuc);
                n += 1;
            }
        }

        private void btXemKq_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đúng: " + dung + " câu.\n" + "Sai: " + sai + " câu.\n" + "Còn lại: " + (10-(dung+sai)) + " câu.\n");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (n <= 9)
            {
                DialogResult dlr = MessageBox.Show("Bạn chưa hoàn thành xong 10 câu, nếu thoát kết quả sẽ không được lưu.", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thoát.", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                    this.Close();
            }
        }

        private void btXemLichSu_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            string tk = textBox1.Text.ToLower();
            if (data.XemThongTin(tk) == 0)
            {
                if(data.XemLichSuLamBai(tk)==0)
                    dataGridView1.DataSource = data.getData("SELECT * FROM TAM");
                else MessageBox.Show("Không có làm bài tập");
            }
            else MessageBox.Show("Không tìm thấy tài khoản."); 
        }

        private void kiemTrakq(int x)
        {
            c = new calculation(int.Parse(txtSo1.Text), int.Parse(txtSo2.Text));
            kq = c.tinhToan(lbDau.Text);
            if (kq == int.Parse(txtKq.Text))
            {
                listBox1.Items.Add("Câu " + x + " ĐÚNG.");
                DorS = "D";
                dung += 1;
            }
            else
            {
                listBox1.Items.Add("Câu " + x + " SAI kết quả đúng là " + kq + ".");
                DorS = "S";
                sai += 1;
            }
            luukq();
        }

        public void luukq()
        {
            switch (n)
            {
                case 0: c1 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 1: c2 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 2: c3 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 3: c4 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 4: c5 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 5: c6 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 6: c7 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 7: c8 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 8: c9 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
                case 9: c10 = DorS + " " + txtSo1.Text + lbDau.Text + txtSo2.Text + "=" + txtKq.Text; break;
            }
        }

        private void btXemThongTin_Click(object sender, EventArgs e)
        {
            data = new DataSql();
            data.XemThongTin(taiKhoan);
            dataGridView1.DataSource = data.getData("SELECT * FROM TAM");
        }
    }
}