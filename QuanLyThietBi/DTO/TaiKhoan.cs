using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class TaiKhoan
    {
        private int mataikhoan;

        private string tentaikhoan;

        private string tendangnhap;

        private string matkhau;

        private int manhanvien;

        private string tennhanvien;

        public int Mataikhoan { get => mataikhoan; set => mataikhoan = value; }
        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }

        public TaiKhoan(int mataikhoan, string tentaikhoan, string tendangnhap, string matkhau, int manhanvien, string tennhanvien)
        {
            this.Mataikhoan = mataikhoan;
            this.Tentaikhoan = tentaikhoan;
            this.Tendangnhap = tendangnhap;
            this.Matkhau = matkhau;
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
        }

        public TaiKhoan(DataRow row)
        {
            this.Mataikhoan = (int)row["mataikhoan"];
            this.Tentaikhoan = row["tentaikhoan"].ToString();
            this.Tendangnhap = row["tendangnhap"].ToString();
            this.Matkhau = row["matkhau"].ToString();
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
        }
    }
}
