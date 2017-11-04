using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocSinhLop3_KTPM_
{
    public class show
    {
        Random rand = new Random();

        private string randomDau()
        {
            int x = rand.Next(4);
            if (x == 0)
                return "+";
            else if (x == 1)
                return "-";
            else if (x == 2)
                return "*";
            else return "/";
        }

        private void randomSoNhan(TextBox txtSo1, TextBox txtSo2)
        {
            txtSo1.Text = rand.Next(20).ToString();
            txtSo2.Text = rand.Next(20).ToString();
        }
        private void randomSoCongTru(TextBox txtSo1, TextBox txtSo2)
        {
            txtSo1.Text = rand.Next(100).ToString();
            txtSo2.Text = rand.Next(100).ToString();
        }
        private void randomChia(TextBox txtSo1, TextBox txtSo2)
        {
            txtSo1.Text = rand.Next(1, 100).ToString();
            txtSo2.Text = rand.Next(1, 100).ToString();
        }

        public void hienThi(TextBox txtSo1, TextBox txtSo2, Label lbDau)
        {
            lbDau.Text = randomDau();
            if (lbDau.Text == "+" || lbDau.Text == "-")
                randomSoCongTru(txtSo1, txtSo2);
            else if (lbDau.Text == "*")
                randomSoNhan(txtSo1, txtSo2);
            else
                randomChia(txtSo1, txtSo2);
        }
    }
}
