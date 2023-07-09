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
    public partial class AddEmployerUnitForm : Form
    {
        public AddEmployerUnitForm()
        {
            InitializeComponent();
        }

        private event EventHandler insertDonVi;
        public event EventHandler InsertDonVi
        {
            add { insertDonVi += value; }
            remove { insertDonVi -= value; }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
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
                    string Tendonvi = txtTendonvi.Text;
                    string Sdtdonvi = txtSDTdonvi.Text;
                    string Emaildonvi = txtEmaildonvi.Text;

                    if (DonViDAO.Instance.InsertDonvi(Tendonvi, Sdtdonvi, Emaildonvi))
                    {
                        MessageBox.Show("Thêm Đơn Vị thành công", "Thông Báo");
                        if (insertDonVi != null)
                            insertDonVi(this, new EventArgs());
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

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
