using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class PhieuDeXuatDAO
    {
        private static PhieuDeXuatDAO instance;

        public static PhieuDeXuatDAO Instance
        {
            get { if (instance == null) instance = new PhieuDeXuatDAO(); return PhieuDeXuatDAO.instance; }
            private set { PhieuDeXuatDAO.instance = value; }
        }

        private PhieuDeXuatDAO() { }

        public List<PDX> GetListPhieuDeXuat()
        {
            List<PDX> list = new List<PDX>();
            string query = "SELECT a.Maphieudexuat, b.Machitietphieudexuat, a.Manhanvien, d.Tennhanvien, c.Madonvi, c.Tendonvi, a.Ngaydexuat, b.Mathietbi, e.Tenthietbi, b.Soluong, a.Ghichu FROM dbo.PhieuDeXuat AS a, dbo.ChiTietPhieuDeXuat AS b, dbo.DonVi AS c, dbo.NhanVien AS d, dbo.ThietBi AS e WHERE a.Maphieudexuat = b.Maphieudexuat AND a.Manhanvien = d.Manhanvien AND a.Madonvi = c.Madonvi AND b.Mathietbi = e.Mathietbi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PDX phieudexuat = new PDX(item);
                list.Add(phieudexuat);
            }
            return list;
        }

        public bool InsertPhieudexuat(int Manhanvien, int Madonvi, DateTime Ngaydexuat, string Ghichu )
        {
            string query = string.Format("INSERT dbo.PhieuDeXuat(Manhanvien,Madonvi,Ngaydexuat,Ghichu) VALUES ( {0}, {1}, N'{2}', N'{3}' )", Manhanvien, Madonvi, Ngaydexuat, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePhieudexuat(int Maphieudexuat,DateTime Ngaydexuat, int Madonvi, int Manhanvien, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.PhieuDeXuat SET Ngaydexuat = N'{1}', Madonvi = {2}, Manhanvien {3}, Ghichu N'{4}' WHERE Maphieudexuat = {0} ", Maphieudexuat, Ngaydexuat, Manhanvien, Madonvi, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieudexuat(int Maphieudexuat)
        {
            string query = string.Format("DELETE dbo.PhieuDeXuat WHERE Maphieudexuat = {0} ", Maphieudexuat);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
