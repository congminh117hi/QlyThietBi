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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DAO.LienKetCSDL.Connect();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string TenDangNhap = txtTenTaiKhoan.Text;
            string MatKhau = txtmatKhau.Text;
            if (Login(TenDangNhap, MatKhau))
            {
                DTO.TaiKhoan kiemtrataikhoan = TaiKhoanDAO.Instance.TTTK(TenDangNhap);

                MainForm form = new MainForm(kiemtrataikhoan);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu !", "Thông Báo");
            }
        }

        bool Login(string TenDangNhap, string MatKhau)
        {
            return TaiKhoanDAO.Instance.Login(TenDangNhap, MatKhau);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "Thông báo!" , MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true ; 
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
