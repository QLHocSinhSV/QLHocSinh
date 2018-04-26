using Quan_Ly_Hoc_Sinh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Hoc_Sinh
{
    public partial class FormGiaoVien : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblGIAOVIEN");
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
            command.CommandText = "sp_TIMKIEMGIAOVIEN";

            command.Parameters.Add(new SqlParameter("@mahienthi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@ten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@lop", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvgiaovien.DataSource = dt;
            //SqlCommand command = new SqlCommand();
            //command.Connection = conn;
            //command.CommandText = "select gv.MaGV as[Mã giáo viên] , gv.MaHienThi as[Mã hiển thị] , gv.HoTen as[Họ tên] , gv.NgaySinh as[Ngày sinh], (case gv.GioiTinh when 'True' then N'Nam' else N'Nữ' end) as [Giới tính] ,gv.DiaChi as[Địa chỉ] ,gv.DienThoai as[Điện thoại],gv.CMND as[CMND],gv.TrinhDo as[Trình độ] ,gv.ChuyenMon as[Chuyên môn],gv.ChucVu as[Chức vụ] ,mh.Ten as[Môn học] ,l.MaHienThi as [Lớp] from GIAOVIEN gv join MONHOC mh on gv.MaMH = mh.MaMH join LOP l on l.MaLop = gv.LopQuanLy";
            //da.SelectCommand = command;
            //da.Fill(dt);
            //dgvgiaovien.DataSource = dt;

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
            cl.DataPropertyName = "CMND";
            cl.HeaderText = "Số CMND";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TrinhDo";
            cl.HeaderText = "Trình độ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ChuyenMon";
            cl.HeaderText = "Chuyên môn";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "ChucVu";
            cl.HeaderText = "Chức vụ";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MonHoc";
            cl.HeaderText = "Môn học giảng dạy";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "LopQuanLy";
            cl.HeaderText = "Lớp quản lý";
            dgv.Columns.Add(cl);
        }
        private bool isEmpty()
        {
            if(txtMaHT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (!rdbnam.Checked && !rdbnu.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtCMND.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số CMND", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtTrinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập trình độ học vấn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtChucvu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chức vụ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (txtChuyenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chuyên môn", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cbbMaMonHoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn môn học giảng dạy", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public FormGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            getdata2();
            btnLuuThemMoi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;
            txtChucvu.Enabled = true;
            txtChuyenmon.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtHoten.Enabled = true;
            txtMaHT.Enabled = true;
            txtTrinhdo.Enabled = true;
            rdbnam.Enabled = true;
            rdbnu.Enabled = true;
            cbbLopQuanLy.Enabled = true;
            cbbMaMonHoc.Enabled = true;
            dtpngaysinh.Enabled = true;
            dgvgiaovien.Enabled = false;
            txtChucvu.Clear();
            txtChuyenmon.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtDienthoai.Clear();
            txtHoten.Clear();
            txtMaGV.Clear();
            txtMaHT.Clear();
            txtTrinhdo.Clear();
        }

        private void btnLuuThemMoi_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            connect();
            Giaovien gv = new Giaovien();
            try
            {
                if (dtpngaysinh.Value < DateTime.Today)
                {

                    gv.ngaysinhGV = dtpngaysinh.Value;
                    gv.maHT = txtMaHT.Text;
                    gv.hotenGV = txtHoten.Text;

                    if (rdbnam.Checked == true)
                    {
                        gv.gioitinhGV = true;
                    }
                    else if (rdbnu.Checked == true)
                    {
                        gv.gioitinhGV = false;
                    }
                    gv.chucvuGV = txtChucvu.Text;
                    gv.chuyenmonGV = txtChuyenmon.Text;
                    gv.diachiGV = txtDiaChi.Text;
                    gv.dienthoaiGV = txtDienthoai.Text;
                    gv.maMH = int.Parse(cbbMaMonHoc.SelectedValue.ToString());
                    if (cbbLopQuanLy.Text == "")
                        gv.LopQuanLy = -1;
                    else
                        gv.LopQuanLy = int.Parse(cbbLopQuanLy.SelectedValue.ToString());
                    
                    gv.soCMNDGV = txtCMND.Text;
                    gv.trinhdoGV = txtTrinhdo.Text;



                    //GiaoVienBus bus = new GiaoVienBus();
                    //int ret;
                    //ret = bus.insert(gv);
                    //bus.close();
                    //if (ret < 0)
                    //{
                    //    MessageBox.Show("Không ghi được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}
                    SqlCommand proc = new SqlCommand("sp_THEMGIAOVIEN",conn);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.Add("@MaHienThi", SqlDbType.VarChar).Value = gv.maHT == "" ? DBNull.Value : (object)gv.maHT;
                    proc.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = gv.hotenGV == "" ? DBNull.Value : (object)gv.hotenGV;
                    proc.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = gv.ngaysinhGV;
                    proc.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gv.gioitinhGV;
                    proc.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = gv.diachiGV == "" ? DBNull.Value : (object)gv.diachiGV;
                    proc.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = gv.dienthoaiGV == "" ? DBNull.Value : (object)gv.dienthoaiGV;
                    proc.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = gv.soCMNDGV == "" ? DBNull.Value : (object)gv.soCMNDGV;
                    proc.Parameters.Add("@trinhdo", SqlDbType.NVarChar).Value = gv.trinhdoGV == "" ? DBNull.Value : (object)gv.trinhdoGV;
                    proc.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = gv.chuyenmonGV == "" ? DBNull.Value : (object)gv.chuyenmonGV;
                    proc.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = gv.chucvuGV == "" ? DBNull.Value : (object)gv.chucvuGV;
                    proc.Parameters.Add("@maMH", SqlDbType.Int).Value = gv.maMH;
                    if (gv.LopQuanLy == -1) proc.Parameters.Add("@malop", SqlDbType.Int).Value = DBNull.Value;
                    else proc.Parameters.Add("@malop", SqlDbType.Int).Value = gv.LopQuanLy;
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Ghi thành công");
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnLuuThemMoi.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            txtChucvu.Enabled = false;
            txtChuyenmon.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtMaHT.Enabled = false;
            txtTrinhdo.Enabled = false;
            rdbnam.Enabled = false;
            rdbnu.Enabled = false;
            cbbLopQuanLy.Enabled = false;
            cbbMaMonHoc.Enabled = false;
            dtpngaysinh.Enabled = false;
            dgvgiaovien.Enabled = true;
            dt.Clear();
            getdata();
            disconect();
        }
        private void getdata2()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from MONHOC";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbMaMonHoc.DataSource = data;
            cbbMaMonHoc.DisplayMember = "Ten";
            cbbMaMonHoc.ValueMember = "MaMH";

            cm.CommandText = "select * from LOP";
            da.SelectCommand = cm;
            da.Fill(data1);
            cbbLopQuanLy.DataSource = data1;
            cbbLopQuanLy.DisplayMember = "MaHienThi";
            cbbLopQuanLy.ValueMember = "MaLop";
            
        }

        private void dgvgiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gt = this.dgvgiaovien.CurrentRow.Cells[3].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rdbnam.Checked = true;

            }
            else if (gt == "Nữ")
            {
                rdbnu.Checked = true;
            }
            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("Text", dgvgiaovien.DataSource, "ChucVu");
            txtChuyenmon.DataBindings.Clear();
            txtChuyenmon.DataBindings.Add("Text", dgvgiaovien.DataSource, "ChuyenMon");
            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", dgvgiaovien.DataSource, "CMND");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvgiaovien.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvgiaovien.DataSource, "DienThoai");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvgiaovien.DataSource, "HoTen");
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", dgvgiaovien.DataSource, "MaGV");
            txtMaHT.DataBindings.Clear();
            txtMaHT.DataBindings.Add("Text", dgvgiaovien.DataSource, "MaHienThi");
            txtTrinhdo.DataBindings.Clear();
            txtTrinhdo.DataBindings.Add("Text", dgvgiaovien.DataSource, "TrinhDo");
            cbbLopQuanLy.DataBindings.Clear();
            cbbLopQuanLy.DataBindings.Add("Text", dgvgiaovien.DataSource, "LopQuanLy");
            cbbMaMonHoc.DataBindings.Clear();
            cbbMaMonHoc.DataBindings.Add("Text", dgvgiaovien.DataSource, "MonHoc");
            dtpngaysinh.DataBindings.Clear();
            dtpngaysinh.DataBindings.Add("Text",dgvgiaovien.DataSource,"NgaySinh");
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dgvgiaovien);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            txtChucvu.Enabled = true;
            txtChuyenmon.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienthoai.Enabled = true;
            txtHoten.Enabled = true;
            txtMaHT.Enabled = true;
            txtTrinhdo.Enabled = true;
            rdbnam.Enabled = true;
            rdbnu.Enabled = true;
            cbbLopQuanLy.Enabled = true;
            cbbMaMonHoc.Enabled = true;
            dtpngaysinh.Enabled = true;
            dgvgiaovien.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isEmpty()) return;
            connect();
            Giaovien gv = new Giaovien();
            try
            {
                if (dtpngaysinh.Value < DateTime.Today)
                {
                    gv.maGV = int.Parse(txtMaGV.Text);
                    gv.ngaysinhGV = dtpngaysinh.Value;
                    gv.maHT = txtMaHT.Text;
                    gv.hotenGV = txtHoten.Text;

                    if (rdbnam.Checked == true)
                    {
                        gv.gioitinhGV = true;
                    }
                    else if (rdbnu.Checked == true)
                    {
                        gv.gioitinhGV = false;
                    }
                    gv.chucvuGV = txtChucvu.Text;
                    gv.chuyenmonGV = txtChuyenmon.Text;
                    gv.diachiGV = txtDiaChi.Text;
                    gv.dienthoaiGV = txtDienthoai.Text;
                    gv.maMH = int.Parse(cbbMaMonHoc.SelectedValue.ToString());
                    if (cbbLopQuanLy.Text == "")
                        gv.LopQuanLy = -1;
                    else
                        gv.LopQuanLy = int.Parse(cbbLopQuanLy.SelectedValue.ToString());
                    gv.soCMNDGV = txtCMND.Text;
                    gv.trinhdoGV = txtTrinhdo.Text;

                    SqlCommand proc = new SqlCommand("sp_SUAGIAOVIEN", conn);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.Add("@Ma", SqlDbType.Int).Value = gv.maGV;
                    proc.Parameters.Add("@MaHienThi", SqlDbType.VarChar).Value = gv.maHT == "" ? DBNull.Value : (object)gv.maHT;
                    proc.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = gv.hotenGV == "" ? DBNull.Value : (object)gv.hotenGV;
                    proc.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = gv.ngaysinhGV;
                    proc.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = gv.gioitinhGV;
                    proc.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = gv.diachiGV == "" ? DBNull.Value : (object)gv.diachiGV;
                    proc.Parameters.Add("@dienthoai", SqlDbType.VarChar).Value = gv.dienthoaiGV == "" ? DBNull.Value : (object)gv.dienthoaiGV;
                    proc.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = gv.soCMNDGV == "" ? DBNull.Value : (object)gv.soCMNDGV;
                    proc.Parameters.Add("@trinhdo", SqlDbType.NVarChar).Value = gv.trinhdoGV == "" ? DBNull.Value : (object)gv.trinhdoGV;
                    proc.Parameters.Add("@chuyenmon", SqlDbType.NVarChar).Value = gv.chuyenmonGV == "" ? DBNull.Value : (object)gv.chuyenmonGV;
                    proc.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = gv.chucvuGV == "" ? DBNull.Value : (object)gv.chucvuGV;
                    proc.Parameters.Add("@maMH", SqlDbType.Int).Value = gv.maMH;
                    if (gv.LopQuanLy == -1) proc.Parameters.Add("@malop", SqlDbType.Int).Value = DBNull.Value;
                    else proc.Parameters.Add("@malop", SqlDbType.Int).Value = gv.LopQuanLy;
                    proc.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");

                    //GiaoVienBus bus = new GiaoVienBus();
                    //int ret;
                    //ret = bus.update(gv);
                    //bus.close();
                    //if (ret < 0)
                    //{
                    //    MessageBox.Show("Không ghi được dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    btnLuuThemMoi.Enabled = false;
                    //    btnCapNhat.Enabled = true;
                    //    btnSua.Enabled = true;
                    //    btnXoa.Enabled = true;
                    //    txtChucvu.Enabled = false;
                    //    txtChuyenmon.Enabled = false;
                    //    txtCMND.Enabled = false;
                    //    txtDiaChi.Enabled = false;
                    //    txtDienthoai.Enabled = false;
                    //    txtHoten.Enabled = false;
                    //    txtMaHT.Enabled = false;
                    //    txtTrinhdo.Enabled = false;
                    //    rdbnam.Enabled = false;
                    //    rdbnu.Enabled = false;
                    //    cbbLopQuanLy.Enabled = false;
                    //    cbbMaMonHoc.Enabled = false;
                    //    dtpngaysinh.Enabled = false;
                    //}

                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            txtChucvu.Enabled = false;
            txtChuyenmon.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtMaHT.Enabled = false;
            txtTrinhdo.Enabled = false;
            rdbnam.Enabled = false;
            rdbnu.Enabled = false;
            cbbLopQuanLy.Enabled = false;
            cbbMaMonHoc.Enabled = false;
            dtpngaysinh.Enabled = false;
            dgvgiaovien.Enabled = true;
            dt.Clear();
            getdata();
            disconect();
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!","Thông báo!!!");
                return;
            }
            if (MessageBox.Show( "Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect();
                try
                {
                    
                    SqlCommand command = new SqlCommand("sp_XOAGIAOVIEN", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Ma", txtMaGV.Text));
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuuThemMoi.Enabled = false;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            txtChucvu.Enabled = false;
            txtChuyenmon.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtMaHT.Enabled = false;
            txtTrinhdo.Enabled = false;
            rdbnam.Enabled = false;
            rdbnu.Enabled = false;
            cbbLopQuanLy.Enabled = false;
            cbbMaMonHoc.Enabled = false;
            dtpngaysinh.Enabled = false;
            dgvgiaovien.Enabled = true;
            dt.Clear();
            connect();
            getdata();
            disconect();
        }

        private void FormGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
