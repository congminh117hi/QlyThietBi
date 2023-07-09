namespace QuanLyThietBi
{
    partial class ThemLoaiThietBi
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
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMaloaithietbi = new System.Windows.Forms.TextBox();
			this.txtTenloaithietbi = new System.Windows.Forms.TextBox();
			this.btnThemLTB = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.txtMaloaithietbi);
			this.panel2.Controls.Add(this.txtTenloaithietbi);
			this.panel2.Location = new System.Drawing.Point(3, 38);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(487, 114);
			this.panel2.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 70);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(177, 26);
			this.label11.TabIndex = 6;
			this.label11.Text = "Tên Loại Thiết Bị:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(4, 22);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(168, 26);
			this.label12.TabIndex = 5;
			this.label12.Text = "Mã Loại Thiết Bị:";
			// 
			// txtMaloaithietbi
			// 
			this.txtMaloaithietbi.Enabled = false;
			this.txtMaloaithietbi.Location = new System.Drawing.Point(241, 25);
			this.txtMaloaithietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaloaithietbi.Name = "txtMaloaithietbi";
			this.txtMaloaithietbi.Size = new System.Drawing.Size(225, 22);
			this.txtMaloaithietbi.TabIndex = 4;
			// 
			// txtTenloaithietbi
			// 
			this.txtTenloaithietbi.Location = new System.Drawing.Point(241, 73);
			this.txtTenloaithietbi.Margin = new System.Windows.Forms.Padding(4);
			this.txtTenloaithietbi.Name = "txtTenloaithietbi";
			this.txtTenloaithietbi.Size = new System.Drawing.Size(225, 22);
			this.txtTenloaithietbi.TabIndex = 3;
			// 
			// btnThemLTB
			// 
			this.btnThemLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemLTB.Image = global::QuanLyThietBi.Properties.Resources.edit_add;
			this.btnThemLTB.Location = new System.Drawing.Point(140, 160);
			this.btnThemLTB.Margin = new System.Windows.Forms.Padding(4);
			this.btnThemLTB.Name = "btnThemLTB";
			this.btnThemLTB.Size = new System.Drawing.Size(132, 63);
			this.btnThemLTB.TabIndex = 33;
			this.btnThemLTB.Text = "Thêm\r\nLoại Thiết Bị";
			this.btnThemLTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnThemLTB.UseVisualStyleBackColor = true;
			this.btnThemLTB.Click += new System.EventHandler(this.btnThemLTB_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Image = global::QuanLyThietBi.Properties.Resources.edit_delete;
			this.btnClose.Location = new System.Drawing.Point(339, 160);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(132, 63);
			this.btnClose.TabIndex = 34;
			this.btnClose.Text = "Đóng";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 5);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(264, 29);
			this.label3.TabIndex = 63;
			this.label3.Text = "THÊM LOẠI THIẾT BỊ";
			// 
			// ThemLoaiThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(503, 225);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnThemLTB);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ThemLoaiThietBi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm loại thiết bị";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenloaithietbi;
        private System.Windows.Forms.Button btnThemLTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaloaithietbi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
    }
}