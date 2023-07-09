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
    public partial class DeviceForm : Form
    {
        BindingSource ThietBiList = new BindingSource();

        public DeviceForm()
        {
            InitializeComponent();

            dgThietbi.DataSource = ThietBiList;
            LoadDanhSachThietBi();
            ThietBiBindding();
            dgThietbi.Columns["Maloaithietbi"].Visible = false;
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            AddDeviceForm form = new AddDeviceForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachThietBi();
        }

        void LoadDanhSachThietBi()
        {
            ThietBiList.DataSource = ThietBiDAO.Instance.GetListThietBi();
        }

        void ThietBiBindding()
        {
            txtTenloaithietbi.DataBindings.Add(new Binding("Text", dgThietbi.DataSource, "Tenloaithietbi", true, DataSourceUpdateMode.Never));
            txtMathietbi.DataBindings.Add(new Binding("Text", dgThietbi.DataSource, "Mathietbi", true, DataSourceUpdateMode.Never));
            txtTenthietbi.DataBindings.Add(new Binding("Text", dgThietbi.DataSource, "Tenthietbi", true, DataSourceUpdateMode.Never));
            txtDonvitinh.DataBindings.Add(new Binding("Text", dgThietbi.DataSource, "Donvitinh", true, DataSourceUpdateMode.Never));
            txtGhichu.DataBindings.Add(new Binding("Text", dgThietbi.DataSource, "Ghichu", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateThietBi;
        public event EventHandler UpdateThietBi
        {
            add { updateThietBi += value; }
            remove { updateThietBi -= value; }
        }


        private event EventHandler deleteThietBi;
        public event EventHandler DeleteThietBi
        {
            add { deleteThietBi += value; }
            remove { deleteThietBi -= value; }
        }

        private void btnCapnhatTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenthietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTenthietbi.Focus();
                }
                else if (txtDonvitinh.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtDonvitinh.Focus();
                }
                else
                {
                    int Mathietbi = Convert.ToInt32(txtMathietbi.Text);
                    string Tenthietbi = txtTenthietbi.Text;
                    string Donvitinh = txtDonvitinh.Text;
                    string Ghichu = txtGhichu.Text;

                    if (ThietBiDAO.Instance.UpdateThietbi(Mathietbi, Tenthietbi, Donvitinh, Ghichu))
                    {
                        MessageBox.Show("Sửa Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachThietBi();
                        if (updateThietBi != null)
                            updateThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thiết Bị thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoathietbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMathietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMathietbi.Focus();
                }
                else
                {
                    int Mathietbi = Convert.ToInt32(txtMathietbi.Text);

                    if (ThietBiDAO.Instance.DeleteThietbi(Mathietbi))
                    {
                        MessageBox.Show("Xóa Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachThietBi();
                        if (deleteThietBi != null)
                            deleteThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thiết Bị thất bại !", "Thông Báo");
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
