using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class ChiTietPhieuSuaChuaDAO
    {
        private static ChiTietPhieuSuaChuaDAO instance;

        public static ChiTietPhieuSuaChuaDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuSuaChuaDAO(); return ChiTietPhieuSuaChuaDAO.instance; }
            private set { ChiTietPhieuSuaChuaDAO.instance = value; }
        }

        private ChiTietPhieuSuaChuaDAO() { }

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

        public bool InsertChitietphieusuachua(int Maphieusuachua, int Matheodoithietbi, int Soluongsuachua)
        {
            string query = string.Format("INSERT dbo.ChiTietPhieuSuaChua( Maphieusuachua, Matheodoithietbi, Soluongsuachua) VALUES ( {0}, {1}, {2} )", Maphieusuachua, Matheodoithietbi, Soluongsuachua);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateChitietphieusuachua(int Matheodoithietbi, int Soluongsuachua) //bỏ khóa chính "chi tiết phiếu sửa chữa" nha! nó bị dư thừa.
        {
            string query = string.Format("UPDATE dbo.PhieuNhapThietBi SET Soluong = {1} WHERE Matheodoithietbi = {0} ", Matheodoithietbi, Soluongsuachua);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteChitietphieusuachua(int Matheodoithietbi)
        {
            string query = string.Format("DELETE dbo.PhieuNhapThietBi WHERE Matheodoithietbi = {0} ", Matheodoithietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
