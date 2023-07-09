namespace QuanLyThietBi
{
    partial class ThemBoMon
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
			this.btnThemDV = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtMadonvi = new System.Windows.Forms.TextBox();
			this.txtEmaildonvi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSDTdonvi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTendonvi = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnThemTK = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnThemDV
			// 
			this.btnThemDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemDV.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemDV.Location = new System.Drawing.Point(148, 257);
			this.btnThemDV.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemDV.Name = "btnThemDV";
			this.btnThemDV.Size = new System.Drawing.Size(132, 63);
			this.btnThemDV.TabIndex = 21;
			this.btnThemDV.Text = "Thêm\r\n bộ môn";
			this.btnThemDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemDV.UseVisualStyleBackColor = true;
			this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
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
			this.panel3.Location = new System.Drawing.Point(3, 46);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(425, 203);
			this.panel3.TabIndex = 22;
			// 
			// txtMadonvi
			// 
			this.txtMadonvi.Enabled = false;
			this.txtMadonvi.Location = new System.Drawing.Point(188, 22);
			this.txtMadonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtMadonvi.Name = "txtMadonvi";
			this.txtMadonvi.Size = new System.Drawing.Size(225, 22);
			this.txtMadonvi.TabIndex = 8;
			// 
			// txtEmaildonvi
			// 
			this.txtEmaildonvi.Location = new System.Drawing.Point(203, 168);
			this.txtEmaildonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmaildonvi.Name = "txtEmaildonvi";
			this.txtEmaildonvi.Size = new System.Drawing.Size(210, 22);
			this.txtEmaildonvi.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 165);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(182, 26);
			this.label9.TabIndex = 6;
			this.label9.Text = "Email GV bộ môn:";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// txtSDTdonvi
			// 
			this.txtSDTdonvi.Location = new System.Drawing.Point(188, 121);
			this.txtSDTdonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtSDTdonvi.Name = "txtSDTdonvi";
			this.txtSDTdonvi.Size = new System.Drawing.Size(225, 22);
			this.txtSDTdonvi.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 118);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(170, 26);
			this.label10.TabIndex = 4;
			this.label10.Text = "SDT GV bộ môn:";
			// 
			// txtTendonvi
			// 
			this.txtTendonvi.Location = new System.Drawing.Point(188, 71);
			this.txtTendonvi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTendonvi.Name = "txtTendonvi";
			this.txtTendonvi.Size = new System.Drawing.Size(225, 22);
			this.txtTendonvi.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(13, 69);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 26);
			this.label11.TabIndex = 2;
			this.label11.Text = "Tên Bộ Môn:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(13, 21);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(123, 26);
			this.label12.TabIndex = 0;
			this.label12.Text = "Mã bộ môn:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(-3, 11);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 29);
			this.label7.TabIndex = 63;
			this.label7.Text = "Thêm bộ môn";
			// 
			// btnThemTK
			// 
			this.btnThemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemTK.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnThemTK.Location = new System.Drawing.Point(288, 257);
			this.btnThemTK.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemTK.Name = "btnThemTK";
			this.btnThemTK.Size = new System.Drawing.Size(132, 63);
			this.btnThemTK.TabIndex = 64;
			this.btnThemTK.Text = "Đóng";
			this.btnThemTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemTK.UseVisualStyleBackColor = true;
			this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
			// 
			// ThemBoMon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(431, 324);
			this.Controls.Add(this.btnThemTK);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btnThemDV);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ThemBoMon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm bộ môn";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadonvi;
        private System.Windows.Forms.TextBox txtEmaildonvi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDTdonvi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTendonvi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemTK;
    }
}