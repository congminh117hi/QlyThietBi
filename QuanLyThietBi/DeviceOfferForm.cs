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
    public partial class DeviceOfferForm : Form
    {
        BindingSource danhsach = new BindingSource();
        public DeviceOfferForm()
        {
            InitializeComponent();

            dgPhieuDX.DataSource = danhsach;
            LoadDanhSach();
        }

        void LoadDanhSach()
        {
            danhsach.DataSource = PhieuDeXuatDAO.Instance.GetListPhieuDeXuat();
        }

        private void dgPhieuDX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
