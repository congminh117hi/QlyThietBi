using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class DonViDAO
    {
        private static DonViDAO instance;

        public static DonViDAO Instance
        {
            get { if (instance == null) instance = new DonViDAO(); return DonViDAO.instance; }
            private set { DonViDAO.instance = value; }
        }

        private DonViDAO() { }

        public List<DonVi> GetListDonVi()
        {
            List<DonVi> list = new List<DonVi>();
            string query = "SELECT * FROM dbo.DonVi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DonVi donvi = new DonVi(item);
                list.Add(donvi);
            }
            return list;
        }

        public bool InsertDonvi(string Tendonvi, string Sdtdonvi, string Emaildonvi)
        {
            string query = string.Format("INSERT dbo.DonVi(Tendonvi,Sdtdonvi,Emaildonvi) VALUES ( N'{0}' , N'{1}', N'{2}')", Tendonvi, Sdtdonvi, Emaildonvi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateDonvi(int Madonvi, string Tendonvi, string Sdtdonvi, string Emaildonvi)
        {
            string query = string.Format("UPDATE dbo.DonVi SET Tendonvi = N'{1}', Sdtdonvi = N'{2}', Emaildonvi = N'{3}' WHERE Madonvi = '{0}' ", Madonvi, Tendonvi, Sdtdonvi, Emaildonvi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteDonvi(int Madonvi)
        {
            string query = string.Format("DELETE dbo.DonVi WHERE Madonvi = {0} ", Madonvi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
