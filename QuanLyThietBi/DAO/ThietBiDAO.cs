using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class ThietBiDAO
    {
        private static ThietBiDAO instance;

        public static ThietBiDAO Instance
        {
            get { if (instance == null) instance = new ThietBiDAO(); return ThietBiDAO.instance; }
            private set { ThietBiDAO.instance = value; }
        }

        private ThietBiDAO() { }

        public List<DTO.ThietBi> GetListThietBi()
        {
            List<DTO.ThietBi> list = new List<DTO.ThietBi>();
            string query = "SELECT a.Tenthietbi, a.Donvitinh, a.Mathietbi, a.Ghichu,a.Maloaithietbi, b.Tenloaithietbi FROM dbo.ThietBi a, dbo.LoaiThietBi b WHERE a.Maloaithietbi = b.Maloaithietbi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.ThietBi thietbi = new DTO.ThietBi(item);
                list.Add(thietbi);
            }
            return list;
        }

        public bool InsertThietbi(string Tenthietbi, string Donvitinh, string Ghichu, int Maloaithietbi)
        {
            string query = string.Format("INSERT dbo.ThietBi ( Tenthietbi, Donvitinh, Ghichu, Maloaithietbi ) VALUES (N'{0}', N'{1}', N'{2}', {3})", Tenthietbi, Donvitinh, Ghichu, Maloaithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateThietbi(int Mathietbi, string Tenthietbi, string Donvitinh, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.ThietBi SET Tenthietbi = N'{1}' , Donvitinh = N'{2}' , Ghichu = N'{3}'  WHERE Mathietbi = {0} ",Mathietbi, Tenthietbi, Donvitinh, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteThietbi(int Mathietbi)
        {
            string query = string.Format("DELETE dbo.ThietBi WHERE Mathietbi = {0} ", Mathietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
