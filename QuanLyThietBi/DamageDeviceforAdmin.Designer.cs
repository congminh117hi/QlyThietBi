namespace QuanLyThietBi
{
    partial class DamageDeviceforAdmin
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
            this.btnThemTK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Maphieusuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluongsuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHuHong)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgHuHong);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(914, 335);
            this.flowLayoutPanel1.TabIndex = 49;
            // 
            // dgHuHong
            // 
            this.dgHuHong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHuHong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieusuachua,
            this.Manhanvien,
            this.Tennhanvien,
            this.Madonvi,
            this.Tendonvi,
            this.Ngaysuachua,
            this.Soluongsuachua,
            this.Ghichu});
            this.dgHuHong.Location = new System.Drawing.Point(3, 3);
            this.dgHuHong.Name = "dgHuHong";
            this.dgHuHong.RowHeadersWidth = 102;
            this.dgHuHong.Size = new System.Drawing.Size(908, 334);
            this.dgHuHong.TabIndex = 0;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.Location = new System.Drawing.Point(412, 386);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(99, 51);
            this.btnThemTK.TabIndex = 50;
            this.btnThemTK.Text = "Đóng";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "TỔNG HỢP THIẾT BỊ HƯ HỎNG";
            // 
            // Maphieusuachua
            // 
            this.Maphieusuachua.DataPropertyName = "Maphieusuachua";
            this.Maphieusuachua.HeaderText = "Mã phiếu sữa chữa";
            this.Maphieusuachua.Name = "Maphieusuachua";
            // 
            // Manhanvien
            // 
            this.Manhanvien.DataPropertyName = "Manhanvien";
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.Name = "Manhanvien";
            // 
            // Tennhanvien
            // 
            this.Tennhanvien.DataPropertyName = "Tennhanvien";
            this.Tennhanvien.HeaderText = "Tên nhân viên";
            this.Tennhanvien.Name = "Tennhanvien";
            // 
            // Madonvi
            // 
            this.Madonvi.DataPropertyName = "Madonvi";
            this.Madonvi.HeaderText = "Mã đơn vị";
            this.Madonvi.Name = "Madonvi";
            // 
            // Tendonvi
            // 
            this.Tendonvi.DataPropertyName = "Tendonvi";
            this.Tendonvi.HeaderText = "Tên đơn vị";
            this.Tendonvi.Name = "Tendonvi";
            // 
            // Ngaysuachua
            // 
            this.Ngaysuachua.DataPropertyName = "Ngaysuachua";
            this.Ngaysuachua.HeaderText = "Ngày báo cáo";
            this.Ngaysuachua.Name = "Ngaysuachua";
            // 
            // Soluongsuachua
            // 
            this.Soluongsuachua.DataPropertyName = "Soluongsuachua";
            this.Soluongsuachua.HeaderText = "Số lượng";
            this.Soluongsuachua.Name = "Soluongsuachua";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // DamageDeviceforAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(919, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DamageDeviceforAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thiết bị cần sửa chữa";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHuHong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgHuHong;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieusuachua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysuachua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluongsuachua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
    }
}