using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class ChiTietPhieuDeXuatDAO
    {
        private static ChiTietPhieuDeXuatDAO instance;

        public static ChiTietPhieuDeXuatDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhieuDeXuatDAO(); return ChiTietPhieuDeXuatDAO.instance; }
            private set { ChiTietPhieuDeXuatDAO.instance = value; }
        }

        private ChiTietPhieuDeXuatDAO() { }

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

        public bool InsertChitietphieudexuat(int Maphieudexuat, int Mathietbi, int Soluong)
        {
            string query = string.Format("INSERT dbo.ChiTietPhieuDeXuat(Maphieudexuat,Mathietbi,Soluong) VALUES ( {0}, {1}, {2} )", Maphieudexuat, Mathietbi,Soluong);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateChitietphieudexuat(int Mathietbi, int Soluong, int Donvitinh) //bỏ khóa chính "chi tiết phiếu đề xuất" nha! nó bị dư thừa.
        {
            string query = string.Format("UPDATE dbo.ChiTietPhieuDeXuat SET Soluong = {1}, Donvitinh = N'{2}' WHERE Mathietbi = {0} ",Mathietbi, Soluong, Donvitinh);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteChitietphieudexuat(int Mathietbi)
        {
            string query = string.Format("DELETE dbo.ChiTietPhieuDeXuat WHERE Mathietbi = {0} ", Mathietbi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
