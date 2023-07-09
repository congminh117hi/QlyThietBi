using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class TheoDoiThietBi
    {
        private int matheodoithietbi;

        private int mathietbisudung;

        private string tenthietbisudung;

        private int madonvi;

        private string tendonvi;

        private DateTime ngaybatdausudung;

        private DateTime ngaytrathietbi;

        private string tinhtrangthietbi;

        private string ghichu;

        public int Matheodoithietbi { get => matheodoithietbi; set => matheodoithietbi = value; }
        public int Mathietbisudung { get => mathietbisudung; set => mathietbisudung = value; }
        public string Tenthietbisudung { get => tenthietbisudung; set => tenthietbisudung = value; }
        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public DateTime Ngaybatdausudung { get => ngaybatdausudung; set => ngaybatdausudung = value; }
        public DateTime Ngaytrathietbi { get => ngaytrathietbi; set => ngaytrathietbi = value; }
        public string Tinhtrangthietbi { get => tinhtrangthietbi; set => tinhtrangthietbi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public TheoDoiThietBi(int matheodoithietbi, int mathietbisudung, string tenthietbisudung, int madonvi, string tendonvi, DateTime ngaybatdausudung, DateTime ngaytrathietbi, string tinhtrangthietbi, string ghichu)
        {
            this.Matheodoithietbi = matheodoithietbi;
            this.Mathietbisudung = mathietbisudung;
            this.Tenthietbisudung = tenthietbisudung;
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Ngaybatdausudung = ngaybatdausudung;
            this.Ngaytrathietbi = ngaytrathietbi;
            this.Tinhtrangthietbi = tinhtrangthietbi;
            this.Ghichu = ghichu;
        }

        public TheoDoiThietBi(DataRow row)
        {
            this.Matheodoithietbi = (int)row["matheodoithietbi"];
            this.Mathietbisudung = (int)row["mathietbisudung"];
            this.Tenthietbisudung = row["tenthietbisudung"].ToString();
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Ngaybatdausudung = (DateTime)row["ngaybatdausudung"];
            this.Ngaytrathietbi = (DateTime)row["ngaytrathietbi"];
            this.Tinhtrangthietbi = row["tinhtrangthietbi"].ToString();
            this.Ghichu = row["ghichu"].ToString();
        }

    }
}
