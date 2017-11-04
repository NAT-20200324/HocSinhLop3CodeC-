using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinhLop3_KTPM_
{
    public class calculation
    {
        private int nhapso1;
        private int nhapso2;

        public calculation(int nhapso1, int nhapso2)
        {
            this.nhapso1 = nhapso1;
            this.nhapso2 = nhapso2;
        }
        public int tinhToan(string dau)
        {
            int kq = 0;
            switch (dau)
            {
                case "+": kq = nhapso1 + nhapso2; break;
                case "-": kq = nhapso1 - nhapso2; break;
                case "*": kq = nhapso1 * nhapso2; break;
                case "/": kq = nhapso1 / nhapso2; break;
            }
            return kq;
            //KHÔNG CẦN KIỂM TRA CHIA CHO KHÔNG VÌ KHI RANDOM TRONG PHÉP CHIA KHÔNG CÓ SỐ KHÔNG.
        }
    }
}
