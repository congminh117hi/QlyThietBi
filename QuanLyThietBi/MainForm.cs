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
    public partial class MainForm : Form
    {

        private DTO.TaiKhoan kiemtrataikhoan;

        public DTO.TaiKhoan Kiemtrataikhoan
        {
            get { return kiemtrataikhoan; }
            set { kiemtrataikhoan = value; ChangeTaiKhoan(kiemtrataikhoan.Tentaikhoan); }
        }

        public MainForm(DTO.TaiKhoan tk)
        {
            InitializeComponent();

            this.Kiemtrataikhoan = tk;
        }



        //public FDeviceManagement(TaiKhoan tk)
        //{
        //    InitializeComponent();
        //    this.Kiemtrataikhoan = tk;
        //}

        void ChangeTaiKhoan(string Tentaikhoan)
        {
            if (Tentaikhoan == "Member")
            {
                adminToolStripMenuItem.Enabled = false;
            }
        }




        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaiKhoan form = new TaiKhoan();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GiaoVien form = new GiaoVien();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BoMon form = new BoMon();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýThiếtBịToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhapThietBi form = new NhapThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void quảnLýThiếtBịSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThietBiSuDung form = new ThietBiSuDung();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void phiếuThanhLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loạiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiThietBi form = new LoaiThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void đềXuấtThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeXuatThietBi form = new DeXuatThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void theoDõiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheoDoiThietBi form = new TheoDoiThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuNhapThietBi form = new PhieuNhapThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopDeXuatThietBi form = new TongHopDeXuatThietBi();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void báoCáoHưHỏngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopThietBiHuHong form = new TongHopThietBiHuHong();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoThietBiHuHong form = new BaoCaoThietBiHuHong();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{

		}
	}
}
