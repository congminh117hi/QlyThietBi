using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class LoaiThietBiDAO
    {
        private static LoaiThietBiDAO instance;

        public static LoaiThietBiDAO Instance
        {
            get { if (instance == null) instance = new LoaiThietBiDAO(); return LoaiThietBiDAO.instance; }
            private set { LoaiThietBiDAO.instance = value; }
        }

        private LoaiThietBiDAO() { }

        public List<DTO.LoaiThietBi> GetListLoaiThietBi()
        {
            List<DTO.LoaiThietBi> list = new List<DTO.LoaiThietBi>();
            string query = "SELECT * FROM dbo.LoaiThietBi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.LoaiThietBi loaithietbi = new DTO.LoaiThietBi(item);
                list.Add(loaithietbi);
            }
            return list;
        }

        public bool InsertLoaithietbi(string Tenloaithietbi)
        {
            string query = string.Format("INSERT dbo.LoaiThietBi(Tenloaithietbi) VALUES (N'{0}')", Tenloaithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateLoaithietbi(int Maloaithietbi, string Tenloaithietbi)
        {
            string query = string.Format("UPDATE dbo.LoaiThietBi SET Tenloaithietbi = N'{1}' WHERE Maloaithietbi = {0} ", Maloaithietbi, Tenloaithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteLoaithietbi(int Maloaithietbi)
        {
            string query = string.Format("DELETE dbo.LoaiThietBi WHERE Maloaithietbi = {0} ", Maloaithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
