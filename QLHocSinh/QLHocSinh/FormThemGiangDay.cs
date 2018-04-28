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
    public partial class FormThemGiangDay : Form
    {
        private SqlConnection conn;
        public FormThemGiangDay(SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
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
        private void getdata()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from GIAOVIEN";
            da.SelectCommand = cm;
            da.Fill(data);
            cmbMaGV.DataSource = data;
            cmbMaGV.DisplayMember = "HoTen";
            cmbMaGV.ValueMember = "MaGV";
            //cmbMaGV.SelectedValue = "MaGV";


            cm.CommandText = "select * from LOP";
            da.SelectCommand = cm;
            da.Fill(data1);
            cmbLopHoc.DataSource = data1;
            cmbLopHoc.DisplayMember = "MaHienThi";
            cmbLopHoc.ValueMember = "MaLop";
            //cmbLopHoc.SelectedValue = "MaLop";
        }
        private bool isEmpty()
        {
            if(cmbMaGV.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn giáo viên", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbLopHoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn lớp học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbThu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thứ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbTiet.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tiết", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbHocki.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn học kỳ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtNamHoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm học", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void clear()
        {
            getdata();
            cmbThu.Text = "";
            cmbTiet.Text = "";
            cmbHocki.Text = "";
            txtNamHoc.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormThemGiangDay_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            try
            {
                DialogResult dg = MessageBox.Show("Bạn muốn thêm thông tin giảng dạy", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    connect();
                    SqlCommand command = new SqlCommand("SP_THEMLICHGIANGDAY", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MaGV", cmbMaGV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@MaLop", cmbLopHoc.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Thu", int.Parse(cmbThu.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@Tiet", int.Parse(cmbTiet.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@Hocky", int.Parse(cmbHocki.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@NamHoc", int.Parse(txtNamHoc.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    disconect();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGiangDay gd = new FormGiangDay();
            gd.Show();

        }

        private void FormThemGiangDay_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormThemGiangDay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
