namespace QuanLyThietBi
{
    partial class AddTODForm
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
            this.panel2.Location = new System.Drawing.Point(2, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 93);
            this.panel2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tên Loại Thiết Bị:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Mã Loại Thiết Bị:";
            // 
            // txtMaloaithietbi
            // 
            this.txtMaloaithietbi.Enabled = false;
            this.txtMaloaithietbi.Location = new System.Drawing.Point(158, 19);
            this.txtMaloaithietbi.Name = "txtMaloaithietbi";
            this.txtMaloaithietbi.Size = new System.Drawing.Size(170, 20);
            this.txtMaloaithietbi.TabIndex = 4;
            // 
            // txtTenloaithietbi
            // 
            this.txtTenloaithietbi.Location = new System.Drawing.Point(158, 58);
            this.txtTenloaithietbi.Name = "txtTenloaithietbi";
            this.txtTenloaithietbi.Size = new System.Drawing.Size(170, 20);
            this.txtTenloaithietbi.TabIndex = 3;
            // 
            // btnThemLTB
            // 
            this.btnThemLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLTB.Location = new System.Drawing.Point(121, 130);
            this.btnThemLTB.Name = "btnThemLTB";
            this.btnThemLTB.Size = new System.Drawing.Size(99, 51);
            this.btnThemLTB.TabIndex = 33;
            this.btnThemLTB.Text = "Thêm\r\nLoại Thiết Bị";
            this.btnThemLTB.UseVisualStyleBackColor = true;
            this.btnThemLTB.Click += new System.EventHandler(this.btnThemLTB_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(226, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 51);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "THÊM LOẠI THIẾT BỊ";
            // 
            // AddTODForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(339, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnThemLTB);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTODForm";
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