namespace QuanLyThietBi
{
    partial class EmployerUnitForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMadonvi = new System.Windows.Forms.TextBox();
            this.txtEmaildonvi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDTdonvi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTendonvi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnCapnhatDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDonvi = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Madonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdtdonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emaildonvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDonvi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtMadonvi);
            this.panel3.Controls.Add(this.txtEmaildonvi);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSDTdonvi);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTendonvi);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(4, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 166);
            this.panel3.TabIndex = 16;
            // 
            // txtMadonvi
            // 
            this.txtMadonvi.Enabled = false;
            this.txtMadonvi.Location = new System.Drawing.Point(143, 14);
            this.txtMadonvi.Name = "txtMadonvi";
            this.txtMadonvi.Size = new System.Drawing.Size(170, 20);
            this.txtMadonvi.TabIndex = 8;
            // 
            // txtEmaildonvi
            // 
            this.txtEmaildonvi.Location = new System.Drawing.Point(143, 132);
            this.txtEmaildonvi.Name = "txtEmaildonvi";
            this.txtEmaildonvi.Size = new System.Drawing.Size(170, 20);
            this.txtEmaildonvi.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Email Đơn Vị:";
            // 
            // txtSDTdonvi
            // 
            this.txtSDTdonvi.Location = new System.Drawing.Point(143, 94);
            this.txtSDTdonvi.Name = "txtSDTdonvi";
            this.txtSDTdonvi.Size = new System.Drawing.Size(170, 20);
            this.txtSDTdonvi.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "SĐT Đơn vị:";
            // 
            // txtTendonvi
            // 
            this.txtTendonvi.Location = new System.Drawing.Point(143, 54);
            this.txtTendonvi.Name = "txtTendonvi";
            this.txtTendonvi.Size = new System.Drawing.Size(170, 20);
            this.txtTendonvi.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Đơn Vị:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Mã Đơn Vị:";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.White;
            this.btnXoaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.Color.Orange;
            this.btnXoaDV.Location = new System.Drawing.Point(218, 209);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(99, 51);
            this.btnXoaDV.TabIndex = 22;
            this.btnXoaDV.Text = "Xóa\r\nĐơn Vị";
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnCapnhatDV
            // 
            this.btnCapnhatDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhatDV.Location = new System.Drawing.Point(113, 209);
            this.btnCapnhatDV.Name = "btnCapnhatDV";
            this.btnCapnhatDV.Size = new System.Drawing.Size(99, 51);
            this.btnCapnhatDV.TabIndex = 21;
            this.btnCapnhatDV.Text = "Sửa Thông Tin\r\nĐơn Vị";
            this.btnCapnhatDV.UseVisualStyleBackColor = true;
            this.btnCapnhatDV.Click += new System.EventHandler(this.btnCapnhatDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.Location = new System.Drawing.Point(8, 209);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(99, 51);
            this.btnThemDV.TabIndex = 20;
            this.btnThemDV.Text = "Thêm\r\n Đơn Vị";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDonvi);
            this.panel1.Location = new System.Drawing.Point(330, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 166);
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
            this.dgDonvi.Location = new System.Drawing.Point(0, 0);
            this.dgDonvi.Name = "dgDonvi";
            this.dgDonvi.Size = new System.Drawing.Size(471, 166);
            this.dgDonvi.TabIndex = 0;
            this.dgDonvi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDonvi_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(696, 208);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "ĐƠN VỊ";
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
            // Sdtdonvi
            // 
            this.Sdtdonvi.DataPropertyName = "Sdtdonvi";
            this.Sdtdonvi.HeaderText = "Số điện thoại";
            this.Sdtdonvi.Name = "Sdtdonvi";
            // 
            // Emaildonvi
            // 
            this.Emaildonvi.DataPropertyName = "Emaildonvi";
            this.Emaildonvi.HeaderText = "Email";
            this.Emaildonvi.Name = "Emaildonvi";
            // 
            // EmployerUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(805, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnCapnhatDV);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployerUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐƠN VỊ";
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