using QuanLyThietBi.DAO;
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
    public partial class AddTODForm : Form
    {
        public AddTODForm()
        {
            InitializeComponent();
        }

        private event EventHandler insertLoaiThietBi;
        public event EventHandler InsertLoaiThietBi
        {
            add { insertLoaiThietBi += value; }
            remove { insertLoaiThietBi -= value; }
        }

        private void btnThemLTB_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenloaithietbi.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông Báo");
                    txtTenloaithietbi.Focus();
                }
                else
                {
                    string Tenloaithietbi = txtTenloaithietbi.Text;

                    if (LoaiThietBiDAO.Instance.InsertLoaithietbi(Tenloaithietbi))
                    {
                        MessageBox.Show("Thêm Loại Thiết Bị thành công", "Thông Báo");
                        if (insertLoaiThietBi != null)
                            insertLoaiThietBi(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Thêm Loại Thiết Bị thất bại !", "Thông Báo");
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
