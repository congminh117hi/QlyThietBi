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
    public partial class AddDUsedForm : Form
    {
        public AddDUsedForm()
        {
            InitializeComponent();

            LoadThietBi(cboMathietbi);
        }

        private event EventHandler insertThietBiSuDung;
        public event EventHandler InsertThietBiSuDung
        {
            add { insertThietBiSuDung += value; }
            remove { insertThietBiSuDung -= value; }
        }

        void LoadThietBi(ComboBox cb)
        {
            cb.DataSource = ThietBiDAO.Instance.GetListThietBi();
            cb.DisplayMember = "Tenthietbi";
        }

        private void btnThemTBsudung_Click(object sender, EventArgs e)
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
                    int Mathietbi = (cboMathietbi.SelectedItem as ThietBi).Mathietbi;
                    float Dongianhap = (float)Convert.ToDouble(txtDongianhap.Text);
                    DateTime Ngaynhap = dtpNgaynhap.Value;
                    string Tinhtrangthietbi = txtTinhtrangTB.Text;
                    string Ghichu = txtGhichu.Text;
                    string Tenthietbisudung = txtTenTBsudung.Text;

                    if (ThietBiSuDungDAO.Instance.InsertThietbisudung(Mathietbi, Dongianhap, Ngaynhap, Tinhtrangthietbi, Ghichu, Tenthietbisudung))
                    {
                        MessageBox.Show("Thêm Thiết Bị Sử Dụng thành công", "Thông Báo");
                        if (insertThietBiSuDung != null)
                            insertThietBiSuDung(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thiết Bị Sử Dụng thất bại !", "Thông Báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
