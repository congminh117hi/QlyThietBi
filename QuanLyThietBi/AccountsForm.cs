using QuanLyThietBi.DAO;
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
    public partial class AccountsForm : Form
    {
        BindingSource taikhoanlist = new BindingSource();

        public AccountsForm()
        {
            InitializeComponent();

            dgTaiKhoan.DataSource = taikhoanlist;
            LoadDanhSachTaiKhoan();
            dgTaiKhoan.Columns["Manhanvien"].Visible = false;
            TaiKhoanBindding();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AddAccountsForm form = new AddAccountsForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachTaiKhoan();
        }

        void LoadDanhSachTaiKhoan()
        {
            taikhoanlist.DataSource = TaiKhoanDAO.Instance.GetListTaiKhoan();
        }

        void TaiKhoanBindding()
        {
            txtTenNhanVien.DataBindings.Add(new Binding("Text", dgTaiKhoan.DataSource, "Tennhanvien", true, DataSourceUpdateMode.Never));
            txtMataikhoan.DataBindings.Add(new Binding("Text", dgTaiKhoan.DataSource, "Mataikhoan", true, DataSourceUpdateMode.Never));
            txtLoaitaikhoan.DataBindings.Add(new Binding("Text", dgTaiKhoan.DataSource, "Tentaikhoan", true, DataSourceUpdateMode.Never));
            txtTendangnhap.DataBindings.Add(new Binding("Text", dgTaiKhoan.DataSource, "Tendangnhap", true, DataSourceUpdateMode.Never));
            txtMatkhau.DataBindings.Add(new Binding("Text", dgTaiKhoan.DataSource, "Matkhau", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateTaiKhoan;
        public event EventHandler UpdateTaiKhoan
        {
            add { updateTaiKhoan += value; }
            remove { updateTaiKhoan -= value; }
        }

        private event EventHandler deleteTaiKhoan;
        public event EventHandler DeleteTaiKhoan
        {
            add { deleteTaiKhoan += value; }
            remove { deleteTaiKhoan -= value; }
        }

        private void btnLuuTTTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoaitaikhoan.Text == "")
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
                    int Mataikhoan = Convert.ToInt32(txtMataikhoan.Text);
                    string Loaitaikhoan = txtLoaitaikhoan.Text;
                    string Tendangnhap = txtTendangnhap.Text;
                    string Matkhau = txtMatkhau.Text;

                    if (TaiKhoanDAO.Instance.UpdateTaiKhoan(Mataikhoan, Loaitaikhoan, Tendangnhap, Matkhau))
                    {
                        MessageBox.Show("Sửa Tài Khoản thành công", "Thông Báo");
                        LoadDanhSachTaiKhoan();
                        if (updateTaiKhoan != null)
                            updateTaiKhoan(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa Tài Khoản thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMataikhoan.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMataikhoan.Focus();
                }
                else
                {
                    int Mataikhoan = Convert.ToInt32(txtMataikhoan.Text);

                    if (TaiKhoanDAO.Instance.DeleteTaiKhoan(Mataikhoan))
                    {
                        MessageBox.Show("Xóa Tài Khoản thành công", "Thông Báo");
                        LoadDanhSachTaiKhoan();
                        if (deleteTaiKhoan != null)
                            deleteTaiKhoan(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa Tài Khoản thất bại !", "Thông Báo");
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

        private void dgTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
