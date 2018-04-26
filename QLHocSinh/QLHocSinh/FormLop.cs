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
    public partial class FormLop : Form
    {
        public int malop;
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
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
                MessageBox.Show("Loi");
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
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_HIENTHI_HOCSINH";
            command.Parameters.Add(new SqlParameter("@malop", malop));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvLop.DataSource = dt;
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "mahienthi";
            cl.HeaderText = "Mã";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "hoten";
            cl.HeaderText = "Họ tên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ngaysinh";
            cl.HeaderText = "Ngày sinh";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "gioitinh";
            cl.HeaderText = "Giới tính";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "diachi";
            cl.HeaderText = "Địa chỉ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "dantoc";
            cl.HeaderText = "Dân tộc";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "quequan";
            cl.HeaderText = "Quê Quán";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "dienthoai";
            cl.HeaderText = "Điện thoại";
            dgv.Columns.Add(cl);
        }
        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(globalParameter.str);
            conn.Open();
            SqlCommand cm = new SqlCommand("sp_THONGTINLOP", conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add(new SqlParameter("@malop", malop));
            SqlDataReader r = cm.ExecuteReader();
            if (r.Read())
            {
                lblLop.Text += r["mahienthi"].ToString();
                lblPhong.Text += r["phong"].ToString();
                lblSiso.Text += r["siso"].ToString();
                lblGVCN.Text += r["hoten"].ToString();
            }
            conn.Close();
            connect();           
            initGrid(dgvLop);
            getdata();
            disconect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDanhSachLop fr = new FormDanhSachLop();
            fr.Show();
            Hide();
        }
    }
}
