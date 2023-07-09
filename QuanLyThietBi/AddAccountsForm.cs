using QuanLyThietBi.DAO;
using QuanLyThietBi.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBi
{
    public partial class AddAccountsForm : Form
    {
        public AddAccountsForm()
        {
            InitializeComponent();

            LoadTenNhanVien(cboTenNhanVien);
        }


        void LoadTenNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cb.DisplayMember = "Tennhanvien";
        }

        private event EventHandler insertTaiKhoan;
        public event EventHandler InsertTaiKhoan
        {
            add { insertTaiKhoan += value; }
            remove { insertTaiKhoan -= value; }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenNhanVien.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    cboTenNhanVien.Focus();
                }
                else if (txtLoaitaikhoan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtLoaitaikhoan.Focus();
                }
                else if (txtTendangnhap.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTendangnhap.Focus();
                }
                else if (txtMatkhau.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMatkhau.Focus();
                }
                else
                {
                    int Manhanvien = (cboTenNhanVien.SelectedItem as NhanVien).Manhanvien;
                    string Loaitaikhoan = txtLoaitaikhoan.Text;
                    string Tendangnhap = txtTendangnhap.Text;
                    string Matkhau = txtMatkhau.Text;

                    if (TaiKhoanDAO.Instance.InsertTaiKhoan(Loaitaikhoan, Tendangnhap, Matkhau, Manhanvien))
                    {
                        MessageBox.Show("Thêm Tài Khoản thành công", "Thông Báo");
                        if (insertTaiKhoan != null)
                            insertTaiKhoan(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm Tài Khoản thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
