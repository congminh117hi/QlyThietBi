using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class ThietBi
    {
        private int mathietbi;

        private string tenthietbi;

        private string donvitinh;

        private string ghichu;

        private int maloaithietbi;

        private string tenloaithietbi;

        public int Mathietbi { get => mathietbi; set => mathietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Maloaithietbi { get => maloaithietbi; set => maloaithietbi = value; }
        public string Tenloaithietbi { get => tenloaithietbi; set => tenloaithietbi = value; }

        public ThietBi(int mathietbi, string tenthietbi, string donvitinh, string ghichu, int maloaithietbi, string tenloaithietbi)
        {
            this.Mathietbi = mathietbi;
            this.Tenthietbi = tenthietbi;
            this.Donvitinh = donvitinh;
            this.Ghichu = ghichu;
            this.Maloaithietbi = maloaithietbi;
            this.Tenloaithietbi = tenloaithietbi;
        }

        public ThietBi(DataRow row)
        {
            this.Mathietbi = (int)row["mathietbi"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Donvitinh = row["donvitinh"].ToString();
            this.Ghichu = row["ghichu"].ToString();
            this.Maloaithietbi = (int)row["maloaithietbi"];
            this.Tenloaithietbi = row["tenloaithietbi"].ToString();
        }
    }
}
