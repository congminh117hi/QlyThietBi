﻿namespace QuanLyThietBi
{
    partial class ThemTaiKhoan
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
			this.btnTaoTK = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
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
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTaoTK
			// 
			this.btnTaoTK.BackColor = System.Drawing.Color.White;
			this.btnTaoTK.FlatAppearance.BorderSize = 0;
			this.btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaoTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnTaoTK.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnTaoTK.Location = new System.Drawing.Point(289, 346);
			this.btnTaoTK.Margin = new System.Windows.Forms.Padding(4);
			this.btnTaoTK.Name = "btnTaoTK";
			this.btnTaoTK.Size = new System.Drawing.Size(132, 63);
			this.btnTaoTK.TabIndex = 6;
			this.btnTaoTK.Text = "Tạo Tài Khoản";
			this.btnTaoTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTaoTK.UseVisualStyleBackColor = false;
			this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.cboTenNhanVien);
			this.panel3.Controls.Add(this.txtMatkhau);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.txtMataikhoan);
			this.panel3.Controls.Add(this.txtTendangnhap);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.txtLoaitaikhoan);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Location = new System.Drawing.Point(5, 64);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(425, 274);
			this.panel3.TabIndex = 16;
			// 
			// cboTenNhanVien
			// 
			this.cboTenNhanVien.FormattingEnabled = true;
			this.cboTenNhanVien.Location = new System.Drawing.Point(188, 71);
			this.cboTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
			this.cboTenNhanVien.Name = "cboTenNhanVien";
			this.cboTenNhanVien.Size = new System.Drawing.Size(224, 24);
			this.cboTenNhanVien.TabIndex = 2;
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Location = new System.Drawing.Point(188, 215);
			this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.Size = new System.Drawing.Size(225, 22);
			this.txtMatkhau.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 214);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 26);
			this.label1.TabIndex = 9;
			this.label1.Text = "Mật Khẩu:";
			// 
			// txtMataikhoan
			// 
			this.txtMataikhoan.Enabled = false;
			this.txtMataikhoan.Location = new System.Drawing.Point(188, 22);
			this.txtMataikhoan.Margin = new System.Windows.Forms.Padding(4);
			this.txtMataikhoan.Name = "txtMataikhoan";
			this.txtMataikhoan.Size = new System.Drawing.Size(225, 22);
			this.txtMataikhoan.TabIndex = 1;
			// 
			// txtTendangnhap
			// 
			this.txtTendangnhap.Location = new System.Drawing.Point(188, 167);
			this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(4);
			this.txtTendangnhap.Name = "txtTendangnhap";
			this.txtTendangnhap.Size = new System.Drawing.Size(225, 22);
			this.txtTendangnhap.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 70);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(153, 26);
			this.label9.TabIndex = 6;
			this.label9.Text = "Tên Giáo Viên:";
			// 
			// txtLoaitaikhoan
			// 
			this.txtLoaitaikhoan.Location = new System.Drawing.Point(188, 121);
			this.txtLoaitaikhoan.Margin = new System.Windows.Forms.Padding(4);
			this.txtLoaitaikhoan.Name = "txtLoaitaikhoan";
			this.txtLoaitaikhoan.Size = new System.Drawing.Size(225, 22);
			this.txtLoaitaikhoan.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 118);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(158, 26);
			this.label10.TabIndex = 3;
			this.label10.Text = "Loại Tài Khoản:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(13, 166);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(166, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "Tên Đăng Nhập:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 21);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(147, 26);
			this.label12.TabIndex = 0;
			this.label12.Text = "Mã Tài Khoản:";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(17, 346);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 59;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 29);
			this.label3.TabIndex = 60;
			this.label3.Text = "THÊM TÀI KHOẢN";
			// 
			// ThemTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(436, 425);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btnTaoTK);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ThemTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm tài khoản đăng nhập";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaoTK;
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
        private System.Windows.Forms.ComboBox cboTenNhanVien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
    }
}