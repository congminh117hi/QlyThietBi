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
using System.Xml.Serialization;

namespace QuanLyThietBi
{
    public partial class DeviceDeliveryForm : Form
    {
        DataTable CTPN;

        public DeviceDeliveryForm()
        {
            InitializeComponent();

            LoadDonVi(cboTendonvi);
            LoadNhanVien(cboTennhanvien);
            LoadThietBi(cboMaTBsudung);
            btnTaophieunhap.Enabled = true;
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

        private void btnTaophieunhap_Click(object sender, EventArgs e)
        {
            try
            {
                txtNgayNhap.Text = DateTime.Now.ToShortDateString();
                cboTennhanvien.Enabled = true;
                cboTendonvi.Enabled = true;
                txtTongtien.Text = "0";
                btnLuuTTPN.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnLuuTTPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboTendonvi.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thông tin đơn vị !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTendonvi.Focus();
                    return;
                }
                else if (cboTendonvi.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thông tin nhân viên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTendonvi.Focus();
                    return;
                }

                btnLuuTTPN.Enabled = false;
                btnXoaphieunhap.Enabled = true;
                cboMaTBsudung.Enabled = true;
                txtSoluong.Enabled = true;
                btnChonTB.Enabled = true;

                int Manhanvien = (cboTennhanvien.SelectedItem as NhanVien).Manhanvien;
                int Madonvi = (cboTendonvi.SelectedItem as DonVi).Madonvi;


                string sql;
                sql = "INSERT dbo.PhieuNhapThietBi ( Ngaynhap, Manhanvien, Madonvi, TongTien, Ghichu ) VALUES ( N'" + LienKetCSDL.ConvertDateTime(txtNgayNhap.Text.Trim()) + "' , "+ Manhanvien +" ,  "+ Madonvi + " , " + txtTongtien.Text + " , N'" + txtGhichu.Text + "')";
                LienKetCSDL.RunSQL(sql);

                string str = "SELECT MAX(Maphieunhap) FROM dbo.PhieuNhapThietBi";
                txtMaHDN.Text = LienKetCSDL.GetFieldValues(str);
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }

        private void btnXoaphieunhap_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;
                sql = "DELETE dbo.PhieuNhapThietBi WHERE Maphieunhap = " + txtMaHDN.Text + "";
                LienKetCSDL.RunSQL(sql);
                btnXoaphieunhap.Enabled = false;
                btnTaophieunhap.Enabled = true;
                txtMaHDN.Text = "";
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
                if (cboMaTBsudung.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn thiết bị sử dụng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaTBsudung.Focus();
                    return;
                }

                int Mathietbisudung = (cboMaTBsudung.SelectedItem as ThietBiSuDung).Mathietbisudung;

                string sqlkt = "SELECT Mathietbisudung FROM dbo.ChiTietPhieuNhap WHERE Maphieunhap = " + txtMaHDN.Text + " AND Mathietbisudung = "+ Mathietbisudung + "";
                if (LienKetCSDL.CheckKey(sqlkt))
                {
                    MessageBox.Show("Thiết bị này đã có, bạn phải chọn thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaTBsudung.Focus();
                    return;
                }

                string sql;
                sql = "INSERT dbo.ChiTietPhieuNhap ( Maphieunhap,  Mathietbisudung, Dongianhap, Soluongnhap, Thanhtiennhap ) VALUES (" + txtMaHDN.Text + ", " + Mathietbisudung + "," + txtDongianhap.Text + ", " + txtSoluong.Text + "," + txtThanhtien.Text + "  )";
                LienKetCSDL.RunSQL(sql);

                double ttn = Convert.ToDouble(LienKetCSDL.GetFieldValues("SELECT TongTien FROM dbo.PhieuNhapThietBi WHERE Maphieunhap =  N'" + txtMaHDN.Text + "'"));
                double ttm = ttn + Convert.ToDouble(txtThanhtien.Text);
                txtTongtien.Text = ttm.ToString();
                string cnttn = "UPDATE dbo.PhieuNhapThietBi SET TongTien = " + txtTongtien.Text + " WHERE Maphieunhap = N'" + txtMaHDN.Text + "'";
                LienKetCSDL.RunSQL(cnttn);

                btnXoaphieunhap.Enabled = false;
                //btnLuuphieuNhap.Enabled = true;
                dgPhieuNhap.Enabled = true;
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
            sql = "SELECT a.Mathietbisudung, a.Tenthietbisudung, b.Soluongnhap, c.Donvitinh,  b.Dongianhap, b.Thanhtiennhap FROM dbo.ThietBiSuDung AS a, dbo.ChiTietPhieuNhap AS b, dbo.ThietBi AS c WHERE a.Mathietbisudung = b.Mathietbisudung AND a.Mathietbi = c.Mathietbi AND b.Maphieunhap = N'" + txtMaHDN.Text + "'";
            CTPN = LienKetCSDL.GetDataToTable(sql);
            dgPhieuNhap.DataSource = CTPN;
            dgPhieuNhap.Columns[0].HeaderText = "Mã Thiết Bị";
            dgPhieuNhap.Columns[1].HeaderText = "Tên Thiết Bị";
            dgPhieuNhap.Columns[2].HeaderText = "Số Lượng";
            dgPhieuNhap.Columns[3].HeaderText = "Đơn Vị Tính";
            dgPhieuNhap.Columns[4].HeaderText = "Đơn Giá";
            dgPhieuNhap.Columns[5].HeaderText = "Thành Tiền";
            dgPhieuNhap.Columns[0].Width = 120;
            dgPhieuNhap.Columns[1].Width = 200;
            dgPhieuNhap.Columns[2].Width = 100;
            dgPhieuNhap.Columns[3].Width = 120;
            dgPhieuNhap.Columns[4].Width = 100;
            dgPhieuNhap.Columns[5].Width = 100;
            dgPhieuNhap.AllowUserToAddRows = false;
            dgPhieuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnLuuphieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string luuhd;
                luuhd = "UPDATE dbo.PhieuNhapThietBi SET TongTien = " + txtTongtien.Text + " WHERE Maphieunhap = " + txtMaHDN.Text + "";
                LienKetCSDL.RunSQL(luuhd);
                btnClose.Enabled = true;
                btnChonTB.Enabled = false;
                //btnLuuphieuNhap.Enabled = false;
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

        private void cboMaTBsudung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaTBsudung.Text == "")
            {
                txtDonvitinh.Text = "";
            }

            int Mathiebisudung = (cboMaTBsudung.SelectedItem as ThietBiSuDung).Mathietbisudung;

            str = "SELECT b.Donvitinh FROM dbo.ThietBiSuDung AS a, dbo.ThietBi AS b WHERE a.Mathietbi = b.Mathietbi AND a.Mathietbisudung =  " + Mathiebisudung + "";
            txtDonvitinh.Text = LienKetCSDL.GetFieldValues(str);

            string str1 = "SELECT a.Dongianhap FROM dbo.ThietBiSuDung AS a, dbo.ThietBi AS b WHERE a.Mathietbi = b.Mathietbi AND a.Mathietbisudung =  " + Mathiebisudung + "";
            txtDongianhap.Text = LienKetCSDL.GetFieldValues(str1);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double thanhtien, soluong, dongia;
                if (txtSoluong.Text == "")
                    soluong = 0;
                else
                    soluong = Convert.ToDouble(txtSoluong.Text);
                if (txtDongianhap.Text == "")
                    dongia = 0;
                else
                    dongia = Convert.ToDouble(txtDongianhap.Text);
                thanhtien = soluong * dongia;
                txtThanhtien.Text = thanhtien.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !", "Thông Báo");
            }
        }
    }
}
