namespace Quan_Ly_Hoc_Sinh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnhocsinh = new System.Windows.Forms.Button();
            this.btngiaovien = new System.Windows.Forms.Button();
            this.btnlichgiangday = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.hstc = new System.Windows.Forms.ToolStripMenuItem();
            this.gvtc = new System.Windows.Forms.ToolStripMenuItem();
            this.lgdtc = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tchelp = new System.Windows.Forms.ToolStripButton();
            this.dxtc = new System.Windows.Forms.ToolStripButton();
            this.lbltenandloai = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnhocsinh
            // 
            this.btnhocsinh.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493875195_Student_3;
            this.btnhocsinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnhocsinh.Location = new System.Drawing.Point(59, 129);
            this.btnhocsinh.Name = "btnhocsinh";
            this.btnhocsinh.Size = new System.Drawing.Size(103, 83);
            this.btnhocsinh.TabIndex = 4;
            this.btnhocsinh.Text = "&Học Sinh";
            this.btnhocsinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhocsinh.UseVisualStyleBackColor = true;
            this.btnhocsinh.Click += new System.EventHandler(this.btnhocsinh_Click);
            // 
            // btngiaovien
            // 
            this.btngiaovien.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493875224_Teachers_24;
            this.btngiaovien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngiaovien.Location = new System.Drawing.Point(239, 129);
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.Size = new System.Drawing.Size(103, 83);
            this.btngiaovien.TabIndex = 5;
            this.btngiaovien.Text = "&Giáo Viên";
            this.btngiaovien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngiaovien.UseVisualStyleBackColor = true;
            this.btngiaovien.Click += new System.EventHandler(this.btngiaovien_Click);
            // 
            // btnlichgiangday
            // 
            this.btnlichgiangday.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493875273_calendar;
            this.btnlichgiangday.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlichgiangday.Location = new System.Drawing.Point(421, 129);
            this.btnlichgiangday.Name = "btnlichgiangday";
            this.btnlichgiangday.Size = new System.Drawing.Size(103, 83);
            this.btnlichgiangday.TabIndex = 6;
            this.btnlichgiangday.Text = "&Lịch Giảng dạy";
            this.btnlichgiangday.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlichgiangday.UseVisualStyleBackColor = true;
            this.btnlichgiangday.Click += new System.EventHandler(this.btnlichgiangday_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493877311_list_alt;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(628, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Danh sách lớp";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tchelp,
            this.dxtc,
            this.lbltenandloai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hstc,
            this.gvtc,
            this.lgdtc,
            this.danhSáchLớpToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // hstc
            // 
            this.hstc.Image = ((System.Drawing.Image)(resources.GetObject("hstc.Image")));
            this.hstc.Name = "hstc";
            this.hstc.Size = new System.Drawing.Size(153, 22);
            this.hstc.Text = "Học Sinh";
            this.hstc.Click += new System.EventHandler(this.hstc_Click);
            // 
            // gvtc
            // 
            this.gvtc.Image = ((System.Drawing.Image)(resources.GetObject("gvtc.Image")));
            this.gvtc.Name = "gvtc";
            this.gvtc.Size = new System.Drawing.Size(153, 22);
            this.gvtc.Text = "Giáo Viên";
            this.gvtc.Click += new System.EventHandler(this.gvtc_Click);
            // 
            // lgdtc
            // 
            this.lgdtc.Image = ((System.Drawing.Image)(resources.GetObject("lgdtc.Image")));
            this.lgdtc.Name = "lgdtc";
            this.lgdtc.Size = new System.Drawing.Size(153, 22);
            this.lgdtc.Text = "Lịch Giảng Dạy";
            this.lgdtc.Click += new System.EventHandler(this.lgdtc_Click);
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            this.danhSáchLớpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhSáchLớpToolStripMenuItem.Image")));
            this.danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            this.danhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.danhSáchLớpToolStripMenuItem.Text = "Danh Sách Lớp";
            this.danhSáchLớpToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLớpToolStripMenuItem_Click);
            // 
            // tchelp
            // 
            this.tchelp.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493873182_help_browser;
            this.tchelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tchelp.Name = "tchelp";
            this.tchelp.Size = new System.Drawing.Size(72, 22);
            this.tchelp.Text = "&Trợ Giúp";
            this.tchelp.Click += new System.EventHandler(this.tchelp_Click);
            // 
            // dxtc
            // 
            this.dxtc.Image = global::Quan_Ly_Hoc_Sinh.Properties.Resources._1493874057_logout;
            this.dxtc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dxtc.Name = "dxtc";
            this.dxtc.Size = new System.Drawing.Size(82, 22);
            this.dxtc.Text = "Đăng Xuất";
            this.dxtc.Click += new System.EventHandler(this.dxtc_Click);
            // 
            // lbltenandloai
            // 
            this.lbltenandloai.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbltenandloai.Name = "lbltenandloai";
            this.lbltenandloai.Size = new System.Drawing.Size(81, 22);
            this.lbltenandloai.Text = "Chào User VIP";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlichgiangday);
            this.Controls.Add(this.btngiaovien);
            this.Controls.Add(this.btnhocsinh);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhocsinh;
        private System.Windows.Forms.Button btngiaovien;
        private System.Windows.Forms.Button btnlichgiangday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem hstc;
        private System.Windows.Forms.ToolStripMenuItem gvtc;
        private System.Windows.Forms.ToolStripMenuItem lgdtc;
        private System.Windows.Forms.ToolStripButton dxtc;
        private System.Windows.Forms.ToolStripLabel lbltenandloai;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tchelp;
    }
}