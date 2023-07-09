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
    public partial class AddDeviceForm : Form
    {
        public AddDeviceForm()
        {
            InitializeComponent();
            LoadTenLoaiThietBi(cboTenLoaiTB);
        }

        private event EventHandler insertThietBi;
        public event EventHandler InsertThietBi
        {
            add { insertThietBi += value; }
            remove { insertThietBi -= value; }
        }

        void LoadTenLoaiThietBi(ComboBox cb)
        {
            cb.DataSource = LoaiThietBiDAO.Instance.GetListLoaiThietBi();
            cb.DisplayMember = "Tenloaithietbi";
        }

        private void btnThemthietbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenLoaiTB.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    cboTenLoaiTB.Focus();
                }
                else if (txtTenthietbi.Text == "")
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
                    int Maloaithietbi = (cboTenLoaiTB.SelectedItem as LoaiThietBi).Maloaithietbi;
                    string Tenthietbi = txtTenthietbi.Text;
                    string Donvitinh = txtDonvitinh.Text;
                    string Ghichu = txtGhichu.Text;

                    if (ThietBiDAO.Instance.InsertThietbi(Tenthietbi, Donvitinh, Ghichu, Maloaithietbi))
                    {
                        MessageBox.Show("Thêm Thiết Bị thành công", "Thông Báo");
                        if (insertThietBi != null)
                            insertThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thiết Bị thất bại !", "Thông Báo");
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
