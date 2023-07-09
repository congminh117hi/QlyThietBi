using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DTO
{
    public class LoaiThietBi
    {
        private int maloaithietbi;

        private string tenloaithietbi;

        public int Maloaithietbi { get => maloaithietbi; set => maloaithietbi = value; }
        public string Tenloaithietbi { get => tenloaithietbi; set => tenloaithietbi = value; }

        public LoaiThietBi(int maloaithietbi, string tenloaithietbi)
        {
            this.Maloaithietbi = maloaithietbi;
            this.Tenloaithietbi = tenloaithietbi;
        }

        public LoaiThietBi(DataRow row)
        {
            this.Maloaithietbi = (int)row["maloaithietbi"];
            this.Tenloaithietbi = row["tenloaithietbi"].ToString();
        }
    }
}
