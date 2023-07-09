using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;

        public static ChiTietPhieuNhapDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuNhapDAO(); return ChiTietPhieuNhapDAO.instance; }
            private set { ChiTietPhieuNhapDAO.instance = value; }
        }

        private ChiTietPhieuNhapDAO() { }

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

        public bool InsertChitietphieunhap(int Maphieunhap, int Mathietbisudung, float Dongianhap, int Soluongnhap, float Thanhtiennhap)
        {
            string query = string.Format("INSERT dbo.ChiTietPhieuNhap( Maphieunhap, Mathietbisudung, Dongianhap, Soluongnhap, Thanhtiennhap) VALUES ( {0}, {1}, {2}, {3}, {4} )", Maphieunhap, Mathietbisudung, Dongianhap, Soluongnhap, Thanhtiennhap);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateChitietphieunhap(int Mahietbisudung, int Soluongnhap, string Donvitinh, float Dongianhap, float Thanhtiennhap) //bỏ khóa chính "chi tiết phiếu nhập" nha! nó bị dư thừa.
        {
            string query = string.Format("UPDATE dbo.PhieuNhapThietBi SET Soluongnhap = {1}, Donvitinh = {2}, Dongianhap = {3}, Thanhtiennhap = {4} WHERE Mathietbisudung = {0} ", Mahietbisudung, Soluongnhap, Donvitinh, Dongianhap, Thanhtiennhap);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteChitietphieunhap(int Mathietbisudung)
        {
            string query = string.Format("DELETE dbo.ChiTietPhieuNhapThietBi WHERE Mathietbisudung = {0} ", Mathietbisudung);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
