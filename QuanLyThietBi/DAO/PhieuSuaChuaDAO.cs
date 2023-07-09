using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class PhieuSuaChuaDAO
    {
        private static PhieuSuaChuaDAO instance;

        public static PhieuSuaChuaDAO Instance
        {
            get { if (instance == null) instance = new PhieuSuaChuaDAO(); return PhieuSuaChuaDAO.instance; }
            private set { PhieuSuaChuaDAO.instance = value; }
        }

        private PhieuSuaChuaDAO() { }

        public List<PhieuSuaChua> GetListPhieuSuaChua()
        {
            List<PhieuSuaChua> list = new List<PhieuSuaChua>();
            string query = "SELECT a.Maphieusuachua, b.Machitietphieusuachua, a.Manhanvien, d.Tennhanvien, c.Madonvi, c.Tendonvi, a.Ngaysuachua, b.Mathietbisudung, e.Tenthietbisudung, b.Soluongsuachua, a.Ghichu FROM dbo.PhieuSuaChua AS a, dbo.ChiTietPhieuSuaChua AS b, dbo.DonVi AS c, dbo.NhanVien AS d, dbo.ThietBiSuDung AS e WHERE a.Maphieusuachua = b.Maphieusuachua AND a.Manhanvien = d.Manhanvien AND a.Madonvi = c.Madonvi AND b.Mathietbisudung = e.Mathietbisudung";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhieuSuaChua danhmuc = new PhieuSuaChua(item);
                list.Add(danhmuc);
            }
            return list;
        }

        public bool InsertPhieusuachua(int Manhanvien, int Madonvi, DateTime Ngaysuachua)
        {
            string query = string.Format("INSERT dbo.PhieuSuaChua(Manhanvien,Madonvi,Ngaysuachua) VALUES ( {0}, {1}, N'{2}' )", Manhanvien, Madonvi, Ngaysuachua);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePhieusuachua(int Maphieusuachua, DateTime Ngaysuachua, int Madonvi, int Manhanvien, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.PhieuNhapThietBi SET Ngaysuachua = N'{1}', Madonvi = {2}, Manhanvien = {3}, Ghichu = N'{4}' WHERE Maphieusuachua = {0} ", Maphieusuachua, Ngaysuachua, Madonvi, Manhanvien, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieusuachua(int Maphieusuachua)
        {
            string query = string.Format("DELETE dbo.Phieusuachua WHERE Maphieusuachua = {0} ", Maphieusuachua);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
