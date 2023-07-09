using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new PhieuNhapDAO(); return PhieuNhapDAO.instance; }
            private set { PhieuNhapDAO.instance = value; }
        }

        private PhieuNhapDAO() { }

        //public List<DanhMuc> GetListDanhMuc()
        //{
        //    List<DanhMuc> list = new List<DanhMuc>();
        //    string query = "SELECT * FROM dbo.DanhMucHangHoa";
        //    DataTable data = LKDL.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        DanhMuc danhmuc = new DanhMuc(item);
        //        list.Add(danhmuc);
        //    }
        //    return list;
        //}

        public bool InsertPhieunhap(DateTime Ngaynhap, int Manhanvien, int Madonvi, float TongTien, string Ghichu)
        {
            string query = string.Format("INSERT dbo.PhieuNhapThietBi( Ngaynhap, Manhanvien, Madonvi, TongTien, Ghichu) VALUES ( N'{0}', {1}, {2}, {3}, N'{4}' )", Ngaynhap, Manhanvien, Madonvi, TongTien, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePhieunhap(int Maphieunhap, DateTime Ngaynhap, int Madonvi, int Manhanvien, string Ghichu)
        {
            string query = string.Format("UPDATE dbo.PhieuNhapThietBi SET Ngaynhap = N'{1}', Madonvi = {2}, Manhanvien = {3}, Ghichu= N'{4}' WHERE Maphieunhap = {0} ", Maphieunhap, Ngaynhap, Madonvi, Manhanvien, Ghichu);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieunhap(int Maphieunhap)
        {
            string query = string.Format("DELETE dbo.PhieuNhapThietBi WHERE Maphieunhap = {0} ", Maphieunhap);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
