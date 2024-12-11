using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_NVL_MonAn
{
    class ProcessDataBase
    {
        string s = @"Data Source=LAPTOP-QK9EJR95\SQLEXPRESS;Initial Catalog=QL_NVL_MonAn;Integrated Security=True";
        SqlConnection sqlConnect = null;
        public void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(s);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
                sqlConnect.Close();
        }

        public DataTable DocBang(string sqlQuery)
        {
            DataTable t = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnect);
            sqlDataAdapter.Fill(t);
            DongKetNoiCSDL();
            sqlDataAdapter.Dispose();
            return t;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Diff(int a, int b)
        {
            return a - b;
        }

        public static int Pro(int a, int b)
        {
            return a * b;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static string MaHoaMatKhau(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        public bool XacThuc(string tenDangNhap, string password)
        {
            password = MaHoaMatKhau(password);
            KetNoiCSDL();
            SqlDataReader reader = new SqlCommand($"Select * From TaiKhoan Where tenDangNhap = N'{tenDangNhap}'", sqlConnect).ExecuteReader();
            while (reader.Read())
            {
                if (reader["matKhau"].ToString() == password)
                {
                    DongKetNoiCSDL();
                    return true;
                }
            }
            DongKetNoiCSDL();
            return false;
        }

        public TaiKhoan LayThongTin(string tenDangNhap)
        {
            TaiKhoan nguoiDung = new TaiKhoan();
            KetNoiCSDL();
            SqlDataReader reader = new SqlCommand($"Select * From TaiKhoan Where tenDangNhap = N'{tenDangNhap.Trim()}'", sqlConnect).ExecuteReader();
            while (reader.Read())
            {
                TaiKhoan.maTK = reader["tenDangNhap"].ToString();
                nguoiDung = new TaiKhoan(reader["tenDangNhap"].ToString(), reader["chucVu"].ToString(), reader["ten"].ToString(), reader["anh"].ToString());
            }
            DongKetNoiCSDL();
            return nguoiDung;
        }
        public void CapNhatDuLieu(string sqlQuery)
        {
            SqlCommand cm = new SqlCommand();
            KetNoiCSDL();
            cm.Connection = sqlConnect;
            cm.CommandText = sqlQuery;
            cm.ExecuteNonQuery();
            DongKetNoiCSDL();
            cm.Dispose();
        }

        public bool KiemTraLap(string tenBang, string id, string colName)
        {
            DataTable tb = DocBang("Select * from " + tenBang + " where " + colName + " = N\'" + id + "\'");
            bool lap = tb.Rows.Count > 0;
            tb.Dispose();
            return lap;
        }
        public bool KiemTraLap(string tenBang, string val1, string val2, string col1, string col2)
        {
            DataTable tb = DocBang($"Select * from {tenBang} where {col1} = N'{val1}' and {col2} = N'{val2}'");
            bool lap = tb.Rows.Count > 0;
            tb.Dispose();
            return lap;
        }
    }
}
