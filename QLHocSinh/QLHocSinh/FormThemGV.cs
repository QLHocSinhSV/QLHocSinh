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
    public partial class FormThemGV : Form
    {
        public FormThemGV()
        {
            InitializeComponent();
        }
        Giaovien gv;
        private void btLuu_Click(object sender, EventArgs e)
        {
            gv = new Giaovien();
            try
            {
                if (datetimeNgaySinh.Value < DateTime.Today)
                {
                    gv.ngaysinhGV = datetimeNgaySinh.Value;
                    //gv.maGV = int.Parse(txtMaGV.Text);
                    gv.hotenGV = txtHoten.Text;
                    gv.maHT = txtMaHT.Text;

                    if (rdbNam.Checked == true)
                    {
                        gv.gioitinhGV = true;
                    }
                    else if (rdbNu.Checked == true)
                    {
                        gv.gioitinhGV = false;
                    }
                    gv.chucvuGV = txtChucvu.Text;
                    gv.diachiGV = txtDiachi.Text;
                    gv.trinhdoGV = txtTrinhdo.Text;
                    gv.dienthoaiGV = txtDienthoai.Text;
                    gv.soCMNDGV = txtCMND.Text;
                    gv.chuyenmonGV = txtChuyenmon.Text;
                    gv.maMH = int.Parse(txtMaMH.Text);


                   GiaoVienBus bus = new GiaoVienBus();
                    int ret;
                    ret = bus.insert(gv);
                    bus.close();
                    if (ret < 0)
                    {
                        MessageBox.Show("Khong ghi duoc du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ghi thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai ngày!!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập đầy đủ dữ liệu!!!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaMH.Clear();
            txtMaGV.Clear();
            txtMaHT.Clear();
            txtChucvu.Clear();
            txtChuyenmon.Clear();
            txtCMND.Clear();
            txtDiachi.Clear();
            txtDienthoai.Clear();
            txtHoten.Clear();
            txtTrinhdo.Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGiaoVien gv = new FormGiaoVien();
            gv.ShowDialog();
        }

        private void FormThemGV_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            String conStr = @"Data Source=DESKTOP-AEM1VKL\SQLEXPRESS;Initial Catalog=QuanLy_GiaoVien_HocSinh_THPT;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable data1 = new DataTable();
            DataTable data = new DataTable();
            cm.Connection = con;

          //  cm.CommandText = "select * from chucvu";
           // da.SelectCommand = cm;
          //  da.Fill(data);
          //  cmbChucVu.DataSource = data;
         //   cmbChucVu.DisplayMember = "ten";
          //  cmbChucVu.ValueMember = "ID";
         //   cmbChucVu.SelectedValue = "ID";

           // cm.CommandText = "select * from PhongBan";
          //  da.SelectCommand = cm;
         //   da.Fill(data1);
          //  cmbTenPhongBan.DataSource = data1;
         //   cmbTenPhongBan.DisplayMember = "ten";
           // cmbTenPhongBan.ValueMember = "ID";
          //  cmbTenPhongBan.SelectedValue = "ID";

        }
    }
}
