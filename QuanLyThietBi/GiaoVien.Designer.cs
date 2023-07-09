namespace QuanLyThietBi
{
    partial class GiaoVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoVien));
			this.txtEmailNV = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtManhanvien = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgNhanVien = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtChucvu = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTennhanvien = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTendonvi = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnXoaTTNV = new System.Windows.Forms.Button();
			this.btnThemNV = new System.Windows.Forms.Button();
			this.btnLuuTTNV = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEmailNV
			// 
			this.txtEmailNV.Location = new System.Drawing.Point(188, 220);
			this.txtEmailNV.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmailNV.Name = "txtEmailNV";
			this.txtEmailNV.Size = new System.Drawing.Size(225, 22);
			this.txtEmailNV.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 218);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 26);
			this.label6.TabIndex = 11;
			this.label6.Text = "Email:";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(188, 171);
			this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(225, 22);
			this.txtSDT.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 169);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 26);
			this.label7.TabIndex = 9;
			this.label7.Text = "SĐT:";
			// 
			// txtManhanvien
			// 
			this.txtManhanvien.Enabled = false;
			this.txtManhanvien.Location = new System.Drawing.Point(188, 22);
			this.txtManhanvien.Margin = new System.Windows.Forms.Padding(4);
			this.txtManhanvien.Name = "txtManhanvien";
			this.txtManhanvien.Size = new System.Drawing.Size(225, 22);
			this.txtManhanvien.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.dgNhanVien);
			this.panel3.Location = new System.Drawing.Point(436, 47);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(928, 484);
			this.panel3.TabIndex = 20;
			// 
			// dgNhanVien
			// 
			this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dgNhanVien.Location = new System.Drawing.Point(4, 0);
			this.dgNhanVien.Margin = new System.Windows.Forms.Padding(4);
			this.dgNhanVien.Name = "dgNhanVien";
			this.dgNhanVien.RowHeadersWidth = 102;
			this.dgNhanVien.Size = new System.Drawing.Size(916, 473);
			this.dgNhanVien.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Manhanvien";
			this.Column1.HeaderText = "Mã Giáo Viên";
			this.Column1.MinimumWidth = 12;
			this.Column1.Name = "Column1";
			this.Column1.Width = 120;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Tennhanvien";
			this.Column2.HeaderText = "Tên Giáo Viên";
			this.Column2.MinimumWidth = 12;
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Chucvu";
			this.Column3.HeaderText = "Chức Vụ";
			this.Column3.MinimumWidth = 12;
			this.Column3.Name = "Column3";
			this.Column3.Width = 120;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Sdtnhanvien";
			this.Column4.HeaderText = "Số Điện Thoại";
			this.Column4.MinimumWidth = 12;
			this.Column4.Name = "Column4";
			this.Column4.Width = 120;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Emailnhanvien";
			this.Column5.HeaderText = "Email";
			this.Column5.MinimumWidth = 12;
			this.Column5.Name = "Column5";
			this.Column5.Width = 120;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.DataPropertyName = "Tendonvi";
			this.Column6.HeaderText = "Tên Bộ Môn";
			this.Column6.MinimumWidth = 12;
			this.Column6.Name = "Column6";
			// 
			// txtChucvu
			// 
			this.txtChucvu.Location = new System.Drawing.Point(188, 121);
			this.txtChucvu.Margin = new System.Windows.Forms.Padding(4);
			this.txtChucvu.Name = "txtChucvu";
			this.txtChucvu.Size = new System.Drawing.Size(225, 22);
			this.txtChucvu.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 118);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Chức vụ:";
			// 
			// txtTennhanvien
			// 
			this.txtTennhanvien.Location = new System.Drawing.Point(188, 71);
			this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(4);
			this.txtTennhanvien.Name = "txtTennhanvien";
			this.txtTennhanvien.Size = new System.Drawing.Size(225, 22);
			this.txtTennhanvien.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txtTendonvi);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Location = new System.Drawing.Point(1, 47);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(425, 47);
			this.panel2.TabIndex = 19;
			// 
			// txtTendonvi
			// 
			this.txtTendonvi.Enabled = false;
			this.txtTendonvi.Location = new System.Drawing.Point(188, 10);
			this.txtTendonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTendonvi.Name = "txtTendonvi";
			this.txtTendonvi.Size = new System.Drawing.Size(225, 22);
			this.txtTendonvi.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(13, 7);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(132, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "Tên bộ môn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 69);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên giáo viên:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 21);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 26);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mã cán bộ:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtEmailNV);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtSDT);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtManhanvien);
			this.panel1.Controls.Add(this.txtChucvu);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtTennhanvien);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(1, 102);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(425, 264);
			this.panel1.TabIndex = 18;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(231, 457);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 36;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 29);
			this.label1.TabIndex = 65;
			this.label1.Text = "Giáo Viên";
			// 
			// btnXoaTTNV
			// 
			this.btnXoaTTNV.BackColor = System.Drawing.Color.White;
			this.btnXoaTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaTTNV.ForeColor = System.Drawing.Color.Red;
			this.btnXoaTTNV.Image = global::QuanLyThietBi.Properties.Resources.trash_can_delete;
			this.btnXoaTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoaTTNV.Location = new System.Drawing.Point(20, 457);
			this.btnXoaTTNV.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoaTTNV.Name = "btnXoaTTNV";
			this.btnXoaTTNV.Size = new System.Drawing.Size(132, 63);
			this.btnXoaTTNV.TabIndex = 23;
			this.btnXoaTTNV.Text = "Xóa\r\n giáo viên";
			this.btnXoaTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaTTNV.UseVisualStyleBackColor = false;
			this.btnXoaTTNV.Click += new System.EventHandler(this.btnXoaTTNV_Click);
			// 
			// btnThemNV
			// 
			this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemNV.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemNV.Location = new System.Drawing.Point(20, 374);
			this.btnThemNV.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemNV.Name = "btnThemNV";
			this.btnThemNV.Size = new System.Drawing.Size(132, 63);
			this.btnThemNV.TabIndex = 21;
			this.btnThemNV.Text = "Thêm giáo viên";
			this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemNV.UseVisualStyleBackColor = true;
			this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
			// 
			// btnLuuTTNV
			// 
			this.btnLuuTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuuTTNV.Image = global::QuanLyThietBi.Properties.Resources.edit_2add;
			this.btnLuuTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLuuTTNV.Location = new System.Drawing.Point(231, 374);
			this.btnLuuTTNV.Margin = new System.Windows.Forms.Padding(4);
			this.btnLuuTTNV.Name = "btnLuuTTNV";
			this.btnLuuTTNV.Size = new System.Drawing.Size(132, 63);
			this.btnLuuTTNV.TabIndex = 22;
			this.btnLuuTTNV.Text = "Sửa tin giáo viên";
			this.btnLuuTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLuuTTNV.UseVisualStyleBackColor = true;
			this.btnLuuTTNV.Click += new System.EventHandler(this.btnLuuTTNV_Click);
			// 
			// GiaoVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1369, 533);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btnXoaTTNV);
			this.Controls.Add(this.btnThemNV);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnLuuTTNV);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "GiaoVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giáo viên";
			this.Load += new System.EventHandler(this.StaffForm_Load);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.Button btnXoaTTNV;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuuTTNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTendonvi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}