using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quan_Ly_Hoc_Sinh.Class;

namespace Quan_Ly_Hoc_Sinh
{
    public partial class FormTKB : Form
    {
        private SqlConnection conn;
        // private SqlDataAdapter da = new SqlDataAdapter();

        public FormTKB()
        {
            InitializeComponent();

        }
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("LỖI");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public void getdata()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from LOP";
            da.SelectCommand = cm;
            da.Fill(data);

            CmbMa.DataSource = data;
            CmbMa.DisplayMember = "MaHienThi";
            CmbMa.ValueMember = "MaLop";

        }
        private void FormTKB_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            try
            {

                connect();
                SqlCommand command = new SqlCommand("SP_TKBLOP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@malop", CmbMa.SelectedValue));
                command.Parameters.Add(new SqlParameter("@namhoc", int.Parse(cmbNamHoc.SelectedItem.ToString())));
                command.Parameters.Add(new SqlParameter("@hocky", int.Parse(cmbHocKi.SelectedItem.ToString())));
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGTKB.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormGiangDay gd = new FormGiangDay();
            this.Hide();
            gd.Show();
        }

        private void FormTKB_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormTKB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}


