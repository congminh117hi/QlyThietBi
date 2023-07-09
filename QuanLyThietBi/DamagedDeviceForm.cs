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
    public partial class DamagedDeviceForm : Form
    {
        DataTable CTPN;

        public DamagedDeviceForm()
        {
            InitializeComponent();

            LoadDonVi(cboTenDonVi);
            LoadNhanVien(cboTenNhanVien);
            LoadThietBi(cboTenTBsudung);
        }

        void LoadDonVi(ComboBox cb)
        {
            cb.DataSource = DonViDAO.Instance.GetListDonVi();
            cb.DisplayMember = "Tendonvi";
        }

        void LoadNhanVien(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cb.DisplayMember = "Tennhanvien";
        }

        void LoadThietBi(ComboBox cb)
        {
            cb.DataSource = ThietBiSuDungDAO.Instance.GetListTBSD();
            cb.DisplayMember = "Tenthietbisudung";
        }

        private void btnTaophieuSC_Click(object sender, EventArgs e)
        {
            try
            {
                txtNgaySC.Text = DateTime.Now.ToShortDateString();
                cboTenNhanVien.Enabled = true;
                cboTenDonVi.Enabled = true;
                btnLuuTTPSC.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnLuuTTPSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenDonVi.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thông tin đơn vị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTenDonVi.Focus();
                    return;
                }
                else if (cboTenNhanVien.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thông tin nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTenNhanVien.Focus();
                    return;
                }

                btnLuuTTPSC.Enabled = false;
                btnTaophieuSC.Enabled = false;
                btnXoaTTPSC.Enabled = true;
                cboTenTBsudung.Enabled = true;
                txtSoluong.Enabled = true;
                btnChonTBSC.Enabled = true;

                string Ghichu = txtGhichu.Text;

                int Manhanvien = (cboTenNhanVien.SelectedItem as NhanVien).Manhanvien;
                int Madonvi = (cboTenDonVi.SelectedItem as DonVi).Madonvi;


                string sql;
                sql = "INSERT dbo.PhieuSuaChua ( Manhanvien,  Madonvi,  Ngaysuachua , Ghichu ) VALUES ( " + Manhanvien + " ,  " + Madonvi + " ,  N'" + LienKetCSDL.ConvertDateTime(txtNgaySC.Text.Trim()) + "' , N'" + Ghichu + "')";
                LienKetCSDL.RunSQL(sql);

                string str = "SELECT MAX(Maphieusuachua) FROM dbo.PhieuSuaChua";
                txtMaphieuSC.Text = LienKetCSDL.GetFieldValues(str);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaTTPSC_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "DELETE dbo.PhieuSuaChua WHERE Maphieusuachua = " + txtMaphieuSC.Text + "";
                LienKetCSDL.RunSQL(sql);
                btnXoaTTPSC.Enabled = false;
                btnTaophieuSC.Enabled = true;
                txtMaphieuSC.Text = "";
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnChonTBSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTenTBsudung.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thiết bị sử dụng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTenTBsudung.Focus();
                    return;
                }

                int Mathietbisudung = (cboTenTBsudung.SelectedItem as ThietBiSuDung).Mathietbisudung;

                string sqlkt = "SELECT Mathietbisudung FROM dbo.ChiTietPhieuSuaChua WHERE Maphieusuachua = " + txtMaphieuSC.Text + " AND Mathietbisudung = " + Mathietbisudung + "";
                if (LienKetCSDL.CheckKey(sqlkt))
                {
                    MessageBox.Show("Thiết bị này đã có, bạn phải chọn thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTenTBsudung.Focus();
                    return;
                }

                string sql;
                sql = "INSERT dbo.ChiTietPhieuSuaChua( Maphieusuachua,  Mathietbisudung, Soluongsuachua) VALUES (" + txtMaphieuSC.Text + ", " + Mathietbisudung + ", " + txtSoluong.Text + " )";
                LienKetCSDL.RunSQL(sql);

                btnXoaTTPSC.Enabled = false;
                //btnGuiPSC.Enabled = true;
                dgHuHong.Enabled = true;
                LoadDataGridView();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.Mathietbisudung, a.Tenthietbisudung , b.Soluongsuachua, c.Donvitinh FROM dbo.ThietBiSuDung AS a,  dbo.ChiTietPhieuSuaChua AS b, dbo.ThietBi AS c WHERE a.Mathietbisudung = b.Mathietbisudung AND a.Mathietbi = c.Mathietbi AND b.Maphieusuachua = N'" + txtMaphieuSC.Text + "'";
            CTPN = LienKetCSDL.GetDataToTable(sql);
            dgHuHong.DataSource = CTPN;
            dgHuHong.Columns[0].HeaderText = "Mã Thiết Bị";
            dgHuHong.Columns[1].HeaderText = "Tên Thiết Bị";
            dgHuHong.Columns[2].HeaderText = "Số Lượng";
            dgHuHong.Columns[3].HeaderText = "Đơn Vị Tính";
            dgHuHong.Columns[0].Width = 120;
            dgHuHong.Columns[1].Width = 200;
            dgHuHong.Columns[2].Width = 100;
            dgHuHong.Columns[3].Width = 120;
            dgHuHong.AllowUserToAddRows = false;
            dgHuHong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnGuiPSC_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void dgHuHong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DamagedDeviceForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDonvitinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
