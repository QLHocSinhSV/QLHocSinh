namespace Quan_Ly_Hoc_Sinh
{
    partial class FormTKB
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.CmbMa = new System.Windows.Forms.ComboBox();
            this.cmbHocKi = new System.Windows.Forms.ComboBox();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGTKB = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(472, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỜI KHÓA BIỂU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnxem);
            this.groupBox1.Controls.Add(this.CmbMa);
            this.groupBox1.Controls.Add(this.cmbHocKi);
            this.groupBox1.Controls.Add(this.cmbNamHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(80, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1083, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(951, 21);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 28);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(813, 25);
            this.btnxem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(108, 26);
            this.btnxem.TabIndex = 5;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // CmbMa
            // 
            this.CmbMa.FormattingEnabled = true;
            this.CmbMa.Location = new System.Drawing.Point(567, 23);
            this.CmbMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbMa.Name = "CmbMa";
            this.CmbMa.Size = new System.Drawing.Size(191, 24);
            this.CmbMa.TabIndex = 4;
            // 
            // cmbHocKi
            // 
            this.cmbHocKi.FormattingEnabled = true;
            this.cmbHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbHocKi.Location = new System.Drawing.Point(344, 25);
            this.cmbHocKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHocKi.Name = "cmbHocKi";
            this.cmbHocKi.Size = new System.Drawing.Size(112, 24);
            this.cmbHocKi.TabIndex = 2;
            this.cmbHocKi.Text = "1";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbNamHoc.Location = new System.Drawing.Point(116, 25);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(105, 24);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.Text = "2010";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Học Kì :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lớp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm Học :";
            // 
            // dataGTKB
            // 
            this.dataGTKB.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGTKB.Location = new System.Drawing.Point(80, 208);
            this.dataGTKB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGTKB.Name = "dataGTKB";
            this.dataGTKB.Size = new System.Drawing.Size(1083, 487);
            this.dataGTKB.TabIndex = 2;
            // 
            // FormTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 729);
            this.Controls.Add(this.dataGTKB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTKB";
            this.Text = "FormTKB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTKB_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTKB_FormClosed);
            this.Load += new System.EventHandler(this.FormTKB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbMa;
        private System.Windows.Forms.ComboBox cmbHocKi;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGTKB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnxem;
    }
}