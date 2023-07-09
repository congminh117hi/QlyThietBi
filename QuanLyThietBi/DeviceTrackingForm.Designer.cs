namespace QuanLyThietBi
{
    partial class DeviceTrackingForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgTheodoiTB = new System.Windows.Forms.DataGridView();
            this.btnCapnhattheodoiTB = new System.Windows.Forms.Button();
            this.btnXoatheodoiTB = new System.Windows.Forms.Button();
            this.btnThemtheodoiTB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaybatdauSD = new System.Windows.Forms.DateTimePicker();
            this.txtTinhtrangTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDVsudung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatheodoiTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenthietbi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Matheodoithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthietbisudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaybatdausudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytrathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrangthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheodoiTB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgTheodoiTB);
            this.panel5.Location = new System.Drawing.Point(460, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(693, 395);
            this.panel5.TabIndex = 38;
            // 
            // dgTheodoiTB
            // 
            this.dgTheodoiTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheodoiTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matheodoithietbi,
            this.Tendonvi,
            this.Tenthietbisudung,
            this.Ngaybatdausudung,
            this.Ngaytrathietbi,
            this.Tinhtrangthietbi,
            this.Ghichu});
            this.dgTheodoiTB.Location = new System.Drawing.Point(0, 0);
            this.dgTheodoiTB.Name = "dgTheodoiTB";
            this.dgTheodoiTB.RowHeadersWidth = 92;
            this.dgTheodoiTB.Size = new System.Drawing.Size(693, 395);
            this.dgTheodoiTB.TabIndex = 0;
            // 
            // btnCapnhattheodoiTB
            // 
            this.btnCapnhattheodoiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhattheodoiTB.Location = new System.Drawing.Point(113, 382);
            this.btnCapnhattheodoiTB.Name = "btnCapnhattheodoiTB";
            this.btnCapnhattheodoiTB.Size = new System.Drawing.Size(99, 51);
            this.btnCapnhattheodoiTB.TabIndex = 37;
            this.btnCapnhattheodoiTB.Text = "Sửa Thông Tin\r\nTheo Dõi Thiết Bị";
            this.btnCapnhattheodoiTB.UseVisualStyleBackColor = true;
            this.btnCapnhattheodoiTB.Click += new System.EventHandler(this.btnCapnhattheodoiTB_Click);
            // 
            // btnXoatheodoiTB
            // 
            this.btnXoatheodoiTB.BackColor = System.Drawing.Color.White;
            this.btnXoatheodoiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatheodoiTB.ForeColor = System.Drawing.Color.Orange;
            this.btnXoatheodoiTB.Location = new System.Drawing.Point(218, 382);
            this.btnXoatheodoiTB.Name = "btnXoatheodoiTB";
            this.btnXoatheodoiTB.Size = new System.Drawing.Size(99, 51);
            this.btnXoatheodoiTB.TabIndex = 36;
            this.btnXoatheodoiTB.Text = "Xóa\r\nTheo Dõi Thiết Bị";
            this.btnXoatheodoiTB.UseVisualStyleBackColor = false;
            this.btnXoatheodoiTB.Click += new System.EventHandler(this.btnXoatheodoiTB_Click);
            // 
            // btnThemtheodoiTB
            // 
            this.btnThemtheodoiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtheodoiTB.Location = new System.Drawing.Point(8, 382);
            this.btnThemtheodoiTB.Name = "btnThemtheodoiTB";
            this.btnThemtheodoiTB.Size = new System.Drawing.Size(99, 51);
            this.btnThemtheodoiTB.TabIndex = 35;
            this.btnThemtheodoiTB.Text = "Thêm\r\nTheo Dõi Thiết Bị";
            this.btnThemtheodoiTB.UseVisualStyleBackColor = true;
            this.btnThemtheodoiTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtGhichu);
            this.panel1.Controls.Add(this.dtpNgaytra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpNgaybatdauSD);
            this.panel1.Controls.Add(this.txtTinhtrangTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTenDVsudung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMatheodoiTB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(5, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 295);
            this.panel1.TabIndex = 34;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(261, 199);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(170, 87);
            this.txtGhichu.TabIndex = 24;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.Location = new System.Drawing.Point(261, 127);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(170, 20);
            this.dtpNgaytra.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày Trả Thiết Bị:";
            // 
            // dtpNgaybatdauSD
            // 
            this.dtpNgaybatdauSD.Location = new System.Drawing.Point(261, 88);
            this.dtpNgaybatdauSD.Name = "dtpNgaybatdauSD";
            this.dtpNgaybatdauSD.Size = new System.Drawing.Size(170, 20);
            this.dtpNgaybatdauSD.TabIndex = 18;
            // 
            // txtTinhtrangTB
            // 
            this.txtTinhtrangTB.Location = new System.Drawing.Point(261, 164);
            this.txtTinhtrangTB.Name = "txtTinhtrangTB";
            this.txtTinhtrangTB.Size = new System.Drawing.Size(170, 20);
            this.txtTinhtrangTB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ghi Chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tình Trạng Thiết Bị:";
            // 
            // txtTenDVsudung
            // 
            this.txtTenDVsudung.Enabled = false;
            this.txtTenDVsudung.Location = new System.Drawing.Point(261, 52);
            this.txtTenDVsudung.Name = "txtTenDVsudung";
            this.txtTenDVsudung.Size = new System.Drawing.Size(170, 20);
            this.txtTenDVsudung.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày Bắt Đầu Sử Dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Đơn Vị Sử Dụng:";
            // 
            // txtMatheodoiTB
            // 
            this.txtMatheodoiTB.Enabled = false;
            this.txtMatheodoiTB.Location = new System.Drawing.Point(261, 17);
            this.txtMatheodoiTB.Name = "txtMatheodoiTB";
            this.txtMatheodoiTB.Size = new System.Drawing.Size(170, 20);
            this.txtMatheodoiTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Theo Dõi Thiết Bị:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtTenthietbi);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(5, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 40);
            this.panel3.TabIndex = 33;
            // 
            // txtTenthietbi
            // 
            this.txtTenthietbi.Enabled = false;
            this.txtTenthietbi.Location = new System.Drawing.Point(261, 7);
            this.txtTenthietbi.Name = "txtTenthietbi";
            this.txtTenthietbi.Size = new System.Drawing.Size(170, 20);
            this.txtTenthietbi.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tên Thiết Bị Sử Dụng:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(355, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 61;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "THEO DÕI THIẾT BỊ";
            // 
            // Matheodoithietbi
            // 
            this.Matheodoithietbi.DataPropertyName = "Matheodoithietbi";
            this.Matheodoithietbi.HeaderText = "Mã theo dõi thiết bị";
            this.Matheodoithietbi.Name = "Matheodoithietbi";
            // 
            // Tendonvi
            // 
            this.Tendonvi.DataPropertyName = "Tendonvi";
            this.Tendonvi.HeaderText = "Đơn vị sử dụng";
            this.Tendonvi.Name = "Tendonvi";
            // 
            // Tenthietbisudung
            // 
            this.Tenthietbisudung.DataPropertyName = "Tenthietbisudung";
            this.Tenthietbisudung.HeaderText = "Tên thiết bị sử dụng";
            this.Tenthietbisudung.Name = "Tenthietbisudung";
            // 
            // Ngaybatdausudung
            // 
            this.Ngaybatdausudung.DataPropertyName = "Ngaybatdausudung";
            this.Ngaybatdausudung.HeaderText = "Ngày bắt đầu sử dụng";
            this.Ngaybatdausudung.Name = "Ngaybatdausudung";
            // 
            // Ngaytrathietbi
            // 
            this.Ngaytrathietbi.DataPropertyName = "Ngaytrathietbi";
            this.Ngaytrathietbi.HeaderText = "Ngày trả thiết bị";
            this.Ngaytrathietbi.Name = "Ngaytrathietbi";
            // 
            // Tinhtrangthietbi
            // 
            this.Tinhtrangthietbi.DataPropertyName = "Tinhtrangthietbi";
            this.Tinhtrangthietbi.HeaderText = "Tình trạng thiết bị";
            this.Tinhtrangthietbi.Name = "Tinhtrangthietbi";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // DeviceTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1155, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnCapnhattheodoiTB);
            this.Controls.Add(this.btnXoatheodoiTB);
            this.Controls.Add(this.btnThemtheodoiTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceTrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi thiết bị";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTheodoiTB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgTheodoiTB;
        private System.Windows.Forms.Button btnCapnhattheodoiTB;
        private System.Windows.Forms.Button btnXoatheodoiTB;
        private System.Windows.Forms.Button btnThemtheodoiTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaybatdauSD;
        private System.Windows.Forms.TextBox txtTinhtrangTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDVsudung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatheodoiTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenthietbi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matheodoithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthietbisudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaybatdausudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytrathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinhtrangthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}