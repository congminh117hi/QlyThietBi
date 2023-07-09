using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class ChiTietPhieuDeXuat
    {
        private int machitietphieudexuat;

        private int maphieudexuat;

        private int mathietbi;

        private string tenthietbi;

        private int soluong;


        public int Machitietphieudexuat { get => machitietphieudexuat; set => machitietphieudexuat = value; }
        public int Maphieudexuat { get => maphieudexuat; set => maphieudexuat = value; }
        public int Mathietbi { get => mathietbi; set => mathietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public ChiTietPhieuDeXuat(int machitietphieudexuat, int maphieudexuat, int mathietbi, string tenthietbi, int soluong)
        {
            this.Machitietphieudexuat = machitietphieudexuat;
            this.Maphieudexuat = maphieudexuat;
            this.Mathietbi = mathietbi;
            this.Tenthietbi = tenthietbi;
            this.Soluong = soluong;

        }

        public ChiTietPhieuDeXuat(DataRow row)
        {
            this.Machitietphieudexuat = (int)row["machitietphieudexuat"];
            this.Maphieudexuat = (int)row["maphieudexuat"];
            this.Mathietbi = (int)row["mathietbi"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Soluong = (int)row["soluong"];
        }
    }
}
