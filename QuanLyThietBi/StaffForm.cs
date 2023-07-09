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
    public partial class StaffForm : Form
    {
        BindingSource nhanvienlist = new BindingSource();

        public StaffForm()
        {
            InitializeComponent();

            dgNhanVien.DataSource = nhanvienlist;
            LoadDanhSachNhanVien();
            dgNhanVien.Columns["Madonvi"].Visible = false;
            NhanVienBindding();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            AddStaffForm form = new AddStaffForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachNhanVien();
        }

        void LoadDanhSachNhanVien()
        {
            nhanvienlist.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }

        void NhanVienBindding()
        {
            txtTendonvi.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Tendonvi", true, DataSourceUpdateMode.Never));
            txtManhanvien.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Manhanvien", true, DataSourceUpdateMode.Never));
            txtTennhanvien.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Tennhanvien", true, DataSourceUpdateMode.Never));
            txtChucvu.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Chucvu", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Sdtnhanvien", true, DataSourceUpdateMode.Never));
            txtEmailNV.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Emailnhanvien", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateNhanVien;
        public event EventHandler UpdateNhanVien
        {
            add { updateNhanVien += value; }
            remove { updateNhanVien -= value; }
        }

        private event EventHandler deleteNhanVien;
        public event EventHandler DeleteNhanVien
        {
            add { deleteNhanVien += value; }
            remove { deleteNhanVien -= value; }
        }

        private void btnLuuTTNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTennhanvien.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTennhanvien.Focus();
                }
                else if (txtChucvu.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtChucvu.Focus();
                }
                else if (txtSDT.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtSDT.Focus();
                }
                else if (txtEmailNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtEmailNV.Focus();
                }
                else
                {
                    int Manhanvien = Convert.ToInt32(txtManhanvien.Text);
                    string Tennhanvien = txtTennhanvien.Text;
                    string Chucvu = txtChucvu.Text;
                    string Sdtnhanvien = txtSDT.Text;
                    string Emailnhanvien = txtEmailNV.Text;

                    if (NhanVienDAO.Instance.UpdateNhanvien(Manhanvien, Tennhanvien, Chucvu, Sdtnhanvien, Emailnhanvien))
                    {
                        MessageBox.Show("Sửa Nhân Viên thành công", "Thông Báo");
                        LoadDanhSachNhanVien();
                        if (updateNhanVien != null)
                            updateNhanVien(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !!!", "Vui lòng kiểm tra lại thông tin !");
            }
        }

        private void btnXoaTTNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtManhanvien.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtManhanvien.Focus();
                }
                else
                {
                    int Manhanvien = Convert.ToInt32(txtManhanvien.Text);

                    if (NhanVienDAO.Instance.DeleteNhanvien(Manhanvien))
                    {
                        MessageBox.Show("Xóa Nhân Viên thành công", "Thông Báo");
                        LoadDanhSachNhanVien();
                        if (deleteNhanVien != null)
                            deleteNhanVien(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi !!!", "Vui lòng kiểm tra lại thông tin !");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
