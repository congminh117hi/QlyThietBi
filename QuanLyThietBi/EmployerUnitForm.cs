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
    public partial class EmployerUnitForm : Form
    {
        BindingSource donvilist = new BindingSource();

        public EmployerUnitForm()
        {
            InitializeComponent();

            dgDonvi.DataSource = donvilist;
            LoadDanhSachDonVi();
            DonViBindding();
        }

        void LoadDanhSachDonVi()
        {
            donvilist.DataSource = DonViDAO.Instance.GetListDonVi();

        }

        void DonViBindding()
        {
            txtMadonvi.DataBindings.Add(new Binding("Text", dgDonvi.DataSource, "Madonvi", true, DataSourceUpdateMode.Never));
            txtTendonvi.DataBindings.Add(new Binding("Text", dgDonvi.DataSource, "Tendonvi", true, DataSourceUpdateMode.Never));
            txtSDTdonvi.DataBindings.Add(new Binding("Text", dgDonvi.DataSource, "Sdtdonvi", true, DataSourceUpdateMode.Never));
            txtEmaildonvi.DataBindings.Add(new Binding("Text", dgDonvi.DataSource, "Emaildonvi", true, DataSourceUpdateMode.Never));
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AddEmployerUnitForm form = new AddEmployerUnitForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            LoadDanhSachDonVi();
        }

        private event EventHandler updateDonVi;
        public event EventHandler UpdateDonVi
        {
            add { updateDonVi += value; }
            remove { updateDonVi -= value; }
        }

        private event EventHandler deletetDonVi;
        public event EventHandler DeletetDonVi
        {
            add { deletetDonVi += value; }
            remove { deletetDonVi -= value; }
        }


        private void btnCapnhatDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTendonvi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTendonvi.Focus();
                }
                else if (txtSDTdonvi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTendonvi.Focus();
                }
                else if (txtEmaildonvi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTendonvi.Focus();
                }
                else
                {
                    int Madonvi = Convert.ToInt32(txtMadonvi.Text);
                    string Tendonvi = txtTendonvi.Text;
                    string Sdtdonvi = txtSDTdonvi.Text;
                    string Emaildonvi = txtEmaildonvi.Text;

                    if (DonViDAO.Instance.UpdateDonvi(Madonvi, Tendonvi, Sdtdonvi, Emaildonvi))
                    {
                        MessageBox.Show("Thêm Đơn Vị thành công", "Thông Báo");
                        LoadDanhSachDonVi();
                        if (updateDonVi != null)
                            updateDonVi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Sửa đơn vị thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMadonvi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtMadonvi.Focus();
                } 
                else
                {
                    int Madonvi = Convert.ToInt32(txtMadonvi.Text);

                    if(DonViDAO.Instance.DeleteDonvi(Madonvi))
                    {
                        MessageBox.Show("Xóa Đơn Vị thành công", "Thông Báo");
                        LoadDanhSachDonVi();
                        if (deletetDonVi != null)
                            deletetDonVi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn vị bị lỗi !", "Thông Báo");
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

        private void dgDonvi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
