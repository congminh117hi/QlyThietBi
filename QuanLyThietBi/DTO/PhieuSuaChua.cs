using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class PhieuSuaChua
    {
        private int maphieusuachua;

        private int manhanvien;

        private string tennhanvien;

        private int madonvi;

        private string tendonvi;

        private DateTime ngaysuachua;

        private string ghichu;

        private int soluongsuachua;

        public int Maphieusuachua { get => maphieusuachua; set => maphieusuachua = value; }
        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public DateTime Ngaysuachua { get => ngaysuachua; set => ngaysuachua = value; }
        public int Soluongsuachua { get => soluongsuachua; set => soluongsuachua = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public PhieuSuaChua(int maphieusuachua, int manhanvien, string tennhanvien, int madonvi, string tendonvi, DateTime ngaysuachua, string ghichu , int soluongsuachua)
        {
            this.Maphieusuachua = maphieusuachua;
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Ngaysuachua = ngaysuachua;
            this.Ghichu = ghichu;
            this.Soluongsuachua = soluongsuachua;

        }

        public PhieuSuaChua(DataRow row)
        {
            this.Maphieusuachua = (int)row["maphieusuachua"];
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Ngaysuachua = (DateTime)row["ngaysuachua"];
            this.Ghichu = row["ghichu"].ToString();
            this.Soluongsuachua = (int)row["soluongsuachua"];
        }
    }
}
