using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class PhieuDeXuat
    {
        private int maphieudexuat;

        private int manhanvien;

        private string tennhanvien;

        private int madonvi;

        private string tendonvi;

        private DateTime ngaydexuat;

        private string ghichu;

        public int Maphieudexuat { get => maphieudexuat; set => maphieudexuat = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public DateTime Ngaydexuat { get => ngaydexuat; set => ngaydexuat = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhieuDeXuat(int maphieudexuat, int manhanvien, string tennhanvien, int madonvi, string tendonvi, DateTime ngaydexuat, string ghichu)
        {
            this.Maphieudexuat = maphieudexuat;
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Ghichu = ghichu;
        }

        public PhieuDeXuat(DataRow row)
        {
            this.Maphieudexuat = (int)row["maphieudexuat"];
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }
    }
}
