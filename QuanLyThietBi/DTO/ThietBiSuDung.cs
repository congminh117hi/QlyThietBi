using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class ThietBiSuDung
    {
        private int mathietbisudung;

        private string tenthietbisudung;

        private int mathietbi;

        private string tenthietbi;

        private float dongianhap;

        private DateTime ngaynhap;

        private string tinhtrangthietbi;

        private string ghichu;

        public int Mathietbisudung { get => mathietbisudung; set => mathietbisudung = value; }
        public int Mathietbi { get => mathietbi; set => mathietbi = value; }
        public string Tenthietbi { get => tenthietbi; set => tenthietbi = value; }
        public float Dongianhap { get => dongianhap; set => dongianhap = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Tinhtrangthietbi { get => tinhtrangthietbi; set => tinhtrangthietbi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Tenthietbisudung { get => tenthietbisudung; set => tenthietbisudung = value; }

        public ThietBiSuDung(int mathietbisudung, int mathietbi, string tenthietbi, float dongianhap, DateTime ngaynhap, string tinhtrangthietbi, string ghichu, string tenthietbisudung)
        {
            this.Mathietbisudung = mathietbisudung;
            this.Mathietbi = mathietbi;
            this.Tenthietbi = tenthietbi;
            this.Dongianhap = dongianhap;
            this.Ngaynhap = ngaynhap;
            this.Tinhtrangthietbi = tinhtrangthietbi;
            this.Ghichu = ghichu;
            this.Tenthietbisudung = tenthietbisudung;
        }

        public ThietBiSuDung(DataRow row)
        {
            this.Mathietbisudung = (int)row["mathietbisudung"];
            this.Mathietbi = (int)row["mathietbi"];
            this.Tenthietbi = row["tenthietbi"].ToString();
            this.Dongianhap = (float)Convert.ToDouble(row["dongianhap"].ToString());
            this.Ngaynhap = (DateTime)row["ngaynhap"];
            this.Tinhtrangthietbi = row["tinhtrangthietbi"].ToString();
            this.Ghichu = row["ghichu"].ToString();
            this.Tenthietbisudung = row["tenthietbisudung"].ToString();
        }
    }
}
