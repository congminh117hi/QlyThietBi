using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class TheoDoiThietBiDAO
    {
        private static TheoDoiThietBiDAO instance;

        public static TheoDoiThietBiDAO Instance
        {
            get { if (instance == null) instance = new TheoDoiThietBiDAO(); return TheoDoiThietBiDAO.instance; }
            private set { TheoDoiThietBiDAO.instance = value; }
        }

        private TheoDoiThietBiDAO() { }

        public List<DTO.TheoDoiThietBi> GetListTDTB()
        {
            List<DTO.TheoDoiThietBi> list = new List<DTO.TheoDoiThietBi>();
            string query = "SELECT a.Matheodoithietbi,  a.Ngaybatdausudung, a.Ngaytrathietbi, a.Tinhtrangthietbi, a.Ghichu, b.Madonvi, b.Tendonvi, c.Mathietbisudung, c.Tenthietbisudung FROM dbo.TheoDoiThietBi AS a, dbo.DonVi AS b, dbo.ThietBiSuDung AS c WHERE a.Madonvi = b.Madonvi AND a.Mathietbisudung = c.Mathietbisudung";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.TheoDoiThietBi theodoithietbi = new DTO.TheoDoiThietBi(item);
                list.Add(theodoithietbi);
            }
            return list;
        }

        public bool InsertTheodoithietbi(int Mathietbisudung, int Madonvi, DateTime Ngaybatdausudung, DateTime Ngaytrathietbi, string Tinhtrangthietbi, string Ghichu )
        {
            string query = string.Format("INSERT dbo.TheoDoiThietBi( Mathietbisudung, Madonvi, Ngaybatdausudung, Ngaytrathietbi, Tinhtrangthietbi, Ghichu ) VALUES ({0}, {1}, N'{2}', N'{3}', N'{4}', N'{5}')", Mathietbisudung, Madonvi, Ngaybatdausudung, Ngaytrathietbi, Tinhtrangthietbi, Ghichu );
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateTheodoithietbi(int Matheodoithietbi, DateTime Ngaybatdausudung, DateTime Ngaytrathietbi, string Tinhtrangthietbi, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.TheoDoiThietBi SET Ngaybatdausudung = N'{1}' , Ngaytrathietbi = N'{2}' , Tinhtrangthietbi = N'{3}' , Ghichu = N'{4}'  WHERE Matheodoithietbi = {0} ",Matheodoithietbi , Ngaybatdausudung, Ngaytrathietbi, Tinhtrangthietbi, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTheodoithietbi(int Matheodoithietbi)
        {
            string query = string.Format("DELETE dbo.TheoDoiThietBi WHERE Matheodoithietbi = {0} ", Matheodoithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}

