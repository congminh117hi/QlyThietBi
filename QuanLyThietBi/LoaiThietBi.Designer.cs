namespace QuanLyThietBi
{
    partial class LoaiThietBi
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtMaloaithietbi = new System.Windows.Forms.TextBox();
			this.txtTenloaithietbi = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dgNhanVien = new System.Windows.Forms.DataGridView();
			this.Maloaithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenloaithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCapnhatLTB = new System.Windows.Forms.Button();
			this.btnXoaLTB = new System.Windows.Forms.Button();
			this.btnThemLTB = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txtMaloaithietbi);
			this.panel2.Controls.Add(this.txtTenloaithietbi);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Location = new System.Drawing.Point(1, 38);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(459, 138);
			this.panel2.TabIndex = 21;
			// 
			// txtMaloaithietbi
			// 
			this.txtMaloaithietbi.Enabled = false;
			this.txtMaloaithietbi.Location = new System.Drawing.Point(207, 21);
			this.txtMaloaithietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaloaithietbi.Name = "txtMaloaithietbi";
			this.txtMaloaithietbi.Size = new System.Drawing.Size(225, 22);
			this.txtMaloaithietbi.TabIndex = 5;
			// 
			// txtTenloaithietbi
			// 
			this.txtTenloaithietbi.Location = new System.Drawing.Point(207, 87);
			this.txtTenloaithietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenloaithietbi.Name = "txtTenloaithietbi";
			this.txtTenloaithietbi.Size = new System.Drawing.Size(225, 22);
			this.txtTenloaithietbi.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(13, 87);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(177, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "Tên Loại Thiết Bị:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 21);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(168, 26);
			this.label12.TabIndex = 0;
			this.label12.Text = "Mã Loại Thiết Bị:";
			// 
			// dgNhanVien
			// 
			this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaithietbi,
            this.Tenloaithietbi});
			this.dgNhanVien.Location = new System.Drawing.Point(468, 13);
			this.dgNhanVien.Margin = new System.Windows.Forms.Padding(4);
			this.dgNhanVien.Name = "dgNhanVien";
			this.dgNhanVien.RowHeadersWidth = 102;
			this.dgNhanVien.Size = new System.Drawing.Size(470, 375);
			this.dgNhanVien.TabIndex = 22;
			this.dgNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellContentClick);
			// 
			// Maloaithietbi
			// 
			this.Maloaithietbi.DataPropertyName = "Maloaithietbi";
			this.Maloaithietbi.HeaderText = "Mã loại thiết bị";
			this.Maloaithietbi.MinimumWidth = 6;
			this.Maloaithietbi.Name = "Maloaithietbi";
			this.Maloaithietbi.Width = 125;
			// 
			// Tenloaithietbi
			// 
			this.Tenloaithietbi.DataPropertyName = "Tenloaithietbi";
			this.Tenloaithietbi.HeaderText = "Tên loại thiết bị";
			this.Tenloaithietbi.MinimumWidth = 6;
			this.Tenloaithietbi.Name = "Tenloaithietbi";
			this.Tenloaithietbi.Width = 125;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(35, 304);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 35;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(11, 5);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(184, 29);
			this.label3.TabIndex = 64;
			this.label3.Text = "LOẠI THIẾT BỊ";
			// 
			// btnCapnhatLTB
			// 
			this.btnCapnhatLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapnhatLTB.Image = global::QuanLyThietBi.Properties.Resources.edit_2add;
			this.btnCapnhatLTB.Location = new System.Drawing.Point(257, 196);
			this.btnCapnhatLTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnCapnhatLTB.Name = "btnCapnhatLTB";
			this.btnCapnhatLTB.Size = new System.Drawing.Size(132, 68);
			this.btnCapnhatLTB.TabIndex = 34;
			this.btnCapnhatLTB.Text = "Sửa Thông Tin\r\n Loại Thiết Bị";
			this.btnCapnhatLTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCapnhatLTB.UseVisualStyleBackColor = true;
			this.btnCapnhatLTB.Click += new System.EventHandler(this.btnCapnhatLTB_Click);
			// 
			// btnXoaLTB
			// 
			this.btnXoaLTB.BackColor = System.Drawing.Color.White;
			this.btnXoaLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaLTB.ForeColor = System.Drawing.Color.Red;
			this.btnXoaLTB.Image = global::QuanLyThietBi.Properties.Resources.trash_can_delete;
			this.btnXoaLTB.Location = new System.Drawing.Point(257, 304);
			this.btnXoaLTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnXoaLTB.Name = "btnXoaLTB";
			this.btnXoaLTB.Size = new System.Drawing.Size(132, 68);
			this.btnXoaLTB.TabIndex = 33;
			this.btnXoaLTB.Text = "Xóa\r\nLoại Thiết Bị";
			this.btnXoaLTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnXoaLTB.UseVisualStyleBackColor = false;
			this.btnXoaLTB.Click += new System.EventHandler(this.btnXoaLTB_Click);
			// 
			// btnThemLTB
			// 
			this.btnThemLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemLTB.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemLTB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemLTB.Location = new System.Drawing.Point(35, 196);
			this.btnThemLTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemLTB.Name = "btnThemLTB";
			this.btnThemLTB.Size = new System.Drawing.Size(132, 68);
			this.btnThemLTB.TabIndex = 32;
			this.btnThemLTB.Text = "Thêm\r\nLoại Thiết Bị";
			this.btnThemLTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemLTB.UseVisualStyleBackColor = true;
			this.btnThemLTB.Click += new System.EventHandler(this.btnThemTB_Click);
			// 
			// LoaiThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(963, 401);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCapnhatLTB);
			this.Controls.Add(this.btnXoaLTB);
			this.Controls.Add(this.btnThemLTB);
			this.Controls.Add(this.dgNhanVien);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoaiThietBi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loại thiết bị";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenloaithietbi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.Button btnCapnhatLTB;
        private System.Windows.Forms.Button btnXoaLTB;
        private System.Windows.Forms.Button btnThemLTB;
        private System.Windows.Forms.TextBox txtMaloaithietbi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloaithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloaithietbi;
    }
}