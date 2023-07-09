namespace QuanLyThietBi
{
    partial class AccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnLuuTTTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMataikhoan = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLoaitaikhoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Mataikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(328, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 166);
            this.panel1.TabIndex = 16;
            // 
            // dgTaiKhoan
            // 
            this.dgTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mataikhoan,
            this.Tennhanvien,
            this.Tentaikhoan,
            this.Tendangnhap,
            this.Matkhau});
            this.dgTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.dgTaiKhoan.Name = "dgTaiKhoan";
            this.dgTaiKhoan.RowHeadersWidth = 102;
            this.dgTaiKhoan.Size = new System.Drawing.Size(614, 160);
            this.dgTaiKhoan.TabIndex = 0;
            this.dgTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaiKhoan_CellContentClick);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.Color.White;
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Orange;
            this.btnXoaTK.Location = new System.Drawing.Point(541, 212);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(99, 51);
            this.btnXoaTK.TabIndex = 19;
            this.btnXoaTK.Text = "Xóa Tài Khoản";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnLuuTTTK
            // 
            this.btnLuuTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTTK.Location = new System.Drawing.Point(436, 212);
            this.btnLuuTTTK.Name = "btnLuuTTTK";
            this.btnLuuTTTK.Size = new System.Drawing.Size(99, 51);
            this.btnLuuTTTK.TabIndex = 18;
            this.btnLuuTTTK.Text = "Sửa Thông Tin\r\nTài Khoản\r\n";
            this.btnLuuTTTK.UseVisualStyleBackColor = true;
            this.btnLuuTTTK.Click += new System.EventHandler(this.btnLuuTTTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Location = new System.Drawing.Point(331, 212);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(99, 51);
            this.btnThemTK.TabIndex = 17;
            this.btnThemTK.Text = "Thêm\r\nTài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTenNhanVien);
            this.panel3.Controls.Add(this.txtMatkhau);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtMataikhoan);
            this.panel3.Controls.Add(this.txtTendangnhap);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtLoaitaikhoan);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(5, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 223);
            this.panel3.TabIndex = 17;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(141, 58);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(170, 20);
            this.txtTenNhanVien.TabIndex = 11;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(141, 175);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(170, 20);
            this.txtMatkhau.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mật Khẩu:";
            // 
            // txtMataikhoan
            // 
            this.txtMataikhoan.Enabled = false;
            this.txtMataikhoan.Location = new System.Drawing.Point(141, 18);
            this.txtMataikhoan.Name = "txtMataikhoan";
            this.txtMataikhoan.Size = new System.Drawing.Size(170, 20);
            this.txtMataikhoan.TabIndex = 8;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(141, 136);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(170, 20);
            this.txtTendangnhap.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên Nhân Viên:";
            // 
            // txtLoaitaikhoan
            // 
            this.txtLoaitaikhoan.Location = new System.Drawing.Point(141, 98);
            this.txtLoaitaikhoan.Name = "txtLoaitaikhoan";
            this.txtLoaitaikhoan.Size = new System.Drawing.Size(170, 20);
            this.txtLoaitaikhoan.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Loại Tài Khoản:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Đăng Nhập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Tài Khoản:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(846, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "TÀI KHOẢN";
            // 
            // Mataikhoan
            // 
            this.Mataikhoan.DataPropertyName = "Mataikhoan";
            this.Mataikhoan.HeaderText = "Mã tài khoản";
            this.Mataikhoan.Name = "Mataikhoan";
            // 
            // Tennhanvien
            // 
            this.Tennhanvien.DataPropertyName = "Tennhanvien";
            this.Tennhanvien.HeaderText = "Tên nhân viên";
            this.Tennhanvien.Name = "Tennhanvien";
            // 
            // Tentaikhoan
            // 
            this.Tentaikhoan.DataPropertyName = "Tentaikhoan";
            this.Tentaikhoan.HeaderText = "Loại tài khoản";
            this.Tentaikhoan.Name = "Tentaikhoan";
            // 
            // Tendangnhap
            // 
            this.Tendangnhap.DataPropertyName = "Tendangnhap";
            this.Tendangnhap.HeaderText = "Tên đăng nhập";
            this.Tendangnhap.Name = "Tendangnhap";
            // 
            // Matkhau
            // 
            this.Matkhau.DataPropertyName = "Matkhau";
            this.Matkhau.HeaderText = "Mật khẩu";
            this.Matkhau.Name = "Matkhau";
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(947, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnLuuTTTK);
            this.Controls.Add(this.btnThemTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản đăng nhập";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgTaiKhoan;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnLuuTTTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMataikhoan;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLoaitaikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mataikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
    }
}