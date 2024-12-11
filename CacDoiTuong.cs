using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NVL_MonAn
{
    class TaiKhoan
    {
        public static string maTK;
        private string tenDangNhap;
        private string chucVu;
        private string ten;
        private string anh;

        public TaiKhoan()
        {
            this.tenDangNhap = "guestuser";
            this.ten = "Khách";
            this.chucVu = "Khách";
            this.Anh = "";
        }

        public TaiKhoan(string tenDangNhap, string chucVu, string ten, string anh)
        {
            this.tenDangNhap = tenDangNhap;
            this.chucVu = chucVu;
            this.ten = ten;
            this.anh = anh;
        }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Anh { get => anh; set => anh = value; }
    }
    class ThongTin
    {
        private string ten;
        private string anh;
        private int gia;

        public string Ten { get => ten; set => ten = value; }
        public string Anh { get => anh; set => anh = value; }
        public int Gia { get => gia; set => gia = value; }
    }
    class MonAn : ThongTin
    {
        private string maMA;
        private int soLuong;

        public MonAn(string maMA, string ten, string anh, int gia, int soLuong)
        {
            this.maMA = maMA;
            this.Ten = ten;
            this.Anh = anh;
            this.Gia = gia;
            this.soLuong = soLuong;
        }

        public string MaMA { get => maMA; set => maMA = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
    class NguyenVatLieu : ThongTin
    {
        private string maNVL;
        private float trongLuong;

        public NguyenVatLieu(string maNVL, string ten, string anh, int gia, float trongLuong)
        {
            this.maNVL = maNVL;
            this.Ten = ten;
            this.Anh = anh;
            this.Gia = gia;
            this.trongLuong = trongLuong;
        }
        public string MaNVL { get => maNVL; set => maNVL = value; }
        public float TrongLuong { get => trongLuong; set => trongLuong = value; }
    }
    class ThanhPhan
    {
        private string maTP;
        private string maMA;
        private string maNVL;

        public ThanhPhan(string maTP, string maMA, string maNVL)
        {
            this.maTP = maTP;
            this.maMA = maMA;
            this.maNVL = maNVL;
        }

        public string MaTP { get => maTP; set => maTP = value; }
        public string MaMA { get => maMA; set => maMA = value; }
        public string MaNVL { get => maNVL; set => maNVL = value; }
    }
}
