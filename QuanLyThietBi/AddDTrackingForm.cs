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
    public partial class AddDTrackingForm : Form
    {
        public AddDTrackingForm()
        {
            InitializeComponent();
            LoadThietBi(cboTenTBsudung);
            LoadDonVi(cboTenDVsudung);
        }

        private event EventHandler insertTheoDoiThietBi;
        public event EventHandler InsertTheoDoiThietBi
        {
            add { insertTheoDoiThietBi += value; }
            remove { insertTheoDoiThietBi -= value; }
        }

        void LoadThietBi(ComboBox cb)
        {
            cb.DataSource = ThietBiSuDungDAO.Instance.GetListTBSD();
            cb.DisplayMember = "Tenthietbisudung";
        }

        void LoadDonVi(ComboBox cb)
        {
            cb.DataSource = DonViDAO.Instance.GetListDonVi();
            cb.DisplayMember = "Tendonvi";
        }

        private void btnThemtheodoiTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenTBsudung.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    cboTenTBsudung.Focus();
                }
                else if (cboTenDVsudung.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    cboTenDVsudung.Focus();
                }
                else if (txtTinhtrangTB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTinhtrangTB.Focus();
                }
                else
                {
                    int Mathietbisudung = (cboTenTBsudung.SelectedItem as ThietBiSuDung).Mathietbisudung;
                    int Madonvi = (cboTenDVsudung.SelectedItem as DonVi).Madonvi;
                    DateTime Ngaybatdausudung = dtpNgaybatdauSD.Value;
                    DateTime Ngaytrathietbi = dtpNgaytra.Value;
                    string Tinhtrangthietbi = txtTinhtrangTB.Text;
                    string Ghichu = txtGhichu.Text;

                    if (TheoDoiThietBiDAO.Instance.InsertTheodoithietbi(Mathietbisudung, Madonvi, Ngaybatdausudung, Ngaytrathietbi, Tinhtrangthietbi, Ghichu))
                    {
                        MessageBox.Show("Thêm Theo Dõi Thiết Bị thành công", "Thông Báo");
                        if (insertTheoDoiThietBi != null)
                            insertTheoDoiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm Theo Dõi Thiết Bị thất bại !", "Thông Báo");
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
