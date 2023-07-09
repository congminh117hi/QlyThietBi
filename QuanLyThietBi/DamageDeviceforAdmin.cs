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
    public partial class DamageDeviceforAdmin : Form
    {

        BindingSource danhsach = new BindingSource();

        public DamageDeviceforAdmin()
        {

            InitializeComponent();
            dgHuHong.DataSource = danhsach;
            LoadDanhSach();
        }

        void LoadDanhSach()
        {
            danhsach.DataSource = PhieuSuaChuaDAO.Instance.GetListPhieuSuaChua();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
