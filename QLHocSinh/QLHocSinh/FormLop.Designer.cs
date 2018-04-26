namespace Quan_Ly_Hoc_Sinh
{
    partial class FormLop
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
            this.lblLop = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblSiso = new System.Windows.Forms.Label();
            this.lblGVCN = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(39, 28);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(40, 17);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp: ";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(39, 78);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(80, 17);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng học:";
            // 
            // lblSiso
            // 
            this.lblSiso.AutoSize = true;
            this.lblSiso.Location = new System.Drawing.Point(298, 28);
            this.lblSiso.Name = "lblSiso";
            this.lblSiso.Size = new System.Drawing.Size(47, 17);
            this.lblSiso.TabIndex = 2;
            this.lblSiso.Text = "Sĩ số: ";
            // 
            // lblGVCN
            // 
            this.lblGVCN.AutoSize = true;
            this.lblGVCN.Location = new System.Drawing.Point(298, 78);
            this.lblGVCN.Name = "lblGVCN";
            this.lblGVCN.Size = new System.Drawing.Size(145, 17);
            this.lblGVCN.TabIndex = 3;
            this.lblGVCN.Text = "Giáo viên chủ nhiệm: ";
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLop.Location = new System.Drawing.Point(0, 156);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(726, 273);
            this.dgvLop.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danh sách học sinh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.lblGVCN);
            this.Controls.Add(this.lblSiso);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblLop);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblSiso;
        private System.Windows.Forms.Label lblGVCN;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}