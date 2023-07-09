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
    public partial class TypeOfDForm : Form
    {
        BindingSource LoaiThietBilist = new BindingSource();

        public TypeOfDForm()
        {
            InitializeComponent();
            dgNhanVien.DataSource = LoaiThietBilist;
            LoadDanhSachLoaiThietBi();
            LoaiThietBiBindding();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            AddTODForm form = new AddTODForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachLoaiThietBi();
        }

        void LoadDanhSachLoaiThietBi()
        {
            LoaiThietBilist.DataSource = LoaiThietBiDAO.Instance.GetListLoaiThietBi();
        }

        void LoaiThietBiBindding()
        {
            txtMaloaithietbi.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Maloaithietbi", true, DataSourceUpdateMode.Never));
            txtTenloaithietbi.DataBindings.Add(new Binding("Text", dgNhanVien.DataSource, "Tenloaithietbi", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateLoaiThietBi;
        public event EventHandler UpdateLoaiThietBi
        {
            add { updateLoaiThietBi += value; }
            remove { updateLoaiThietBi -= value; }
        }

        private event EventHandler deleteLoaiThietBi;
        public event EventHandler DeleteLoaiThietBi
        {
            add { deleteLoaiThietBi += value; }
            remove { deleteLoaiThietBi -= value; }
        }

        private void btnCapnhatLTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaloaithietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMaloaithietbi.Focus();
                }
                else if (txtTenloaithietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTenloaithietbi.Focus();
                }
                else
                {
                    string Tenloaithietbi = txtTenloaithietbi.Text;
                    int Maloaithietbi = Convert.ToInt32(txtMaloaithietbi.Text);

                    if (LoaiThietBiDAO.Instance.UpdateLoaithietbi(Maloaithietbi, Tenloaithietbi))
                    {
                        MessageBox.Show("Sửa Loại Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachLoaiThietBi();
                        if (updateLoaiThietBi != null)
                            updateLoaiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa Loại Thiết Bị thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaLTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaloaithietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMaloaithietbi.Focus();
                }
                else
                {
                    int Maloaithietbi = Convert.ToInt32(txtMaloaithietbi.Text);

                    if (LoaiThietBiDAO.Instance.DeleteLoaithietbi(Maloaithietbi))
                    {
                        MessageBox.Show("Xóa Loại Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachLoaiThietBi();
                        if (deleteLoaiThietBi != null)
                            deleteLoaiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa Loại Thiết Bị thất bại !", "Thông Báo");
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

        private void dgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
