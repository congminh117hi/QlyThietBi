namespace QuanLyThietBi
{
    partial class BoMon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoMon));
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtMadonvi = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtEmaildonvi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnCapnhatDV = new System.Windows.Forms.Button();
			this.btnXoaDV = new System.Windows.Forms.Button();
			this.txtSDTdonvi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnThemDV = new System.Windows.Forms.Button();
			this.txtTendonvi = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgDonvi = new System.Windows.Forms.DataGridView();
			this.Madonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sdtdonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Emaildonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgDonvi)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.txtMadonvi);
			this.panel3.Controls.Add(this.btnClose);
			this.panel3.Controls.Add(this.txtEmaildonvi);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.btnCapnhatDV);
			this.panel3.Controls.Add(this.btnXoaDV);
			this.panel3.Controls.Add(this.txtSDTdonvi);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.btnThemDV);
			this.panel3.Controls.Add(this.txtTendonvi);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(5, 48);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(404, 473);
			this.panel3.TabIndex = 16;
			// 
			// txtMadonvi
			// 
			this.txtMadonvi.Enabled = false;
			this.txtMadonvi.Location = new System.Drawing.Point(171, 27);
			this.txtMadonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtMadonvi.Name = "txtMadonvi";
			this.txtMadonvi.Size = new System.Drawing.Size(215, 22);
			this.txtMadonvi.TabIndex = 8;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(225, 394);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 24;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtEmaildonvi
			// 
			this.txtEmaildonvi.Location = new System.Drawing.Point(171, 194);
			this.txtEmaildonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmaildonvi.Name = "txtEmaildonvi";
			this.txtEmaildonvi.Size = new System.Drawing.Size(215, 22);
			this.txtEmaildonvi.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(-1, 191);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(154, 26);
			this.label9.TabIndex = 6;
			this.label9.Text = "Email Bộ Môn: ";
			// 
			// btnCapnhatDV
			// 
			this.btnCapnhatDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapnhatDV.Image = global::QuanLyThietBi.Properties.Resources.edit_2add;
			this.btnCapnhatDV.Location = new System.Drawing.Point(14, 394);
			this.btnCapnhatDV.Margin = new System.Windows.Forms.Padding(4);
			this.btnCapnhatDV.Name = "btnCapnhatDV";
			this.btnCapnhatDV.Size = new System.Drawing.Size(132, 63);
			this.btnCapnhatDV.TabIndex = 21;
			this.btnCapnhatDV.Text = "Sửa thông tin bộ môn";
			this.btnCapnhatDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapnhatDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapnhatDV.UseVisualStyleBackColor = true;
			this.btnCapnhatDV.Click += new System.EventHandler(this.btnCapnhatDV_Click);
			// 
			// btnXoaDV
			// 
			this.btnXoaDV.BackColor = System.Drawing.Color.White;
			this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaDV.ForeColor = System.Drawing.Color.Red;
			this.btnXoaDV.Image = global::QuanLyThietBi.Properties.Resources.trash_can_delete;
			this.btnXoaDV.Location = new System.Drawing.Point(225, 259);
			this.btnXoaDV.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoaDV.Name = "btnXoaDV";
			this.btnXoaDV.Size = new System.Drawing.Size(132, 63);
			this.btnXoaDV.TabIndex = 22;
			this.btnXoaDV.Text = "Xóa \r\nbộ môn";
			this.btnXoaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnXoaDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaDV.UseVisualStyleBackColor = false;
			this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
			// 
			// txtSDTdonvi
			// 
			this.txtSDTdonvi.Location = new System.Drawing.Point(181, 141);
			this.txtSDTdonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtSDTdonvi.Name = "txtSDTdonvi";
			this.txtSDTdonvi.Size = new System.Drawing.Size(205, 22);
			this.txtSDTdonvi.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(-1, 141);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(171, 26);
			this.label10.TabIndex = 4;
			this.label10.Text = "SDT GV Bộ Môn:";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// btnThemDV
			// 
			this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemDV.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemDV.Location = new System.Drawing.Point(14, 259);
			this.btnThemDV.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemDV.Name = "btnThemDV";
			this.btnThemDV.Size = new System.Drawing.Size(132, 63);
			this.btnThemDV.TabIndex = 20;
			this.btnThemDV.Text = "Thêm\r\n bộ môn";
			this.btnThemDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemDV.UseVisualStyleBackColor = true;
			this.btnThemDV.Click += new System.EventHandler(this.btnThemTK_Click);
			// 
			// txtTendonvi
			// 
			this.txtTendonvi.Location = new System.Drawing.Point(171, 80);
			this.txtTendonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTendonvi.Name = "txtTendonvi";
			this.txtTendonvi.Size = new System.Drawing.Size(215, 22);
			this.txtTendonvi.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(-1, 77);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(132, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "Tên bộ môn:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(4, 24);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(124, 26);
			this.label12.TabIndex = 0;
			this.label12.Text = "Mã Bộ Môn:";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgDonvi);
			this.panel1.Location = new System.Drawing.Point(417, 44);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(714, 499);
			this.panel1.TabIndex = 23;
			// 
			// dgDonvi
			// 
			this.dgDonvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDonvi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Madonvi,
            this.Tendonvi,
            this.Sdtdonvi,
            this.Emaildonvi});
			this.dgDonvi.Location = new System.Drawing.Point(4, 4);
			this.dgDonvi.Margin = new System.Windows.Forms.Padding(4);
			this.dgDonvi.Name = "dgDonvi";
			this.dgDonvi.RowHeadersWidth = 51;
			this.dgDonvi.Size = new System.Drawing.Size(706, 495);
			this.dgDonvi.TabIndex = 0;
			this.dgDonvi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDonvi_CellContentClick);
			// 
			// Madonvi
			// 
			this.Madonvi.DataPropertyName = "Madonvi";
			this.Madonvi.HeaderText = "Mã Bộ Môn";
			this.Madonvi.MinimumWidth = 6;
			this.Madonvi.Name = "Madonvi";
			this.Madonvi.Width = 125;
			// 
			// Tendonvi
			// 
			this.Tendonvi.DataPropertyName = "Tendonvi";
			this.Tendonvi.HeaderText = "Tên Bộ Môn";
			this.Tendonvi.MinimumWidth = 6;
			this.Tendonvi.Name = "Tendonvi";
			this.Tendonvi.Width = 125;
			// 
			// Sdtdonvi
			// 
			this.Sdtdonvi.DataPropertyName = "Sdtdonvi";
			this.Sdtdonvi.HeaderText = "SDT GV bộ môn";
			this.Sdtdonvi.MinimumWidth = 6;
			this.Sdtdonvi.Name = "Sdtdonvi";
			this.Sdtdonvi.Width = 125;
			// 
			// Emaildonvi
			// 
			this.Emaildonvi.DataPropertyName = "Emaildonvi";
			this.Emaildonvi.HeaderText = "Email GV Bộ môn";
			this.Emaildonvi.MinimumWidth = 6;
			this.Emaildonvi.Name = "Emaildonvi";
			this.Emaildonvi.Width = 125;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label3.Location = new System.Drawing.Point(5, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 29);
			this.label3.TabIndex = 62;
			this.label3.Text = "Bộ Môn";
			// 
			// BoMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1156, 557);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BoMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bộ Môn";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgDonvi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadonvi;
        private System.Windows.Forms.TextBox txtEmaildonvi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDTdonvi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTendonvi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnCapnhatDV;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgDonvi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Madonvi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tendonvi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sdtdonvi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Emaildonvi;
	}
}