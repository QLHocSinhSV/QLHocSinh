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
    public partial class FormHocSinh : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblHOCSINH");
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
        public void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TIMKIEMHOCSINH";
            command.Parameters.Add(new SqlParameter("@mahienthi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@ten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@lop", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvHocSinh.DataSource = dt;
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaHienThi";
            cl.HeaderText = "Mã";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTen";
            cl.HeaderText = "Tên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgaySinh";
            cl.HeaderText = "Ngày sinh";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gioitinh";
            cl.HeaderText = "Giới tính";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DiaChi";
            cl.HeaderText = "Địa chỉ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DienThoai";
            cl.HeaderText = "Điện thoại";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "QueQuan";
            cl.HeaderText = "Quê quán";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DanToc";
            cl.HeaderText = "Dân tộc";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Lop";
            cl.HeaderText = "Lớp";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTenCha";
            cl.HeaderText = "Cha";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgheNghiepCha";
            cl.HeaderText = "Nghề Nghiệp";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DienThoaiCha";
            cl.HeaderText = "Điện thoại";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTenMe";
            cl.HeaderText = "Mẹ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgheNghiepMe";
            cl.HeaderText = "Nghề Nghiệp";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "DienThoaiMe";
            cl.HeaderText = "Điện thoại";
            dgv.Columns.Add(cl);
        }
        public FormHocSinh()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {

           
            txtMHS.Clear();
            txtDantoc.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtHoten.Clear();
            txtMaHienThi.Clear();
            txtQuequan.Clear();
            txtHotencha.Clear();
            txtHotenMe.Clear();
            txtNgheNghiepCha.Clear();
            txtNgheNghiepMe.Clear();
            txtDienthoaiCha.Clear();
            txtDienthoaiMe.Clear();

            getdata2();
            btnLuuThemMoi.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            txtDantoc.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtHoten.Enabled = true;
            txtMaHienThi.Enabled = true;
            txtQuequan.Enabled = true;
            dtpNgaysinh.Enabled = true;
            txtHotencha.Enabled = true;
            txtHotenMe.Enabled = true;
            txtNgheNghiepCha.Enabled = true;
            txtNgheNghiepMe.Enabled = true;
            txtDienthoaiCha.Enabled = true;
            txtDienthoaiMe.Enabled = true;
            rbNam.Enabled = true; rbNu.Enabled = true;
            cbbLop.Enabled = true;
            dgvHocSinh.Enabled = false;
        }
        private void getdata2()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from LOP";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbLop.DataSource = data;
            cbbLop.DisplayMember = "MaHienThi";
            cbbLop.ValueMember = "MaLop";
        }

        private bool isEmpty()
        {
            if(txtMaHienThi.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (!rbNam.Checked && !rbNu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtQuequan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtDantoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dân tộc", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbbLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn lớp", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            connect();
           HocSinh_Obj hs = new HocSinh_Obj();
            try
            {
                if (dtpNgaysinh.Value < DateTime.Today)
                {
                   
                    hs.NgaySinh = dtpNgaysinh.Value;
                    hs.MaHienThi = txtMaHienThi.Text;
                    hs.HoTen = txtHoten.Text;

                    if (rbNam.Checked == true)
                    {
                        hs.GioiTinh = true;
                    }
                    else if (rbNu.Checked == true)
                    {
                        hs.GioiTinh = false;
                    }
                    hs.QueQuan = txtQuequan.Text;
                    hs.DiaChi = txtDiachi.Text;
                    hs.DanToc = txtDantoc.Text;
                    hs.DienThoai = txtDienthoai.Text;
                    hs.Lop = cbbLop.SelectedValue.ToString();
                    hs.HotenCha = txtHotencha.Text;
                    hs.NgheNghiepCha = txtNgheNghiepCha.Text;
                    hs.DienthoaiCha = txtDienthoaiCha.Text;
                    hs.HotenMe = txtHotenMe.Text;
                    hs.NgheNghiepMe = txtNgheNghiepMe.Text;
                    hs.DienthoaiMe = txtDienthoaiMe.Text;
                    


                    HocSinhBus bus = new HocSinhBus();
                    int ret;
                    ret = bus.insert(hs);
                    bus.close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Không ghi được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLuuThemMoi.Enabled = false;
                        btnThem.Enabled = true;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        btnHuy.Enabled = false;
                        txtDantoc.Enabled = false;
                        txtDiachi.Enabled = false;
                        txtDienthoai.Enabled = false;
                        txtHoten.Enabled = false;
                        txtMaHienThi.Enabled = false;
                        txtQuequan.Enabled = false;
                        dtpNgaysinh.Enabled = false;
                        txtHotencha.Enabled = false;
                        txtHotenMe.Enabled = false;
                        txtNgheNghiepCha.Enabled = false;
                        txtNgheNghiepMe.Enabled = false;
                        txtDienthoaiCha.Enabled = false;
                        txtDienthoaiMe.Enabled = false;
                        rbNam.Enabled = false; rbNu.Enabled = false;
                        cbbLop.Enabled = false;
                        dgvHocSinh.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //btnLuuThemMoi.Enabled = false;
            //txtDantoc.Enabled = false;
            //txtDiachi.Enabled = false;
            //txtDienthoai.Enabled = false;
            //txtHoten.Enabled = false;
            //txtMaHienThi.Enabled = false;
            //txtQuequan.Enabled = false;
            //dtpNgaysinh.Enabled = false;
            //txtHotencha.Enabled = false;
            //txtHotenMe.Enabled = false;
            //txtNgheNghiepCha.Enabled = false;
            //txtNgheNghiepMe.Enabled = false;
            //txtDienthoaiCha.Enabled = false;
            //txtDienthoaiMe.Enabled = false;
            //rbNam.Enabled = false; rbNu.Enabled = false;
            //cbbLop.Enabled = false;
            dt.Clear();
            getdata();
            disconect();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                connect();
                try
                {
                    SqlCommand command = new SqlCommand("sp_XOAHOCSINH", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", txtMHS.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                getdata();
                disconect();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                connect();
                getdata();
                disconect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMHS.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            btnCapNhat.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            txtDantoc.Enabled = true;
            txtDiachi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtHoten.Enabled = true;
            txtMaHienThi.Enabled = true;
            txtQuequan.Enabled = true;
            dtpNgaysinh.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            cbbLop.Enabled = true;
            txtHotencha.Enabled = true;
            txtHotenMe.Enabled = true;
            txtNgheNghiepCha.Enabled = true;
            txtNgheNghiepMe.Enabled = true;
            txtDienthoaiCha.Enabled = true;
            txtDienthoaiMe.Enabled = true;
            dgvHocSinh.Enabled = false;
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = this.dgvHocSinh.CurrentRow.Cells[3].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rbNam.Checked = true;

            }
            else if (gt == "Nữ")
            {
                rbNu.Checked = true;
            }
            txtMHS.DataBindings.Clear();
            txtMHS.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaHS");
            txtMaHienThi.DataBindings.Clear();
            txtMaHienThi.DataBindings.Add("Text", dgvHocSinh.DataSource, "MaHienThi");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvHocSinh.DataSource, "Hoten");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgaySinh");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvHocSinh.DataSource, "DiaChi");
            txtQuequan.DataBindings.Clear();
            txtQuequan.DataBindings.Add("Text", dgvHocSinh.DataSource, "QueQuan");
            txtDantoc.DataBindings.Clear();
            txtDantoc.DataBindings.Add("Text", dgvHocSinh.DataSource, "DanToc");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvHocSinh.DataSource, "DienThoai");
            cbbLop.DataBindings.Clear();
            cbbLop.DataBindings.Add("Text", dgvHocSinh.DataSource, "Lop");
            txtHotencha.DataBindings.Clear();
            txtHotencha.DataBindings.Add("Text", dgvHocSinh.DataSource, "HoTenCha");
            txtNgheNghiepCha.DataBindings.Clear();
            txtNgheNghiepCha.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgheNghiepCha");
            txtDienthoaiCha.DataBindings.Clear();
            txtDienthoaiCha.DataBindings.Add("Text", dgvHocSinh.DataSource, "DienThoaiCha");
            txtHotenMe.DataBindings.Clear();
            txtHotenMe.DataBindings.Add("Text", dgvHocSinh.DataSource, "HoTenMe");         
            txtNgheNghiepMe.DataBindings.Clear();
            txtNgheNghiepMe.DataBindings.Add("Text", dgvHocSinh.DataSource, "NgheNghiepMe");           
            txtDienthoaiMe.DataBindings.Clear();
            txtDienthoaiMe.DataBindings.Add("Text", dgvHocSinh.DataSource, "DienThoaiMe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            connect();
            //try
            //{
            //    SqlCommand command = new SqlCommand("SP_UPDATE_HOCSINH", conn);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Add(new SqlParameter("@MaHS",txtMHS.Text).ToString(),SqlDbType.BigInt);
            //    command.Parameters.Add(new SqlParameter("@MaHienThi", txtMaHienThi.Text).ToString(),SqlDbType.Int);
            //    command.Parameters.Add(new SqlParameter("@HoTen", txtHoten.Text));
            //    command.Parameters.Add(new SqlParameter("@NgaySinh", dtpNgaysinh.DataBindings));
            //    bool gt = false;
            //    if (rbNam.Checked)
            //    {
            //        gt = true;
            //    }else
            //    {
            //        gt = false;
            //    }
            //    command.Parameters.Add(new SqlParameter("@GioiTinh", gt));
            //    command.Parameters.Add(new SqlParameter("@DiaChi", txtDiachi.Text));
            //    command.Parameters.Add(new SqlParameter("@QueQuan", txtQuequan.Text));
            //    command.Parameters.Add(new SqlParameter("@DanToc", txtDantoc.Text));
            //    command.Parameters.Add(new SqlParameter("@DienThoai", txtDienthoai.Text));
            //    command.Parameters.Add(new SqlParameter("@MaLop", cbbLop.SelectedValue));

            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dt.Clear();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            HocSinh_Obj hs = new HocSinh_Obj();
            try
            {
                if (dtpNgaysinh.Value < DateTime.Today)
                {
                    hs.MaHS = int.Parse(txtMHS.Text);
                    hs.NgaySinh = dtpNgaysinh.Value;
                    hs.MaHienThi = txtMaHienThi.Text;
                    hs.HoTen = txtHoten.Text;

                    if (rbNam.Checked == true)
                    {
                        hs.GioiTinh = true;
                    }
                    else if (rbNu.Checked == true)
                    {
                        hs.GioiTinh = false;
                    }
                    hs.QueQuan = txtQuequan.Text;
                    hs.DiaChi = txtDiachi.Text;
                    hs.DanToc = txtDantoc.Text;
                    hs.DienThoai = txtDienthoai.Text;
                    hs.Lop = cbbLop.SelectedValue.ToString();
                    hs.HotenCha = txtHotencha.Text;
                    hs.NgheNghiepCha = txtNgheNghiepCha.Text;
                    hs.DienthoaiCha = txtDienthoaiCha.Text;
                    hs.HotenMe = txtHotenMe.Text;
                    hs.NgheNghiepMe = txtNgheNghiepMe.Text;
                    hs.DienthoaiMe = txtDienthoaiMe.Text;


                    HocSinhBus bus = new HocSinhBus();
                    int ret;
                    ret = bus.update(hs);
                    bus.close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Không cập nhật được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnCapNhat.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            txtDantoc.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtMaHienThi.Enabled = false;
            txtQuequan.Enabled = false;
            dtpNgaysinh.Enabled = false;
            txtHotencha.Enabled = false;
            txtHotenMe.Enabled = false;
            txtNgheNghiepCha.Enabled = false;
            txtNgheNghiepMe.Enabled = false;
            txtDienthoaiCha.Enabled = false;
            txtDienthoaiMe.Enabled = false;
            rbNam.Enabled = false; rbNu.Enabled = false;
            cbbLop.Enabled = false;
            dgvHocSinh.Enabled = true;
            dt.Clear();
            getdata();
            disconect();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dgvHocSinh);
            getdata();
            getdata2();
            disconect();
            if (FormLogin.quyen != true)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain fr = new FormMain();
            fr.Show();
            Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuuThemMoi.Enabled = false;
            btnCapNhat.Enabled = false;
            btnHuy.Enabled = false;
            txtDantoc.Enabled = false;
            txtDiachi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtMaHienThi.Enabled = false;
            txtQuequan.Enabled = false;
            dtpNgaysinh.Enabled = false;
            txtHotencha.Enabled = false;
            txtHotenMe.Enabled = false;
            txtNgheNghiepCha.Enabled = false;
            txtNgheNghiepMe.Enabled = false;
            txtDienthoaiCha.Enabled = false;
            txtDienthoaiMe.Enabled = false;
            rbNam.Enabled = false; rbNu.Enabled = false;
            cbbLop.Enabled = false;
            dgvHocSinh.Enabled = true;
            dt.Clear();
            connect();
            getdata();
            disconect();
        }

        private void FormHocSinh_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormHocSinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
