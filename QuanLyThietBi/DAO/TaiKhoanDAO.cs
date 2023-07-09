using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { TaiKhoanDAO.instance = value; }
        }

        private TaiKhoanDAO() { }

        public List<DTO.TaiKhoan> GetListTaiKhoan()
        {
            List<DTO.TaiKhoan> list = new List<DTO.TaiKhoan>();
            string query = "SELECT a.Manhanvien, a.Tennhanvien, b.Mataikhoan, b.Tentaikhoan, b.Tendangnhap, b.Matkhau FROM dbo.NhanVien a, dbo.TaiKhoan b WHERE a.Manhanvien = b.Manhanvien";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.TaiKhoan taikhoan = new DTO.TaiKhoan(item);
                list.Add(taikhoan);
            }
            return list;
        }

        public bool InsertTaiKhoan(string Tentaikhoan, string Tendangnhap, string Matkhau, int Manhanvien)
        {
            string query = string.Format("INSERT dbo.TaiKhoan ( Tentaikhoan, Tendangnhap, Matkhau,  Manhanvien ) VALUES ( N'{0}' , N'{1}', N'{2}' , {3} )", Tentaikhoan , Tendangnhap , Matkhau , Manhanvien);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateTaiKhoan(int Mataikhoan, string Tentaikhoan, string Tendangnhap, string Matkhau)
        {
            string query = string.Format("UPDATE dbo.TaiKhoan SET Tentaikhoan = N'{1}', Tendangnhap = N'{2}', Matkhau = N'{3}' WHERE Mataikhoan = {0} ", Mataikhoan, Tentaikhoan, Tendangnhap, Matkhau);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTaiKhoan(int Mataikhoan)
        {
            string query = string.Format("DELETE dbo.TaiKhoan WHERE Mataikhoan = {0} ", Mataikhoan);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool Login(string Tendangnhap, string Matkhau)
        {
            string query = "USP_Login @Tendangnhap , @Matkhau";
            DataTable result = LKDL.Instance.ExecuteQuery(query, new object[] { Tendangnhap, Matkhau });
            return result.Rows.Count > 0;
        }

        public DTO.TaiKhoan TTTK(string Tentaikhoan)
        {
            DataTable data = LKDL.Instance.ExecuteQuery("SELECT a.Mataikhoan, a.Tentaikhoan, a.Tendangnhap, a.Matkhau, a.Manhanvien, b.Tennhanvien  FROM dbo.TaiKhoan AS a, dbo.NhanVien AS b WHERE a.Manhanvien = b.Manhanvien AND a.Tendangnhap = N'" + Tentaikhoan + "'");
            foreach (DataRow item in data.Rows)
            {
                return new DTO.TaiKhoan(item);
            }
            return null;
        }
    }
}
