using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class NhanVien
    {
        private int manhanvien;

        private string tennhanvien;

        private string chucvu;

        private string sdtnhanvien;

        private string emailnhanvien;

        private int madonvi;

        private string tendonvi;

        public int Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Sdtnhanvien { get => sdtnhanvien; set => sdtnhanvien = value; }
        public string Emailnhanvien { get => emailnhanvien; set => emailnhanvien = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }

        public NhanVien(int manhanvien, string tennhanvien, string chucvu, string sdtnhanvien, string emailnhanvien, int madonvi, string tendonvi)
        {
            this.Manhanvien = manhanvien;
            this.Tennhanvien = tennhanvien;
            this.Chucvu = chucvu;
            this.Sdtnhanvien = sdtnhanvien;
            this.Emailnhanvien = emailnhanvien;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
        }

        public NhanVien(DataRow row)
        {
            this.Manhanvien = (int)row["manhanvien"];
            this.Tennhanvien = row["tennhanvien"].ToString();
            this.Chucvu = row["chucvu"].ToString();
            this.Sdtnhanvien = row["sdtnhanvien"].ToString();
            this.Emailnhanvien = row["emailnhanvien"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
        }
    }
}
