using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    public class ThietBiSuDungDAO
    {
        private static ThietBiSuDungDAO instance;

        public static ThietBiSuDungDAO Instance
        {
            get { if (instance == null) instance = new ThietBiSuDungDAO(); return ThietBiSuDungDAO.instance; }
            private set { ThietBiSuDungDAO.instance = value; }
        }

        private ThietBiSuDungDAO() { }

        public List<DTO.ThietBiSuDung> GetListTBSD()
        {
            List<DTO.ThietBiSuDung> list = new List<DTO.ThietBiSuDung>();
            string query = "SELECT a.Mathietbisudung, a.Tenthietbisudung, a.Dongianhap, a.Ngaynhap, a.Tinhtrangthietbi, a.Ghichu, b.Mathietbi, b.Tenthietbi, b.Donvitinh FROM dbo.ThietBiSuDung AS a, dbo.ThietBi AS b WHERE a.Mathietbi = b.Mathietbi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.ThietBiSuDung thietbisudung = new DTO.ThietBiSuDung(item);
                list.Add(thietbisudung);
            }
            return list;
        }

        public bool InsertThietbisudung(int Mathietbi, float Dongianhap, DateTime Ngaynhap, string Tinhtrangthietbi, string Ghichu, string Tenthietbisudung)
        {
            string query = string.Format("INSERT dbo.ThietBiSuDung ( Mathietbi, Dongianhap, Ngaynhap, Tinhtrangthietbi,  Ghichu, Tenthietbisudung ) VALUES ({0}, {1}, N'{2}', N'{3}', N'{4}', N'{5}')", Mathietbi, Dongianhap, Ngaynhap, Tinhtrangthietbi, Ghichu, Tenthietbisudung);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateThietbisudung(int Mathietbisudung, float Dongianhap, DateTime Ngaynhap, string Tinhtrangthietbi, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.ThietBiSuDung SET Dongianhap = {1} , Ngaynhap = N'{2}' , Tinhtrangthietbi = N'{3}' , Ghichu = N'{4}'  WHERE Mathietbisudung = {0} ", Mathietbisudung , Dongianhap, Ngaynhap, Tinhtrangthietbi, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteThietbisudung(int Mathietbisudung)
        {
            string query = string.Format("DELETE dbo.Thietbisudung WHERE Mathietbisudung = {0}", Mathietbisudung);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
