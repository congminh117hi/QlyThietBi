namespace QuanLyThietBi
{
    partial class DeviceOfferForm
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
            this.dgPhieuDX = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Maphieudexuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydexuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuDX)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPhieuDX
            // 
            this.dgPhieuDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuDX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphieudexuat,
            this.Manhanvien,
            this.Tennhanvien,
            this.Madonvi,
            this.Tendonvi,
            this.Ghichu,
            this.Mathietbi,
            this.Tenthietbi,
            this.Soluong,
            this.Ngaydexuat});
            this.dgPhieuDX.Location = new System.Drawing.Point(3, 3);
            this.dgPhieuDX.Name = "dgPhieuDX";
            this.dgPhieuDX.RowHeadersWidth = 102;
            this.dgPhieuDX.Size = new System.Drawing.Size(1066, 419);
            this.dgPhieuDX.TabIndex = 0;
            this.dgPhieuDX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuDX_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dgPhieuDX);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1069, 427);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(489, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "TỔNG HỢP ĐỀ XUẤT THIÊT BỊ";
            // 
            // Maphieudexuat
            // 
            this.Maphieudexuat.DataPropertyName = "Maphieudexuat";
            this.Maphieudexuat.HeaderText = "Mã phiếu đề xuất";
            this.Maphieudexuat.Name = "Maphieudexuat";
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
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // Mathietbi
            // 
            this.Mathietbi.DataPropertyName = "Mathietbi";
            this.Mathietbi.HeaderText = "Mã thiết bị";
            this.Mathietbi.Name = "Mathietbi";
            // 
            // Tenthietbi
            // 
            this.Tenthietbi.DataPropertyName = "Tenthietbi";
            this.Tenthietbi.HeaderText = "Tên thiết bị";
            this.Tenthietbi.Name = "Tenthietbi";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng đề xuất";
            this.Soluong.Name = "Soluong";
            // 
            // Ngaydexuat
            // 
            this.Ngaydexuat.DataPropertyName = "Ngaydexuat";
            this.Ngaydexuat.HeaderText = "Ngày đề xuất";
            this.Ngaydexuat.Name = "Ngaydexuat";
            // 
            // DeviceOfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1074, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceOfferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo đề xuất thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuDX)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPhieuDX;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieudexuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendonvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydexuat;
    }
}