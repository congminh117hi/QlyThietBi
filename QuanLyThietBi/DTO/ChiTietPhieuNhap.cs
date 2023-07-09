using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class ChiTietPhieuNhap
    {
        private int machitietphieunhap;

        private int maphieunhap;

        private int mathietbisudung;

        private string tenthietbi;

        private float dongianhap;

        private int soluongnhap;

        private float thanhtiennhap;

        public int Machitietphieunhap { get => machitietphieunhap; set => machitietphieunhap = value; }
        public int Maphieunhap { get => maphieunhap; set => maphieunhap = value; }
        public int Mathietbisudung { get => mathietbisudung; set => mathietbisudung = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public float Dongianhap { get => dongianhap; set => dongianhap = value; }
        public int Soluongnhap { get => soluongnhap; set => soluongnhap = value; }
        public float Thanhtiennhap { get => thanhtiennhap; set => thanhtiennhap = value; }

        public ChiTietPhieuNhap(int machitietphieunhap, int maphieunhap, int mathietbisudung, string tenthietbi, float dongianhap, int soluongnhap, float thanhtiennhap)
        {
            this.Machitietphieunhap = machitietphieunhap;
            this.Maphieunhap = maphieunhap;
            this.Mathietbisudung = mathietbisudung;
            this.Tenthietbi = tenthietbi;
            this.Dongianhap = dongianhap;
            this.Soluongnhap = soluongnhap;
            this.Thanhtiennhap = thanhtiennhap;
        }

        public ChiTietPhieuNhap(DataRow row)
        {
            this.Machitietphieunhap = (int)row["machitietphieunhap"];
            this.Maphieunhap = (int)row["maphieunhap"];
            this.Mathietbisudung = (int)row["mathietbisudung"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Dongianhap = (float)Convert.ToDouble(row["dongianhap"].ToString());
            this.Soluongnhap = (int)row["soluongnhap"];
            this.Thanhtiennhap = (float)Convert.ToDouble(row["thanhtiennhap"].ToString());
        }
    }
}
