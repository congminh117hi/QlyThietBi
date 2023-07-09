using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class DonVi
    {
        private int madonvi;

        private string tendonvi;

        private string sdtdonvi;

        private string emaildonvi;

        public int Madonvi { get => madonvi; set => madonvi = value; }
        public string Tendonvi { get => tendonvi; set => tendonvi = value; }
        public string Sdtdonvi { get => sdtdonvi; set => sdtdonvi = value; }
        public string Emaildonvi { get => emaildonvi; set => emaildonvi = value; }

        public DonVi(int madonvi, string tendonvi, string sdtdonvi, string emaildonvi)
        {
            this.Madonvi = madonvi;
            this.Tendonvi = tendonvi;
            this.Sdtdonvi = sdtdonvi;
            this.Emaildonvi = emaildonvi;
        }

        public DonVi(DataRow row)
        {
            this.Madonvi = (int)row["madonvi"];
            this.Tendonvi = row["tendonvi"].ToString();
            this.Sdtdonvi = row["sdtdonvi"].ToString();
            this.Emaildonvi = row["emaildonvi"].ToString();
        }
    }
}
