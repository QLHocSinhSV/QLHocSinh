using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Hoc_Sinh.Class;
using System.Data.SqlClient;

namespace Quan_Ly_Hoc_Sinh
{
    public partial class FormDanhSachLop : Form
    {
        public FormDanhSachLop()
        {
            InitializeComponent();
        }
        private void FormDanhSachLop_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            conn.Open();
            cm.Connection = conn;
            cm.CommandText = "select * from lop";
            da.SelectCommand = cm;
            da.Fill(dt);
            cmbLop.DataSource = dt;
            cmbLop.DisplayMember = "mahienthi";
            cmbLop.ValueMember = "malop";
            //cmbLop.SelectedValue = "malop";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FormLop fr = new FormLop();
                fr.malop = int.Parse(cmbLop.SelectedValue.ToString());
                fr.Show();
                Hide();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain fr = new FormMain();
            fr.Show();
            Hide();
        }
    }
}
