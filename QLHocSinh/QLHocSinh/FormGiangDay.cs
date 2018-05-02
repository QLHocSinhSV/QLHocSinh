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
    public partial class FormGiangDay : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblGIANGDAY");
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
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_HIENTHILICHGIANGDAY";

            da.SelectCommand = command;
            da.Fill(dt);
            dataGGiangDay.DataSource = dt;
            //SqlCommand command = new SqlCommand();
            //command.Connection = conn;
            //command.CommandText = "select gd.Ma,gv.HoTen as GiaoVien,l.MaHienThi as Lop,Tiet , Thu,HocKy,NamHoc from GIAOVIEN gv left join GIANGDAY gd on gv.MaGV=gd.MaGV left join LOP l on gd.MaLop=l.MaLop";
            //da.SelectCommand = command;
            //da.Fill(dt);
            //dataGGiangDay.DataSource = dt;
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaHienThi";
            cl.HeaderText = "Mã Giáo Viên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTen";
            cl.HeaderText = "Tên Giáo Viên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Thu";
            cl.HeaderText = "Thứ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Tiet";
            cl.HeaderText = "Tiết";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Lop";
            cl.HeaderText = "Lớp";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HocKy";
            cl.HeaderText = "Học kỳ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NamHoc";
            cl.HeaderText = "Năm học";
            dgv.Columns.Add(cl);

        }
        private void getdata1()
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
            cmbMaLop.DataSource = data1;
            cmbMaLop.DisplayMember = "MaHienThi";
            cmbMaLop.ValueMember = "MaLop";
            // cmbMaLop.SelectedValue = "MaLop";

        }
        private void binding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dataGGiangDay.DataSource, "Ma");
            cmbMaGV.DataBindings.Clear();
            cmbMaGV.DataBindings.Add("Text", dataGGiangDay.DataSource, "HoTen");
            cmbMaLop.DataBindings.Clear();
            cmbMaLop.DataBindings.Add("Text", dataGGiangDay.DataSource, "Lop");
            cmbThu.DataBindings.Clear();
            cmbThu.DataBindings.Add("Text", dataGGiangDay.DataSource, "Thu");
            cmbTiet.DataBindings.Clear();
            cmbTiet.DataBindings.Add("Text", dataGGiangDay.DataSource, "Tiet");
            cmbHocKi.DataBindings.Clear();
            cmbHocKi.DataBindings.Add("Text", dataGGiangDay.DataSource, "HocKy");
            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", dataGGiangDay.DataSource, "NamHoc");

        }
        public void TextGotFocus(object sender, EventArgs e)
        {
            cmbNam = (ComboBox)sender;
            if (cmbNam.Text == "Năm Học")
            {
                cmbNam.Text = "";
                cmbNam.ForeColor = Color.Black;
            }
        }
        public void TextLostFocus(object sender, EventArgs e)
        {
            cmbNam = (ComboBox)sender;
            if (cmbNam.Text == "")
            {
                cmbNam.Text = "Năm Học";
                cmbNam.ForeColor = Color.LightGray;
            }
        }
        public void TextGotFocus1(object sender, EventArgs e)
        {

            cmbHocky = (ComboBox)sender;
            if (cmbHocky.Text == "Học Kỳ")
            {
                cmbHocky.Text = "";
                cmbHocky.ForeColor = Color.Black;
            }
        }
        public void TextLostFocus1(object sender, EventArgs e)
        {
            cmbHocky = (ComboBox)sender;
            if (cmbHocky.Text == "")
            {
                cmbHocky.Text = "Học Kỳ";
                cmbHocky.ForeColor = Color.LightGray;
            }
        }
        public void TextGotFocus2(object sender, EventArgs e)
        {

            txtTimKiem = (TextBox)sender;
            if (txtTimKiem.Text == "Nhập từ cần tìm ")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }
        public void TextLostFocus2(object sender, EventArgs e)
        {
            txtTimKiem = (TextBox)sender;
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập từ cần tìm ";
                txtTimKiem.ForeColor = Color.LightGray;
            }
        }
        private bool isEmpty()
        {
            if(cmbMaGV.Text.Length==0)
            {
                MessageBox.Show("Bạn chưa chọn Giáo viên", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbMaLop.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Lớp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbTiet.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Tiết", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbThu.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Thứ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmbHocKi.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn Học kỳ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtNamHoc.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập năm học", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public FormGiangDay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("SP_XOALICHGIANGDAY", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", txtMa.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    getdata();
                    disconect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormGiangDay_Load(object sender, EventArgs e)
        {
            connect();
            cmbNam.GotFocus += new EventHandler(this.TextGotFocus);
            cmbNam.LostFocus += new EventHandler(this.TextLostFocus);
            cmbHocky.GotFocus += new EventHandler(this.TextGotFocus1);
            cmbHocky.LostFocus += new EventHandler(this.TextLostFocus1);
            txtTimKiem.GotFocus += new EventHandler(this.TextGotFocus2);
            txtTimKiem.LostFocus += new EventHandler(this.TextLostFocus2);
            initGrid(dataGGiangDay);
            getdata();
            getdata1();

            if (FormLogin.quyen != true)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            disconect();
        }

        private void dataGGiangDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemGiangDay th = new FormThemGiangDay(conn);
            this.Hide();
            th.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain m = new FormMain();
            m.Show();
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            cmbMaGV.Enabled = true;
            cmbMaLop.Enabled = true;
            cmbTiet.Enabled = true;
            cmbThu.Enabled = true;
            cmbHocKi.Enabled = true;
            txtNamHoc.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnTimKiem.Enabled = false;
            dataGGiangDay.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTKB tkb = new FormTKB();
            this.Hide();
            tkb.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                connect();
                SqlCommand command = new SqlCommand("SP_TIMKIEMLICHGIANGDAY", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@namhoc", int.Parse(cmbNam.SelectedItem.ToString())));
                command.Parameters.Add(new SqlParameter("@hocky", int.Parse(cmbHocky.SelectedItem.ToString())));
                command.Parameters.Add(new SqlParameter("@mahienthiGV", txtTimKiem.Text));
                command.Parameters.Add(new SqlParameter("@mahienthiLop", txtTimKiem.Text));
                command.Parameters.Add(new SqlParameter("@tenGV", txtTimKiem.Text));
                da.SelectCommand = command;
                da.Fill(dt);
                dataGGiangDay.DataSource = dt;
                disconect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            connect();
            if (isEmpty()) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa bản ghi này?","Warning!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    SqlCommand command = new SqlCommand("SP_SUALICHGIANGDAY", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Ma", int.Parse(txtMa.Text)));
                    command.Parameters.Add(new SqlParameter("@MaGV", cmbMaGV.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@MaLop", cmbMaLop.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@Thu", int.Parse(cmbThu.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@Tiet", int.Parse(cmbTiet.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@Hocky", int.Parse(cmbHocKi.SelectedItem.ToString())));
                    command.Parameters.Add(new SqlParameter("@NamHoc", int.Parse(txtNamHoc.Text)));
                    command.ExecuteNonQuery();
                    dt.Clear();
                    getdata();

                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                cmbMaGV.Enabled = false;
                cmbMaLop.Enabled = false;
                cmbTiet.Enabled = false;
                cmbThu.Enabled = false;
                cmbHocKi.Enabled = false;
                txtNamHoc.Enabled = false;
                btnCapNhat.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;
                btnTimKiem.Enabled = true;
                dataGGiangDay.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmbMaGV.Enabled = false;
            cmbMaLop.Enabled = false;
            cmbTiet.Enabled = false;
            cmbThu.Enabled = false;
            cmbHocKi.Enabled = false;
            txtNamHoc.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            btnTimKiem.Enabled = true;
            dataGGiangDay.Enabled = true;
            dt.Clear();
            connect();
            getdata();
            disconect();
        }

        private void dataGGiangDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }

        private void FormGiangDay_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormGiangDay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

