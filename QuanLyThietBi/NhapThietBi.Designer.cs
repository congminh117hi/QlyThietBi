namespace QuanLyThietBi
{
    partial class NhapThietBi
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
			this.txtTenloaithietbi = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.dgThietbi = new System.Windows.Forms.DataGridView();
			this.Mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenloaithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMathietbi = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtDonvitinh = new System.Windows.Forms.TextBox();
			this.txtGhichu = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTenthietbi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCapnhatTB = new System.Windows.Forms.Button();
			this.btnXoathietbi = new System.Windows.Forms.Button();
			this.btnThemTB = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgThietbi)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTenloaithietbi
			// 
			this.txtTenloaithietbi.Enabled = false;
			this.txtTenloaithietbi.Location = new System.Drawing.Point(218, 9);
			this.txtTenloaithietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenloaithietbi.Name = "txtTenloaithietbi";
			this.txtTenloaithietbi.Size = new System.Drawing.Size(197, 22);
			this.txtTenloaithietbi.TabIndex = 7;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(13, 6);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(177, 26);
			this.label15.TabIndex = 6;
			this.label15.Text = "Tên Loại Thiết Bị:";
			// 
			// dgThietbi
			// 
			this.dgThietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgThietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathietbi,
            this.Tenloaithietbi,
            this.Tenthietbi,
            this.Donvitinh,
            this.Ghichu});
			this.dgThietbi.Location = new System.Drawing.Point(4, 0);
			this.dgThietbi.Margin = new System.Windows.Forms.Padding(4);
			this.dgThietbi.Name = "dgThietbi";
			this.dgThietbi.RowHeadersWidth = 102;
			this.dgThietbi.Size = new System.Drawing.Size(757, 489);
			this.dgThietbi.TabIndex = 0;
			// 
			// Mathietbi
			// 
			this.Mathietbi.DataPropertyName = "Mathietbi";
			this.Mathietbi.HeaderText = "Mã thiết bị";
			this.Mathietbi.MinimumWidth = 6;
			this.Mathietbi.Name = "Mathietbi";
			this.Mathietbi.Width = 125;
			// 
			// Tenloaithietbi
			// 
			this.Tenloaithietbi.DataPropertyName = "Tenloaithietbi";
			this.Tenloaithietbi.HeaderText = "Tên loại thiết bị";
			this.Tenloaithietbi.MinimumWidth = 6;
			this.Tenloaithietbi.Name = "Tenloaithietbi";
			this.Tenloaithietbi.Width = 125;
			// 
			// Tenthietbi
			// 
			this.Tenthietbi.DataPropertyName = "Tenthietbi";
			this.Tenthietbi.HeaderText = "Tên thiết bị";
			this.Tenthietbi.MinimumWidth = 6;
			this.Tenthietbi.Name = "Tenthietbi";
			this.Tenthietbi.Width = 125;
			// 
			// Donvitinh
			// 
			this.Donvitinh.DataPropertyName = "Donvitinh";
			this.Donvitinh.HeaderText = "Đơn vị tính";
			this.Donvitinh.MinimumWidth = 6;
			this.Donvitinh.Name = "Donvitinh";
			this.Donvitinh.Width = 125;
			// 
			// Ghichu
			// 
			this.Ghichu.DataPropertyName = "Ghichu";
			this.Ghichu.HeaderText = "Ghi chú";
			this.Ghichu.MinimumWidth = 6;
			this.Ghichu.Name = "Ghichu";
			this.Ghichu.Width = 125;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(13, 69);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(132, 26);
			this.label13.TabIndex = 2;
			this.label13.Text = "Tên Thiết Bị:";
			// 
			// txtMathietbi
			// 
			this.txtMathietbi.Enabled = false;
			this.txtMathietbi.Location = new System.Drawing.Point(156, 24);
			this.txtMathietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtMathietbi.Name = "txtMathietbi";
			this.txtMathietbi.Size = new System.Drawing.Size(225, 22);
			this.txtMathietbi.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(13, 21);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(123, 26);
			this.label14.TabIndex = 0;
			this.label14.Text = "Mã Thiết Bị:";
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.txtTenloaithietbi);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Location = new System.Drawing.Point(4, 47);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(423, 53);
			this.panel4.TabIndex = 30;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dgThietbi);
			this.panel5.Location = new System.Drawing.Point(442, 47);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(766, 489);
			this.panel5.TabIndex = 29;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.txtDonvitinh);
			this.panel3.Controls.Add(this.txtGhichu);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.txtTenthietbi);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.txtMathietbi);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Location = new System.Drawing.Point(4, 108);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(423, 213);
			this.panel3.TabIndex = 23;
			// 
			// txtDonvitinh
			// 
			this.txtDonvitinh.Location = new System.Drawing.Point(156, 118);
			this.txtDonvitinh.Margin = new System.Windows.Forms.Padding(4);
			this.txtDonvitinh.Name = "txtDonvitinh";
			this.txtDonvitinh.Size = new System.Drawing.Size(225, 22);
			this.txtDonvitinh.TabIndex = 12;
			// 
			// txtGhichu
			// 
			this.txtGhichu.Location = new System.Drawing.Point(156, 168);
			this.txtGhichu.Margin = new System.Windows.Forms.Padding(4);
			this.txtGhichu.Name = "txtGhichu";
			this.txtGhichu.Size = new System.Drawing.Size(225, 22);
			this.txtGhichu.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(13, 165);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(94, 26);
			this.label11.TabIndex = 6;
			this.label11.Text = "Ghi Chú:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 118);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(117, 26);
			this.label12.TabIndex = 4;
			this.label12.Text = "Đơn vị tính:";
			// 
			// txtTenthietbi
			// 
			this.txtTenthietbi.Location = new System.Drawing.Point(156, 71);
			this.txtTenthietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenthietbi.Name = "txtTenthietbi";
			this.txtTenthietbi.Size = new System.Drawing.Size(225, 22);
			this.txtTenthietbi.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(204, 29);
			this.label3.TabIndex = 61;
			this.label3.Text = " NHẬP THIẾT BỊ";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(162, 431);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 60;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnCapnhatTB
			// 
			this.btnCapnhatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapnhatTB.Image = global::QuanLyThietBi.Properties.Resources.edit_2add;
			this.btnCapnhatTB.Location = new System.Drawing.Point(162, 352);
			this.btnCapnhatTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnCapnhatTB.Name = "btnCapnhatTB";
			this.btnCapnhatTB.Size = new System.Drawing.Size(132, 60);
			this.btnCapnhatTB.TabIndex = 28;
			this.btnCapnhatTB.Text = "Sửa Thông Tin\r\nThiết Bị\r\n";
			this.btnCapnhatTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapnhatTB.UseVisualStyleBackColor = true;
			this.btnCapnhatTB.Click += new System.EventHandler(this.btnCapnhatTB_Click);
			// 
			// btnXoathietbi
			// 
			this.btnXoathietbi.BackColor = System.Drawing.Color.White;
			this.btnXoathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoathietbi.ForeColor = System.Drawing.Color.Red;
			this.btnXoathietbi.Image = global::QuanLyThietBi.Properties.Resources.trash_can_delete;
			this.btnXoathietbi.Location = new System.Drawing.Point(306, 352);
			this.btnXoathietbi.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoathietbi.Name = "btnXoathietbi";
			this.btnXoathietbi.Size = new System.Drawing.Size(132, 63);
			this.btnXoathietbi.TabIndex = 27;
			this.btnXoathietbi.Text = "Xóa Thiết Bị";
			this.btnXoathietbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoathietbi.UseVisualStyleBackColor = false;
			this.btnXoathietbi.Click += new System.EventHandler(this.btnXoathietbi_Click);
			// 
			// btnThemTB
			// 
			this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemTB.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemTB.Location = new System.Drawing.Point(13, 352);
			this.btnThemTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemTB.Name = "btnThemTB";
			this.btnThemTB.Size = new System.Drawing.Size(132, 60);
			this.btnThemTB.TabIndex = 26;
			this.btnThemTB.Text = "Thêm\r\nThiết Bị";
			this.btnThemTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemTB.UseVisualStyleBackColor = true;
			this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
			// 
			// NhapThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1220, 552);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.btnCapnhatTB);
			this.Controls.Add(this.btnXoathietbi);
			this.Controls.Add(this.btnThemTB);
			this.Controls.Add(this.panel3);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "NhapThietBi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thiết bị";
			((System.ComponentModel.ISupportInitialize)(this.dgThietbi)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenloaithietbi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgThietbi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMathietbi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCapnhatTB;
        private System.Windows.Forms.Button btnXoathietbi;
        private System.Windows.Forms.Button btnThemTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenthietbi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}