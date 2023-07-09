namespace QuanLyThietBi
{
    partial class TypeOfDForm
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
            this.btnCapnhatLTB = new System.Windows.Forms.Button();
            this.btnXoaLTB = new System.Windows.Forms.Button();
            this.btnThemLTB = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtMaloaithietbi);
            this.panel2.Controls.Add(this.txtTenloaithietbi);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 93);
            this.panel2.TabIndex = 21;
            // 
            // txtMaloaithietbi
            // 
            this.txtMaloaithietbi.Enabled = false;
            this.txtMaloaithietbi.Location = new System.Drawing.Point(147, 17);
            this.txtMaloaithietbi.Name = "txtMaloaithietbi";
            this.txtMaloaithietbi.Size = new System.Drawing.Size(170, 20);
            this.txtMaloaithietbi.TabIndex = 5;
            // 
            // txtTenloaithietbi
            // 
            this.txtTenloaithietbi.Location = new System.Drawing.Point(147, 58);
            this.txtTenloaithietbi.Name = "txtTenloaithietbi";
            this.txtTenloaithietbi.Size = new System.Drawing.Size(170, 20);
            this.txtTenloaithietbi.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Loại Thiết Bị:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Loại Thiết Bị:";
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloaithietbi,
            this.Tenloaithietbi});
            this.dgNhanVien.Location = new System.Drawing.Point(329, 31);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.RowHeadersWidth = 102;
            this.dgNhanVien.Size = new System.Drawing.Size(306, 249);
            this.dgNhanVien.TabIndex = 22;
            this.dgNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellContentClick);
            // 
            // Maloaithietbi
            // 
            this.Maloaithietbi.DataPropertyName = "Maloaithietbi";
            this.Maloaithietbi.HeaderText = "Mã loại thiết bị";
            this.Maloaithietbi.Name = "Maloaithietbi";
            // 
            // Tenloaithietbi
            // 
            this.Tenloaithietbi.DataPropertyName = "Tenloaithietbi";
            this.Tenloaithietbi.HeaderText = "Tên loại thiết bị";
            this.Tenloaithietbi.Name = "Tenloaithietbi";
            // 
            // btnCapnhatLTB
            // 
            this.btnCapnhatLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatLTB.Location = new System.Drawing.Point(117, 130);
            this.btnCapnhatLTB.Name = "btnCapnhatLTB";
            this.btnCapnhatLTB.Size = new System.Drawing.Size(99, 51);
            this.btnCapnhatLTB.TabIndex = 34;
            this.btnCapnhatLTB.Text = "Sửa Thông Tin\r\nLoại Thiết Bị";
            this.btnCapnhatLTB.UseVisualStyleBackColor = true;
            this.btnCapnhatLTB.Click += new System.EventHandler(this.btnCapnhatLTB_Click);
            // 
            // btnXoaLTB
            // 
            this.btnXoaLTB.BackColor = System.Drawing.Color.White;
            this.btnXoaLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLTB.ForeColor = System.Drawing.Color.Orange;
            this.btnXoaLTB.Location = new System.Drawing.Point(222, 130);
            this.btnXoaLTB.Name = "btnXoaLTB";
            this.btnXoaLTB.Size = new System.Drawing.Size(99, 51);
            this.btnXoaLTB.TabIndex = 33;
            this.btnXoaLTB.Text = "Xóa\r\nLoại Thiết Bị";
            this.btnXoaLTB.UseVisualStyleBackColor = false;
            this.btnXoaLTB.Click += new System.EventHandler(this.btnXoaLTB_Click);
            // 
            // btnThemLTB
            // 
            this.btnThemLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLTB.Location = new System.Drawing.Point(12, 130);
            this.btnThemLTB.Name = "btnThemLTB";
            this.btnThemLTB.Size = new System.Drawing.Size(99, 51);
            this.btnThemLTB.TabIndex = 32;
            this.btnThemLTB.Text = "Thêm\r\nLoại Thiết Bị";
            this.btnThemLTB.UseVisualStyleBackColor = true;
            this.btnThemLTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(117, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "LOẠI THIẾT BỊ";
            // 
            // TypeOfDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(639, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCapnhatLTB);
            this.Controls.Add(this.btnXoaLTB);
            this.Controls.Add(this.btnThemLTB);
            this.Controls.Add(this.dgNhanVien);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOfDForm";
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