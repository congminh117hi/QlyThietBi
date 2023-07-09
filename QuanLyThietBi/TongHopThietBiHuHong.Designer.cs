namespace QuanLyThietBi
{
    partial class TongHopThietBiHuHong
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TongHopThietBiHuHong));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dgHuHong = new System.Windows.Forms.DataGridView();
			this.Maphieusuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Madonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaysuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Soluongsuachua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.btnThemTK = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgHuHong)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.dgHuHong);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 53);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1159, 434);
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
			this.dgHuHong.Location = new System.Drawing.Point(4, 4);
			this.dgHuHong.Margin = new System.Windows.Forms.Padding(4);
			this.dgHuHong.Name = "dgHuHong";
			this.dgHuHong.RowHeadersWidth = 102;
			this.dgHuHong.Size = new System.Drawing.Size(1148, 430);
			this.dgHuHong.TabIndex = 0;
			// 
			// Maphieusuachua
			// 
			this.Maphieusuachua.DataPropertyName = "Maphieusuachua";
			this.Maphieusuachua.HeaderText = "Mã phiếu sữa chữa";
			this.Maphieusuachua.MinimumWidth = 6;
			this.Maphieusuachua.Name = "Maphieusuachua";
			this.Maphieusuachua.Width = 125;
			// 
			// Manhanvien
			// 
			this.Manhanvien.DataPropertyName = "Manhanvien";
			this.Manhanvien.HeaderText = "Mã giáo viên";
			this.Manhanvien.MinimumWidth = 6;
			this.Manhanvien.Name = "Manhanvien";
			this.Manhanvien.Width = 125;
			// 
			// Tennhanvien
			// 
			this.Tennhanvien.DataPropertyName = "Tennhanvien";
			this.Tennhanvien.HeaderText = "Tên giáo viên";
			this.Tennhanvien.MinimumWidth = 6;
			this.Tennhanvien.Name = "Tennhanvien";
			this.Tennhanvien.Width = 125;
			// 
			// Madonvi
			// 
			this.Madonvi.DataPropertyName = "Madonvi";
			this.Madonvi.HeaderText = "Mã bộ môn";
			this.Madonvi.MinimumWidth = 6;
			this.Madonvi.Name = "Madonvi";
			this.Madonvi.Width = 125;
			// 
			// Tendonvi
			// 
			this.Tendonvi.DataPropertyName = "Tendonvi";
			this.Tendonvi.HeaderText = "Tên bộ môn";
			this.Tendonvi.MinimumWidth = 6;
			this.Tendonvi.Name = "Tendonvi";
			this.Tendonvi.Width = 125;
			// 
			// Ngaysuachua
			// 
			this.Ngaysuachua.DataPropertyName = "Ngaysuachua";
			this.Ngaysuachua.HeaderText = "Ngày báo cáo";
			this.Ngaysuachua.MinimumWidth = 6;
			this.Ngaysuachua.Name = "Ngaysuachua";
			this.Ngaysuachua.Width = 125;
			// 
			// Soluongsuachua
			// 
			this.Soluongsuachua.DataPropertyName = "Soluongsuachua";
			this.Soluongsuachua.HeaderText = "Số lượng";
			this.Soluongsuachua.MinimumWidth = 6;
			this.Soluongsuachua.Name = "Soluongsuachua";
			this.Soluongsuachua.Width = 125;
			// 
			// Ghichu
			// 
			this.Ghichu.DataPropertyName = "Ghichu";
			this.Ghichu.HeaderText = "Ghi chú";
			this.Ghichu.MinimumWidth = 6;
			this.Ghichu.Name = "Ghichu";
			this.Ghichu.Width = 125;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(390, 29);
			this.label3.TabIndex = 60;
			this.label3.Text = "TỔNG HỢP THIẾT BỊ HƯ HỎNG";
			// 
			// btnThemTK
			// 
			this.btnThemTK.BackColor = System.Drawing.Color.White;
			this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemTK.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnThemTK.Location = new System.Drawing.Point(501, 504);
			this.btnThemTK.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemTK.Name = "btnThemTK";
			this.btnThemTK.Size = new System.Drawing.Size(132, 63);
			this.btnThemTK.TabIndex = 50;
			this.btnThemTK.Text = "Đóng";
			this.btnThemTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemTK.UseVisualStyleBackColor = false;
			this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
			// 
			// TongHopThietBiHuHong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1167, 580);
			this.Controls.Add(this.btnThemTK);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TongHopThietBiHuHong";
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