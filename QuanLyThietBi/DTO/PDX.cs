using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace QuanLyThietBi.DTO
{
    public class PDX
    {
        private int maphieudexuat;

        private int manhanvien;

        private string tennhanvien;

        private int madonvi;

        private string tendonvi;

        private string ghichu;

        private int mathietbi;

        private string tenthietbi;

        private int soluong;

        private DateTime ngaydexuat;

        public int Maphieudexuat { get => maphieudexuat; set => maphieudexuat = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Mathietbi { get => mathietbi; set => mathietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public DateTime Ngaydexuat { get => ngaydexuat; set => ngaydexuat = value; }

        public PDX(int maphieudexuat, int manhanvien, string tennhanvien, int madonvi, string tendonvi, DateTime ngaydexuat, string ghichu, int mathietbi, string tenthietbi, int soluong)
        {
            this.Maphieudexuat = maphieudexuat;
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Mathietbi = mathietbi;
            this.Tenthietbi = tenthietbi;
            this.Soluong = soluong;
            this.Ngaydexuat = ngaydexuat;
            this.Ghichu = ghichu;
        }

        public PDX(DataRow row)
        {
            this.Maphieudexuat = (int)row["maphieudexuat"];
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Mathietbi = (int)row["mathietbi"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Ngaydexuat = (DateTime)row["ngaydexuat"];
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}