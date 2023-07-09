using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class ChiTietPhieuSuaChua
    {
        private int machitietphieusuachua;

        private int maphieusuachua;

        private int matheodoithietbi;

        private string tenthietbi;

        private int soluongsuachua;

        public int Machitietphieusuachua { get => machitietphieusuachua; set => machitietphieusuachua = value; }
        public int Maphieusuachua { get => maphieusuachua; set => maphieusuachua = value; }
        public int Matheodoithietbi { get => matheodoithietbi; set => matheodoithietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public int Soluongsuachua { get => soluongsuachua; set => soluongsuachua = value; }

        public ChiTietPhieuSuaChua(int machitietphieusuachua, int maphieusuachua, int matheodoithietbi, string tenthietbi, int soluongsuachua)
        {
            this.Machitietphieusuachua = machitietphieusuachua;
            this.Maphieusuachua = maphieusuachua;
            this.Matheodoithietbi = matheodoithietbi;
            this.Tenthietbi = tenthietbi;
            this.Soluongsuachua = soluongsuachua;
        }

        public ChiTietPhieuSuaChua(DataRow row)
        {
            this.Machitietphieusuachua = (int)row["machitietphieusuachua"];
            this.Maphieusuachua = (int)row["maphieusuachua"];
            this.Matheodoithietbi = (int)row["matheodoithietbi"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Soluongsuachua = (int)row["soluongsuachua"];
        }
    }
}
