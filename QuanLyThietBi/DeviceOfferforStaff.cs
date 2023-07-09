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
    public partial class DeviceOfferforStaff : Form
    {
        BindingSource danhsach = new BindingSource();
        DataTable CTPDX;

        public DeviceOfferforStaff()
        {
            InitializeComponent();

            LoadDonVi(cboTenDonVi);
            LoadNhanVien(cbTenNhanVien);
            LoadThietBi(cboMaTB);

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
            cb.DataSource = ThietBiDAO.Instance.GetListThietBi();
            cb.DisplayMember = "Tenthietbi";
        }

        private void dgPhieuDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeviceOfferforStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnTaophieuDX_Click(object sender, EventArgs e)
        {
            try
            {
                txtNgayNhap.Text = DateTime.Now.ToShortDateString();
                cbTenNhanVien.Enabled = true;
                cboTenDonVi.Enabled = true;
                btnLuuphieuDX.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnLuuphieuDX_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (cboTenDonVi.Text == "")
            {
                    MessageBox.Show("Bạn chưa chọn thông tin đơn vị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTenDonVi.Focus();
                    return;
                }
                else if (cbTenNhanVien.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thông tin nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbTenNhanVien.Focus();
                    return;
                }

                btnLuuphieuDX.Enabled = false;
                btnTaophieuDX.Enabled = false;
                btnXoaphieuDX.Enabled = true;
                cboMaTB.Enabled = true;
                txtSoluong.Enabled = true;
                btnChonTB.Enabled = true;

                string Ghichu = txtGhichu.Text;

                int Manhanvien = (cbTenNhanVien.SelectedItem as NhanVien).Manhanvien;
                int Madonvi = (cboTenDonVi.SelectedItem as DonVi).Madonvi;


                string sql;
                sql = "INSERT dbo.PhieuDeXuat ( Manhanvien, Madonvi,  Ngaydexuat, Ghichu ) VALUES ( " + Manhanvien + " ,  " + Madonvi + " ,  N'" + LienKetCSDL.ConvertDateTime(txtNgayNhap.Text.Trim()) + "' , N'" + Ghichu + "')";
                LienKetCSDL.RunSQL(sql);

                string str = "SELECT MAX(Maphieudexuat) FROM dbo.PhieuDeXuat";
                txtMaphieuDX.Text = LienKetCSDL.GetFieldValues(str);
            //}
            //catch
            //{
            //    MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            //}
        }

        private void btnXoaphieuDX_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "DELETE dbo.PhieuDeXuat WHERE Maphieudexuat = " + txtMaphieuDX.Text + "";
                LienKetCSDL.RunSQL(sql);
                btnXoaphieuDX.Enabled = false;
                btnTaophieuDX.Enabled = true;
                txtMaphieuDX.Text = "";
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnChonTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMaTB.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thiết bị sử dụng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaTB.Focus();
                    return;
                }

                int Mathietbi = (cboMaTB.SelectedItem as ThietBi).Mathietbi;

                string sqlkt = "SELECT Mathietbi FROM dbo.ChiTietPhieuDeXuat WHERE Maphieudexuat = " + txtMaphieuDX.Text + " AND Mathietbi = " + Mathietbi + "";
                if (LienKetCSDL.CheckKey(sqlkt))
                {
                    MessageBox.Show("Thiết bị này đã có, bạn phải chọn thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaTB.Focus();
                    return;
                }

                string sql;
                sql = "INSERT dbo.ChiTietPhieuDeXuat( Maphieudexuat, Mathietbi, Soluong ) VALUES (" + txtMaphieuDX.Text + ", " + Mathietbi + ", " + txtSoluong.Text + " )";
                LienKetCSDL.RunSQL(sql);

                btnXoaphieuDX.Enabled = false;
                //btnGuiphieuDX.Enabled = true;
                dgPhieuDX.Enabled = true;
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
            sql = "SELECT a.Mathietbi, a.Tenthietbi , b.Soluong, a.Donvitinh FROM dbo.ThietBi AS a,  dbo.ChiTietPhieuDeXuat AS b WHERE a.Mathietbi = b.Mathietbi AND b.Maphieudexuat = N'" + txtMaphieuDX.Text + "'";
            CTPDX = LienKetCSDL.GetDataToTable(sql);
            dgPhieuDX.DataSource = CTPDX;
            dgPhieuDX.Columns[0].HeaderText = "Mã Thiết Bị";
            dgPhieuDX.Columns[1].HeaderText = "Tên Thiết Bị";
            dgPhieuDX.Columns[2].HeaderText = "Số Lượng";
            dgPhieuDX.Columns[3].HeaderText = "Đơn Vị Tính";
            dgPhieuDX.Columns[0].Width = 120;
            dgPhieuDX.Columns[1].Width = 200;
            dgPhieuDX.Columns[2].Width = 100;
            dgPhieuDX.Columns[3].Width = 120;
            dgPhieuDX.AllowUserToAddRows = false;
            dgPhieuDX.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonvitinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
