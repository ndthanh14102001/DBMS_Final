using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Project_DBMS_Final
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True");

        private void LayDSMonHoc()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SP_DSMonHoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = conn;
            conn.Open();
            da.Fill(dt);
            cboMaMH.DataSource = dt;
            cboMaMH.DisplayMember = "TENMONHOC";
            cboMaMH.ValueMember = "MAMONHOC";
            cboMaMH.SelectedValue = 0;
            conn.Close();
        }
       
        private void ketnoicsdl()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True";

            //SqlDataReader dr;
            conn.Open();
            string sql = "select * from SINHVIEN";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dgw_TCD.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void LayDSHS()
        {
            dgw_TCD.Rows.Clear();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SP_lAYDSHS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            int STT = 0;
            while (dr.Read())
            {
                STT = STT + 1;
                dgw_TCD.Rows.Add(STT, dr.GetValue(0), dr.GetString(1),dr.GetDateTime(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

            }
            dr.Close();
        }
        private bool KiemTraThongTin()
        {
            if (cbb_xeploai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn học lực của sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_xeploai.Focus();
                return false;
            }
            if (cboMaMH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMH.Focus();
                return false;
            }
           
            return true;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //hiển thị ds môn học
            LayDSMonHoc();
            //hiển thị ds học sinh
            LayDSHS();
        }

        /*private void btn_BatdauLoc_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            string monHoc = cboMaMH.SelectedItem.ToString();
            string xeploai = cbb_xeploai.SelectedItem.ToString();
            string query = "SELECT SINHVIEN.*, COUNT(KETQUA.MASV) AS SoLanThi FROM SINHVIEN INNER JOIN KETQUA ON SINHVIEN.MASV = KETQUA.MASV INNER JOIN MONHOC ON KETQUA.MAMONHOC = MONHOC.MAMONHOC WHERE MONHOC.TENMONHOC = @monHoc AND KETQUA.XEPLOAI = @xeploai GROUP BY SINHVIEN.MASV,  SINHVIEN.HOTEN,  SINHVIEN.NGAYSINH, SINHVIEN.GIOITINH, SINHVIEN.DIACHI,SINHVIEN.TINHTRANG,SINHVIEN.MALOP HAVING COUNT(*) > 0 ";
            SqlCommand command = new SqlCommand(query , conn);
            command.Parameters.AddWithValue("@monHoc", monHoc);
            command.Parameters.AddWithValue("@xeploai", xeploai);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgw_TCD.DataSource = dataTable;
           
        }*/
        private void btn_BatdauLoc_Click(object sender, EventArgs e)
        {
            KiemTraThongTin();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            //try
            //{
                conn.Open();
                for (int i = dgw_TCD.Rows.Count - 1; i >= 0; i--)
                {
                    if (!dgw_TCD.Rows[i].IsNewRow)
                    {
                        dgw_TCD.Rows.RemoveAt(i);
                    }
                }
                string monHoc = cboMaMH.SelectedItem.ToString();
                string xepLoai = cbb_xeploai.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand("SP_DSSV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMonHoc = new SqlParameter("@monHoc", SqlDbType.NVarChar, 50);
                paramMonHoc.Value = monHoc;
                cmd.Parameters.Add(paramMonHoc);

                SqlParameter paramXepLoai = new SqlParameter("@xepLoai", SqlDbType.NVarChar, 50);
                paramXepLoai.Value = xepLoai;
                cmd.Parameters.Add(paramXepLoai);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                dgw_TCD.DataSource = dt;

                //SqlDataReader reader = cmd.ExecuteReader();
                //SqlDataReader dr;
                //dr = cmd.ExecuteReader();
                //int STT = 0;
               // while (dr.Read())
                //{
                //    STT = STT + 1;
                //    dgw_TCD.Rows.Add(STT, dr.GetValue(0), dr.GetString(1), dr.GetDateTime(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6));

                //}
                //dr.Close();
            conn.Close();

        }

            //catch (Exception ex)
            //{
            //MessageBox.Show("Error: " + ex.Message);
            //}
            // finally
            // {
            //conn.Close();
            //}
      //  }
    }
   
}
