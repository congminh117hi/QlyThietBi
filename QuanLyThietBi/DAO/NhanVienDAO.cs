using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "SELECT a.Manhanvien, a.Tennhanvien, a.Chucvu, a.Sdtnhanvien,  a.Emailnhanvien, a.Madonvi, b.Tendonvi FROM dbo.NhanVien a, dbo.DonVi b WHERE a.Madonvi = b.Madonvi";
            DataTable data = LKDL.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanvien = new NhanVien(item);
                list.Add(nhanvien);
            }
            return list;
        }

        public bool InsertNhanvien(string Tennhanvien, string Chucvu, string Sdtnhanvien, string Emailnhanvien, int Madonvi)
        {
            string query = string.Format("INSERT dbo.NhanVien(Tennhanvien,Chucvu,Sdtnhanvien,Emailnhanvien, Madonvi) VALUES ( N'{0}' , N'{1}', N'{2}' ,N'{3}', {4})", Tennhanvien, Chucvu, Sdtnhanvien, Emailnhanvien, Madonvi);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateNhanvien(int Manhanvien, string Tennhanvien, string Chucvu, string Sdtnhanvien, string Emailnhanvien)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET Tennhanvien = N'{1}', Chucvu = N'{2}', Sdtnhanvien = N'{3}', Emailnhanvien = N'{4}' WHERE Manhanvien = '{0}' ", Manhanvien, Tennhanvien, Chucvu, Sdtnhanvien, Emailnhanvien);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteNhanvien(int Manhanvien)
        {
            string query = string.Format("DELETE dbo.NhanVien WHERE Manhanvien = {0} ", Manhanvien);
            int result = LKDL.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
