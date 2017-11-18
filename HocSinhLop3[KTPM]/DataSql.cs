using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HocSinhLop3_KTPM_
{
    public class DataSql
    {
        public DataSql() { }
        private string cnStr = "Server = .; Database = QLHocSinhLop3; Integrated Security = true;";
        private SqlDataAdapter da = null;
        private DataTable dt = null;
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        //private string cnStr = ConfigurationManager.ConnectionStrings["HocSinhLop3_KTPM_.Properties.Settings.QLHocSinhLop3ConnectionString"].ConnectionString;
        public DataTable getData(string table)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(table, cnStr);
            da.Fill(dt);
            return dt;
        }

        public void InsertHuman(string Tkhoan, string Mkhau, string Ho, string Ten, DateTime Nsinh, string maLop, string table, string Tdem, string Dchi, string Dthoai)
        {
            Dt = getData(table);
            DataRow dr = Dt.NewRow();
            dr["TaiKhoan"] = Tkhoan;
            dr["MatKhau"] = Mkhau;
            dr["Ho"] = Ho;
            dr["Ten"] = Ten;
            dr["NgaySinh"] = Nsinh;
            if (table == "SELECT * FROM GiaoVien")
            {
                dr["MaLop"] = maLop;
            }
            dr["TenDem"] = Tdem;
            dr["DiaChi"] = Dchi;
            if (table == "SELECT * FROM HocSinh")
                dr["dtPhuHuynh"] = Dthoai;
            else
                dr["DienThoai"] = Dthoai;
            Dt.Rows.Add(dr);

            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(Dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch(ConfigurationErrorsException ex)
            {
                throw ex;
            }
        }

        public void InsertDanhSach(string maLop, string taiKhoan, string nienKhoa)
        {
            Dt = getData("SELECT * FROM DanhSachHocSinh");
            DataRow dr = dt.NewRow();
            dr["MaLop"] = maLop;
            dr["TaiKhoan"] = taiKhoan;
            dr["NienKhoa"] = nienKhoa;
            Dt.Rows.Add(dr);

            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(Dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
        }

        public void InsertBaiTap(string taiKhoan, string c1, string c2, string c3, string c4, string c5, string c6, string c7, string c8, string c9, string c10, DateTime batDau, DateTime ketThuc)
        {
            Dt = getData("SELECT * FROM LichSuLamBai");
            DataRow dr = dt.NewRow();
            dr["TaiKhoan"] = taiKhoan;
              dr["Cau1"] = c1;
              dr["Cau2"] = c2;
              dr["Cau3"] = c3;
              dr["Cau4"] = c4;
              dr["Cau5"] = c5;
              dr["Cau6"] = c6;
              dr["Cau7"] = c7;
              dr["Cau8"] = c8;
              dr["Cau9"] = c9;
              dr["Cau10"] = c10;
              dr["BatDau"] = batDau;
              dr["KetThuc"] = ketThuc;
              dr["GhiChu"] = "";
              dt.Rows.Add(dr);
              try
              {
                  SqlCommandBuilder cb = new SqlCommandBuilder(da);
                  da.Update(Dt);
              }
              catch (SqlException ex)
              {
                  throw ex;
              }
              catch (InvalidOperationException ex)
              {
                  throw ex;
              }
              catch (ConfigurationErrorsException ex)
              {
                  throw ex;
              }
        }

        public int KiemTraDangNhap(string taiKhoan, string matKhau, string table)
        {
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand(table, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taikhoan", taiKhoan));
            cmd.Parameters.Add(new SqlParameter("@matKhau", matKhau));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            int kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq;
        }

        public void DanhSachLop(string taiKhoan)
        {
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("DanhSachLop", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taiKhoan", taiKhoan));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public int XemLichSuLamBai(string taiKhoan)
        {
            int kq = 0;
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("XemLichSuLamBai", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taiKhoan", taiKhoan));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq;
        }

        public int XemThongTin(string taiKhoan)
        {
            int kq = 0;
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("XemThongTin", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taiKhoan", taiKhoan));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq;  //HOÀN CHỈNH
        }

        public int XemLichSuLamBaiTheoMaLop(string maLop)
        {
            int kq = 0;
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("XemLichSuLamBaiTheoMaLop", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maLop",maLop));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq; //HOÀN CHỈNH
        }

        public void DanhSachHsKhongLamBt(string taiKhoan) //TAI KHOAN CUA GIAO VIEN
        {
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("DanhSachHsKhongLamBt", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taiKhoan", taiKhoan));
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public int UpGhiChu(int maBaiTap, string ghiChu)
        {
            int kq = 0;
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("UpGhiChu", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maBaiTap", maBaiTap));
            cmd.Parameters.Add(new SqlParameter("@ghiChu", ghiChu));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq;
        }

        public int KiemTraTruocKhiNhanXet(string taiKhoan, int maBaiTap)
        {
            int kq = 0;
            cnn = new SqlConnection(cnStr);
            cmd = new SqlCommand("KiemTraTruocKhiNhanXet", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@taiKhoan", taiKhoan));
            cmd.Parameters.Add(new SqlParameter("@maBaiTap", maBaiTap));
            cmd.Parameters.Add(new SqlParameter("@bool", SqlDbType.Int, 100));
            cmd.Parameters["@bool"].Direction = System.Data.ParameterDirection.Output;
            cnn.Open();
            cmd.Parameters["@bool"].Value = 0;
            cmd.ExecuteNonQuery();
            kq = Int32.Parse(cmd.Parameters["@bool"].Value.ToString());
            cnn.Close();
            return kq;
        }
    }
}
