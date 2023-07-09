using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class PhieuNhapThietBi
    {
        private int maphieunhap;

        private DateTime ngaynhap;

        private int manhanvien;

        private string tennhanvien;

        private int madonvi;

        private string tendonvi;

        private float tongtien;

        private string ghichu;

        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhieuNhapThietBi(int maphieunhap, DateTime ngaynhap, int manhanvien, string tennhanvien, int madonvi, string tendonvi, float tongtien, string ghichu)
        {
            this.Maphieunhap = maphieunhap;
            this.Ngaynhap = ngaynhap;
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Tongtien = tongtien;
            this.Ghichu = ghichu;
        }

        public PhieuNhapThietBi(DataRow row)
        {
            this.Maphieunhap = (int)row["maphieunhap"];
            this.Ngaynhap = (DateTime)row["ngaynhap"];
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Tongtien = (float)Convert.ToDouble(row["tongtien"].ToString());
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
