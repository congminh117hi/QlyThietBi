namespace QuanLyThietBi
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.đềXuấtThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loạiThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThiếtBịToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.quảnLýThiếtBịSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.theoDõiThiếtBịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.hóaĐơnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hóaĐơnNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.báoCáoHưHỏngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// đềXuấtThiếtBịToolStripMenuItem
			// 
			this.đềXuấtThiếtBịToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.desktop_15142;
			this.đềXuấtThiếtBịToolStripMenuItem.Name = "đềXuấtThiếtBịToolStripMenuItem";
			this.đềXuấtThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
			this.đềXuấtThiếtBịToolStripMenuItem.Text = "Đề Xuất  Mượn Thiết Bị";
			this.đềXuấtThiếtBịToolStripMenuItem.Click += new System.EventHandler(this.đềXuấtThiếtBịToolStripMenuItem_Click);
			// 
			// nhânViênToolStripMenuItem
			// 
			this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đềXuấtThiếtBịToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
			this.nhânViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
			this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
			this.nhânViênToolStripMenuItem.Text = "Quản Lý Phòng Học";
			this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
			// 
			// thôngTinCáNhânToolStripMenuItem
			// 
			this.thôngTinCáNhânToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.desktop_15142;
			this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
			this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
			this.thôngTinCáNhânToolStripMenuItem.Text = "Báo Cáo Hư Hỏng";
			this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.login;
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
			this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
			this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(9, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(398, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// adminToolStripMenuItem
			// 
			this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem7,
            this.quảnLýThiếtBịToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.đăngXuấtToolStripMenuItem1});
			this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			this.adminToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
			this.adminToolStripMenuItem.Text = "Quản Lý";
			this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Image = global::QuanLyThietBi.Properties.Resources.bookcase;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem4.Text = "Quản Lý Bộ Môn";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.nhânViênToolStripMenuItem1});
			this.toolStripMenuItem7.Image = global::QuanLyThietBi.Properties.Resources.user_icon_251962;
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem7.Text = "Quản Lý Giáo Viên";
			this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
			// 
			// tàiKhoảnToolStripMenuItem
			// 
			this.tàiKhoảnToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.user_pen_icon_251954;
			this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
			this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
			this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
			// 
			// nhânViênToolStripMenuItem1
			// 
			this.nhânViênToolStripMenuItem1.Image = global::QuanLyThietBi.Properties.Resources.user_icon_251962;
			this.nhânViênToolStripMenuItem1.Name = "nhânViênToolStripMenuItem1";
			this.nhânViênToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.nhânViênToolStripMenuItem1.Text = "Giáo Viên";
			this.nhânViênToolStripMenuItem1.Click += new System.EventHandler(this.nhânViênToolStripMenuItem1_Click);
			// 
			// quảnLýThiếtBịToolStripMenuItem
			// 
			this.quảnLýThiếtBịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiThiếtBịToolStripMenuItem,
            this.quảnLýThiếtBịToolStripMenuItem1,
            this.quảnLýThiếtBịSửDụngToolStripMenuItem,
            this.theoDõiThiếtBịToolStripMenuItem});
			this.quảnLýThiếtBịToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources._1458264592_laptop_computer_pc_device_notebook_netbook_internet_icon_icons_com_55334;
			this.quảnLýThiếtBịToolStripMenuItem.Name = "quảnLýThiếtBịToolStripMenuItem";
			this.quảnLýThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.quảnLýThiếtBịToolStripMenuItem.Text = "Quản Lý Thiết Bị";
			this.quảnLýThiếtBịToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThiếtBịToolStripMenuItem_Click);
			// 
			// loạiThiếtBịToolStripMenuItem
			// 
			this.loạiThiếtBịToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.monitor_settings_icon_148737;
			this.loạiThiếtBịToolStripMenuItem.Name = "loạiThiếtBịToolStripMenuItem";
			this.loạiThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.loạiThiếtBịToolStripMenuItem.Text = "Loại Thiết Bị";
			this.loạiThiếtBịToolStripMenuItem.Click += new System.EventHandler(this.loạiThiếtBịToolStripMenuItem_Click);
			// 
			// quảnLýThiếtBịToolStripMenuItem1
			// 
			this.quảnLýThiếtBịToolStripMenuItem1.Image = global::QuanLyThietBi.Properties.Resources.in_door_communication_enter_log_in_login_icon_191647__1_;
			this.quảnLýThiếtBịToolStripMenuItem1.Name = "quảnLýThiếtBịToolStripMenuItem1";
			this.quảnLýThiếtBịToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.quảnLýThiếtBịToolStripMenuItem1.Text = "Nhập Thiết Bị";
			this.quảnLýThiếtBịToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýThiếtBịToolStripMenuItem1_Click);
			// 
			// quảnLýThiếtBịSửDụngToolStripMenuItem
			// 
			this.quảnLýThiếtBịSửDụngToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.hand_outline_gesture_10_113966;
			this.quảnLýThiếtBịSửDụngToolStripMenuItem.Name = "quảnLýThiếtBịSửDụngToolStripMenuItem";
			this.quảnLýThiếtBịSửDụngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.quảnLýThiếtBịSửDụngToolStripMenuItem.Text = " Thiết Bị Sử Dụng";
			this.quảnLýThiếtBịSửDụngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThiếtBịSửDụngToolStripMenuItem_Click);
			// 
			// theoDõiThiếtBịToolStripMenuItem
			// 
			this.theoDõiThiếtBịToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.low_thecomputer_theapplication_2917;
			this.theoDõiThiếtBịToolStripMenuItem.Name = "theoDõiThiếtBịToolStripMenuItem";
			this.theoDõiThiếtBịToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.theoDõiThiếtBịToolStripMenuItem.Text = "Theo Dõi Thiết Bị";
			this.theoDõiThiếtBịToolStripMenuItem.Click += new System.EventHandler(this.theoDõiThiếtBịToolStripMenuItem_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnXuấtToolStripMenuItem,
            this.hóaĐơnNhậpToolStripMenuItem});
			this.toolStripMenuItem5.Image = global::QuanLyThietBi.Properties.Resources.document_format_page_paper_file_icon_252009;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem5.Text = "Quản Lý Tạo Phiếu";
			// 
			// hóaĐơnXuấtToolStripMenuItem
			// 
			this.hóaĐơnXuấtToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.document_format_page_paper_file_icon_252009;
			this.hóaĐơnXuấtToolStripMenuItem.Name = "hóaĐơnXuấtToolStripMenuItem";
			this.hóaĐơnXuấtToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.hóaĐơnXuấtToolStripMenuItem.Text = "Xem Phiếu Đề Xuất";
			this.hóaĐơnXuấtToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnXuấtToolStripMenuItem_Click);
			// 
			// hóaĐơnNhậpToolStripMenuItem
			// 
			this.hóaĐơnNhậpToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.desktop_15142;
			this.hóaĐơnNhậpToolStripMenuItem.Name = "hóaĐơnNhậpToolStripMenuItem";
			this.hóaĐơnNhậpToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
			this.hóaĐơnNhậpToolStripMenuItem.Text = "Tạo Phiếu Nhập";
			this.hóaĐơnNhậpToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnNhậpToolStripMenuItem_Click);
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoHưHỏngToolStripMenuItem});
			this.toolStripMenuItem8.Image = global::QuanLyThietBi.Properties.Resources.notes_icon_251990;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem8.Text = "Quản Lý Báo Cáo";
			// 
			// báoCáoHưHỏngToolStripMenuItem
			// 
			this.báoCáoHưHỏngToolStripMenuItem.Image = global::QuanLyThietBi.Properties.Resources.notes_icon_251990;
			this.báoCáoHưHỏngToolStripMenuItem.Name = "báoCáoHưHỏngToolStripMenuItem";
			this.báoCáoHưHỏngToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
			this.báoCáoHưHỏngToolStripMenuItem.Text = "Xem Báo Cáo Hư Hỏng";
			this.báoCáoHưHỏngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoHưHỏngToolStripMenuItem_Click);
			// 
			// đăngXuấtToolStripMenuItem1
			// 
			this.đăngXuấtToolStripMenuItem1.Image = global::QuanLyThietBi.Properties.Resources.login;
			this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
			this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.đăngXuấtToolStripMenuItem1.Text = "Đăng Xuất";
			this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 32);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(769, 406);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 440);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phầm mềm quản lý trang thiết bị trường học";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đềXuấtThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem báoCáoHưHỏngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThiếtBịSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoDõiThiếtBịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiThiếtBịToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

