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
    public partial class DeviceUsedForm : Form
    {
        BindingSource ThietBiSuDungList = new BindingSource();

        public DeviceUsedForm()
        {
            InitializeComponent();

            dgTBsudung.DataSource = ThietBiSuDungList;
            LoadDanhSachThietBiSuDung();
            ThietBiSuDungBindding();
            dgTBsudung.Columns["Mathietbi"].Visible = false;
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            AddDUsedForm form = new AddDUsedForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachThietBiSuDung();
        }

        void LoadDanhSachThietBiSuDung()
        {
            ThietBiSuDungList.DataSource = ThietBiSuDungDAO.Instance.GetListTBSD();
        }

        void ThietBiSuDungBindding()
        {
            txtTenthietbi.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Tenthietbi", true, DataSourceUpdateMode.Never));
            txtMaTBsudung.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Mathietbisudung", true, DataSourceUpdateMode.Never));
            txtTenTBsudung.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Tenthietbisudung", true, DataSourceUpdateMode.Never));
            txtDongianhap.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Dongianhap", true, DataSourceUpdateMode.Never));
            dtpNgaynhap.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Ngaynhap", true, DataSourceUpdateMode.Never));
            txtTinhtrangTB.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Tinhtrangthietbi", true, DataSourceUpdateMode.Never));
            txtGhichu.DataBindings.Add(new Binding("Text", dgTBsudung.DataSource, "Ghichu", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateThietBiSuDung;
        public event EventHandler UpdateThietBiSuDung
        {
            add { updateThietBiSuDung += value; }
            remove { updateThietBiSuDung -= value; }
        }

        private event EventHandler deleteThietBiSuDung;
        public event EventHandler DeleteThietBiSuDung
        {
            add { deleteThietBiSuDung += value; }
            remove { deleteThietBiSuDung -= value; }
        }

        private void btnCapnhatTBsudung_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTBsudung.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTenTBsudung.Focus();
                }
                else if (txtDongianhap.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtDongianhap.Focus();
                }
                else if (txtTinhtrangTB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTinhtrangTB.Focus();
                }
                else
                {
                    float Dongianhap = (float)Convert.ToDouble(txtDongianhap.Text);
                    DateTime Ngaynhap = dtpNgaynhap.Value;
                    string Tinhtrangthietbi = txtTinhtrangTB.Text;
                    string Ghichu = txtGhichu.Text;
                    int Mathietbisudung = (int)Convert.ToInt32(txtMaTBsudung.Text);

                    if (ThietBiSuDungDAO.Instance.UpdateThietbisudung(Mathietbisudung, Dongianhap, Ngaynhap, Tinhtrangthietbi, Ghichu))
                    {
                        MessageBox.Show("Sửa Thiết Bị Sử Dụng thành công", "Thông Báo");
                        LoadDanhSachThietBiSuDung();
                        if (updateThietBiSuDung != null)
                            updateThietBiSuDung(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thiết Bị Sử Dụng thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaTBsudung_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTBsudung.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMaTBsudung.Focus();
                }
                else
                {
                    int Mathietbisudung = (int)Convert.ToInt32(txtMaTBsudung.Text);

                    if (ThietBiSuDungDAO.Instance.DeleteThietbisudung(Mathietbisudung))
                    {
                        MessageBox.Show("Xóa Thiết Bị Sử Dụng thành công", "Thông Báo");
                        LoadDanhSachThietBiSuDung();
                        if (deleteThietBiSuDung != null)
                            deleteThietBiSuDung(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thiết Bị Sử Dụng thất bại !", "Thông Báo");
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
