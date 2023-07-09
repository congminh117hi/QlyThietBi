namespace QuanLyThietBi
{
    partial class AddDeviceForm
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
            this.btnThemthietbi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboTenLoaiTB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDonvitinh = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenthietbi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMathietbi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemthietbi
            // 
            this.btnThemthietbi.FlatAppearance.BorderSize = 0;
            this.btnThemthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemthietbi.Location = new System.Drawing.Point(162, 269);
            this.btnThemthietbi.Name = "btnThemthietbi";
            this.btnThemthietbi.Size = new System.Drawing.Size(99, 51);
            this.btnThemthietbi.TabIndex = 24;
            this.btnThemthietbi.Text = "Thêm\r\nThiết Bị";
            this.btnThemthietbi.UseVisualStyleBackColor = true;
            this.btnThemthietbi.Click += new System.EventHandler(this.btnThemthietbi_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cboTenLoaiTB);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(5, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 43);
            this.panel4.TabIndex = 32;
            // 
            // cboTenLoaiTB
            // 
            this.cboTenLoaiTB.FormattingEnabled = true;
            this.cboTenLoaiTB.Location = new System.Drawing.Point(181, 8);
            this.cboTenLoaiTB.Name = "cboTenLoaiTB";
            this.cboTenLoaiTB.Size = new System.Drawing.Size(170, 21);
            this.cboTenLoaiTB.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên Loại Thiết Bị:";
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
            this.panel3.Location = new System.Drawing.Point(5, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 174);
            this.panel3.TabIndex = 31;
            // 
            // txtDonvitinh
            // 
            this.txtDonvitinh.Location = new System.Drawing.Point(181, 98);
            this.txtDonvitinh.Name = "txtDonvitinh";
            this.txtDonvitinh.Size = new System.Drawing.Size(170, 20);
            this.txtDonvitinh.TabIndex = 12;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(181, 137);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(170, 20);
            this.txtGhichu.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ghi Chú:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Đơn vị tính:";
            // 
            // txtTenthietbi
            // 
            this.txtTenthietbi.Location = new System.Drawing.Point(181, 59);
            this.txtTenthietbi.Name = "txtTenthietbi";
            this.txtTenthietbi.Size = new System.Drawing.Size(170, 20);
            this.txtTenthietbi.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tên Thiết Bị:";
            // 
            // txtMathietbi
            // 
            this.txtMathietbi.Enabled = false;
            this.txtMathietbi.Location = new System.Drawing.Point(181, 20);
            this.txtMathietbi.Name = "txtMathietbi";
            this.txtMathietbi.Size = new System.Drawing.Size(170, 20);
            this.txtMathietbi.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Mã Thiết Bị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "THÊM THIẾT BỊ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(267, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(378, 325);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnThemthietbi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thiết bị";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemthietbi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDonvitinh;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenthietbi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMathietbi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTenLoaiTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}