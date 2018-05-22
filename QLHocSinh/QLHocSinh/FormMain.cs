using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hoc_Sinh
{
    public partial class FormMain : Form
    {
        public String tentk;
        public FormMain()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Hàm bắt sự kiện nhập phím
        {
            switch (keyData)
            {
                case Keys.F1: //Bắt sự kiện nhập phím F1
                    FormHelp fmHelp = new FormHelp();
                    fmHelp.Show();
                    break;
                //Thêm phím tắt vào đây case2,3,.....

            }
            return base.ProcessCmdKey(ref msg, keyData);//Made by Dat_Dz
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FormLogin.quyen == false)
            {
                lbltenandloai.Text = "Chào User " + tentk;
            }
            else
            {
                lbltenandloai.Text = "Chào Admin " + tentk;
            }
        }


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString().Equals("UserClosing"))
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnhocsinh_Click(object sender, EventArgs e)
        {
            FormHocSinh fr = new FormHocSinh();
            fr.Show();
            Hide();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            FormGiaoVien fr = new FormGiaoVien();
            fr.Show();
            Hide();
        }

        private void btnlichgiangday_Click(object sender, EventArgs e)
        {
            FormGiangDay fr = new FormGiangDay();
            fr.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDanhSachLop fr = new FormDanhSachLop();
            fr.Show();
            Hide();
        }

        private void hstc_Click(object sender, EventArgs e)
        {
            FormHocSinh fr = new FormHocSinh();
            fr.Show();
            Hide();
        }

        private void gvtc_Click(object sender, EventArgs e)
        {
            FormGiaoVien fr = new FormGiaoVien();
            fr.Show();
            Hide();
        }

        private void lgdtc_Click(object sender, EventArgs e)
        {
            FormGiangDay fr = new FormGiangDay();
            fr.Show();
            Hide();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDanhSachLop fr = new FormDanhSachLop();
            fr.Show();
            Hide();
        }

        private void dxtc_Click(object sender, EventArgs e)
        {
            FormLogin fr = new FormLogin();
            fr.Show();
            Hide();
        }

        private void tchelp_Click(object sender, EventArgs e)
        {
            FormHelp fmHelp = new FormHelp();
            fmHelp.Show();
        }
    }
}
