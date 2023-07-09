namespace QuanLyThietBi
{
    partial class DamagedDeviceForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgHuHong = new System.Windows.Forms.DataGridView();
            this.btnTaophieuSC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChonTBSC = new System.Windows.Forms.Button();
            this.cboTenTBsudung = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgaySC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaphieuSC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuTTPSC = new System.Windows.Forms.Button();
            this.cboTenDonVi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoaTTPSC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHuHong)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgHuHong);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(359, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 335);
            this.flowLayoutPanel1.TabIndex = 48;
            // 
            // dgHuHong
            // 
            this.dgHuHong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHuHong.Location = new System.Drawing.Point(3, 3);
            this.dgHuHong.Name = "dgHuHong";
            this.dgHuHong.RowHeadersWidth = 102;
            this.dgHuHong.Size = new System.Drawing.Size(710, 334);
            this.dgHuHong.TabIndex = 0;
            this.dgHuHong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHuHong_CellContentClick);
            // 
            // btnTaophieuSC
            // 
            this.btnTaophieuSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaophieuSC.Location = new System.Drawing.Point(22, 131);
            this.btnTaophieuSC.Name = "btnTaophieuSC";
            this.btnTaophieuSC.Size = new System.Drawing.Size(99, 51);
            this.btnTaophieuSC.TabIndex = 54;
            this.btnTaophieuSC.Text = "Tạo Phiếu";
            this.btnTaophieuSC.UseVisualStyleBackColor = true;
            this.btnTaophieuSC.Click += new System.EventHandler(this.btnTaophieuSC_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txtGhichu);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnChonTBSC);
            this.panel4.Controls.Add(this.cboTenTBsudung);
            this.panel4.Controls.Add(this.txtDonvitinh);
            this.panel4.Controls.Add(this.txtSoluong);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(6, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 220);
            this.panel4.TabIndex = 47;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(173, 84);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(170, 87);
            this.txtGhichu.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ghi chú:";
            // 
            // btnChonTBSC
            // 
            this.btnChonTBSC.Enabled = false;
            this.btnChonTBSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonTBSC.Location = new System.Drawing.Point(6, 162);
            this.btnChonTBSC.Name = "btnChonTBSC";
            this.btnChonTBSC.Size = new System.Drawing.Size(99, 51);
            this.btnChonTBSC.TabIndex = 19;
            this.btnChonTBSC.Text = "Chọn Thiết Bị";
            this.btnChonTBSC.UseVisualStyleBackColor = true;
            this.btnChonTBSC.Click += new System.EventHandler(this.btnChonTBSC_Click);
            // 
            // cboTenTBsudung
            // 
            this.cboTenTBsudung.FormattingEnabled = true;
            this.cboTenTBsudung.Location = new System.Drawing.Point(173, 9);
            this.cboTenTBsudung.Name = "cboTenTBsudung";
            this.cboTenTBsudung.Size = new System.Drawing.Size(170, 21);
            this.cboTenTBsudung.TabIndex = 18;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(173, 47);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(103, 20);
            this.txtSoluong.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 18);
            this.label20.TabIndex = 8;
            this.label20.Text = "Số lượng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Tên thiết bị sử dụng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtNgaySC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaphieuSC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 89);
            this.panel1.TabIndex = 51;
            // 
            // txtNgaySC
            // 
            this.txtNgaySC.Enabled = false;
            this.txtNgaySC.Location = new System.Drawing.Point(168, 54);
            this.txtNgaySC.Name = "txtNgaySC";
            this.txtNgaySC.Size = new System.Drawing.Size(170, 20);
            this.txtNgaySC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Lập:";
            // 
            // txtMaphieuSC
            // 
            this.txtMaphieuSC.Enabled = false;
            this.txtMaphieuSC.Location = new System.Drawing.Point(168, 15);
            this.txtMaphieuSC.Name = "txtMaphieuSC";
            this.txtMaphieuSC.Size = new System.Drawing.Size(170, 20);
            this.txtMaphieuSC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu:";
            // 
            // btnLuuTTPSC
            // 
            this.btnLuuTTPSC.Enabled = false;
            this.btnLuuTTPSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTPSC.Location = new System.Drawing.Point(127, 131);
            this.btnLuuTTPSC.Name = "btnLuuTTPSC";
            this.btnLuuTTPSC.Size = new System.Drawing.Size(99, 51);
            this.btnLuuTTPSC.TabIndex = 55;
            this.btnLuuTTPSC.Text = "Lưu Thông Tin";
            this.btnLuuTTPSC.UseVisualStyleBackColor = true;
            this.btnLuuTTPSC.Click += new System.EventHandler(this.btnLuuTTPSC_Click);
            // 
            // cboTenDonVi
            // 
            this.cboTenDonVi.Enabled = false;
            this.cboTenDonVi.FormattingEnabled = true;
            this.cboTenDonVi.Location = new System.Drawing.Point(137, 15);
            this.cboTenDonVi.Name = "cboTenDonVi";
            this.cboTenDonVi.Size = new System.Drawing.Size(170, 21);
            this.cboTenDonVi.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Đơn vị:";
            // 
            // btnXoaTTPSC
            // 
            this.btnXoaTTPSC.Enabled = false;
            this.btnXoaTTPSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTTPSC.Location = new System.Drawing.Point(232, 131);
            this.btnXoaTTPSC.Name = "btnXoaTTPSC";
            this.btnXoaTTPSC.Size = new System.Drawing.Size(99, 51);
            this.btnXoaTTPSC.TabIndex = 56;
            this.btnXoaTTPSC.Text = "Xóa Phiếu";
            this.btnXoaTTPSC.UseVisualStyleBackColor = true;
            this.btnXoaTTPSC.Click += new System.EventHandler(this.btnXoaTTPSC_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cboTenDonVi);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(359, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 49);
            this.panel3.TabIndex = 53;
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.Enabled = false;
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(173, 16);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(170, 21);
            this.cboTenNhanVien.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên Nhân Viên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboTenNhanVien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(685, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 49);
            this.panel2.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(137, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "BÁO CÁO THIẾT BỊ HƯ HỎNG";
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Enabled = false;
            this.txtDonvitinh.Location = new System.Drawing.Point(282, 47);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(61, 20);
            this.txtDonvitinh.TabIndex = 16;
            this.txtDonvitinh.TextChanged += new System.EventHandler(this.txtDonvitinh_TextChanged);
            // 
            // DamagedDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1077, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnTaophieuSC);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuuTTPSC);
            this.Controls.Add(this.btnXoaTTPSC);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DamagedDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu báo cáo thiết bị hư hỏng";
            this.Load += new System.EventHandler(this.DamagedDeviceForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHuHong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgHuHong;
        private System.Windows.Forms.Button btnTaophieuSC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChonTBSC;
        private System.Windows.Forms.ComboBox cboTenTBsudung;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNgaySC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaphieuSC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuuTTPSC;
        private System.Windows.Forms.ComboBox cboTenDonVi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoaTTPSC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonvitinh;
    }
}