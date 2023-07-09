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
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            LoadTenDonVi(cboTendonvi);
        }

        void LoadTenDonVi(ComboBox cb)
        {
            cb.DataSource = DonViDAO.Instance.GetListDonVi();
            cb.DisplayMember = "Tendonvi";
        }

        private event EventHandler insertNhanVien;
        public event EventHandler InsertNhanVien
        {
            add { insertNhanVien += value; }
            remove { insertNhanVien -= value; }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTendonvi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    cboTendonvi.Focus();
                }
                else if (txtTennhanvien.Text == "")
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
                    int Madonvi = (cboTendonvi.SelectedItem as DonVi).Madonvi;
                    string Tennhanvien = txtTennhanvien.Text;
                    string Chucvu = txtChucvu.Text;
                    string Sdtnhanvien = txtSDT.Text;
                    string Emailnhanvien = txtEmailNV.Text;

                    if (NhanVienDAO.Instance.InsertNhanvien(Tennhanvien, Chucvu, Sdtnhanvien, Emailnhanvien, Madonvi))
                    {
                        MessageBox.Show("Thêm Nhân Viên thành công", "Thông Báo");
                        if (insertNhanVien != null)
                            insertNhanVien(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại !", "Thông Báo");
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
