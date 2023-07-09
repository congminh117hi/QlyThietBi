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
    public partial class DeviceTrackingForm : Form
    {
        BindingSource TheoDoiThietBiList = new BindingSource();

        public DeviceTrackingForm()
        {
            InitializeComponent();

            dgTheodoiTB.DataSource = TheoDoiThietBiList;
            LoadDanhSachTheoDoiThietBi();
            ThietBiSuDungBindding();

            dgTheodoiTB.Columns["Mathietbisudung"].Visible = false;
            dgTheodoiTB.Columns["Madonvi"].Visible = false;
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            AddDTrackingForm form = new AddDTrackingForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachTheoDoiThietBi();
        }

        void LoadDanhSachTheoDoiThietBi()
        {
            TheoDoiThietBiList.DataSource = TheoDoiThietBiDAO.Instance.GetListTDTB();
        }

        void ThietBiSuDungBindding()
        {
            txtTenthietbi.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Tenthietbisudung", true, DataSourceUpdateMode.Never));
            txtMatheodoiTB.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Matheodoithietbi", true, DataSourceUpdateMode.Never));
            txtTenDVsudung.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Tendonvi", true, DataSourceUpdateMode.Never));
            dtpNgaybatdauSD.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Ngaybatdausudung", true, DataSourceUpdateMode.Never));
            dtpNgaytra.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Ngaytrathietbi", true, DataSourceUpdateMode.Never));
            txtTinhtrangTB.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Tinhtrangthietbi", true, DataSourceUpdateMode.Never));
            txtGhichu.DataBindings.Add(new Binding("Text", dgTheodoiTB.DataSource, "Ghichu", true, DataSourceUpdateMode.Never));
        }

        private event EventHandler updateTheoDoiThietBi;
        public event EventHandler UpdateTheoDoiThietBi
        {
            add { updateTheoDoiThietBi += value; }
            remove { updateTheoDoiThietBi -= value; }
        }

        private event EventHandler deleteTheoDoiThietBi;
        public event EventHandler DeleteTheoDoiThietBi
        {
            add { deleteTheoDoiThietBi += value; }
            remove { deleteTheoDoiThietBi -= value; }
        }

        private void btnCapnhattheodoiTB_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTinhtrangTB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTinhtrangTB.Focus();
                }
                else
                {
                    DateTime Ngaybatdausudung = dtpNgaybatdauSD.Value;
                    DateTime Ngaytrathietbi = dtpNgaytra.Value;
                    string Tinhtrangthietbi = txtTinhtrangTB.Text;
                    string Ghichu = txtGhichu.Text;
                    int Matheodoithietbi = Convert.ToInt32(txtMatheodoiTB.Text);

                    if (TheoDoiThietBiDAO.Instance.UpdateTheodoithietbi(Matheodoithietbi, Ngaybatdausudung, Ngaytrathietbi, Tinhtrangthietbi, Ghichu))
                    {
                        MessageBox.Show("Sửa Theo Dõi Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachTheoDoiThietBi();
                        if (updateTheoDoiThietBi != null)
                            updateTheoDoiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa Theo Dõi Thiết Bị thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoatheodoiTB_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMatheodoiTB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMatheodoiTB.Focus();
                }
                else
                {
                    int Matheodoithietbi = Convert.ToInt32(txtMatheodoiTB.Text);

                    if (TheoDoiThietBiDAO.Instance.DeleteTheodoithietbi(Matheodoithietbi))
                    {
                        MessageBox.Show("Xóa Theo Dõi Thiết Bị thành công", "Thông Báo");
                        LoadDanhSachTheoDoiThietBi();
                        if (deleteTheoDoiThietBi != null)
                            deleteTheoDoiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa Theo Dõi Thiết Bị thất bại !", "Thông Báo");
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
