using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmMonhoc : Form
    {
        private CommonConnect cc = new CommonConnect();
        SqlConnection conn = null;

        public frmMonhoc()
        {
            InitializeComponent();
        }

        private void dgw_MonHoc_Load()
        {
            dgw_MonHoc.DataSource = DataProvider.Instance.ExecuteQuery(" exec dbo.USP_Query_monhoc");
            dgw_MonHoc.ReadOnly = true;
            dgw_MonHoc.AllowUserToDeleteRows = false;
            dgw_MonHoc.AllowUserToAddRows = false;
            dgw_MonHoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgw_MonHoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgw_MonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgw_MonHoc.Rows[e.RowIndex];
            /*
            txb_MaMon.Text = dgw_MonHoc.CurrentRow.Cells[0].Value.ToString();
            txb_TenMon.Text = dgw_MonHoc.CurrentRow.Cells[1].Value.ToString();
            txb_SoTC.Text = dgw_MonHoc.CurrentRow.Cells[2].Value.ToString();
            txb_HocKy.Text = dgw_MonHoc.CurrentRow.Cells[3].Value.ToString();
            */
            txb_MaMon.Text = Convert.ToString(row.Cells["Mã môn học"].Value);
            txb_TenMon.Text = Convert.ToString(row.Cells["Tên môn học"].Value);
            txb_SoTC.Text = Convert.ToString(row.Cells["Số tín chỉ"].Value);
            txb_HocKy.Text = Convert.ToString(row.Cells["Học kỳ"].Value);
        }
        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataTable checkMonnHoc = DataProvider.Instance.ExecuteQuery("exec dbo.Check_Exists_MonHoc @tenmh", new object[] {
                txb_TenMon.Text,
            });
            if (checkMonnHoc.Rows.Count > 0)
            {
                MessageBox.Show("Môn học đã tồn tại"); return;
            }

            /*
            DataTable checkSoTC = DataProvider.Instance.ExecuteQuery("exec dbo.USP_Query_SoTC @tenmh", new object[] { txb_SoTC.Text });
            if (checkSoTC.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập số tín chỉ"); return;
            }
            DataTable checkHocKy = DataProvider.Instance.ExecuteQuery("exec dbo.USP_Query_HocKy @tenmh", new object[] { txb_HocKyText });
            if (checkHocKy.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập học kỳ"); return;
            }
            */

            string mutation = "exec dbo.USP_Mutation_AddMonHoc @mamh, @tenmh, @sotc, @hocky";
            DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
            {
                txb_MaMon.Text,
                txb_TenMon.Text,
                txb_SoTC.Text,
                txb_HocKy.Text
            });
            dgw_MonHoc_Load();
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet2.MONHOC' table. You can move, or remove it, as needed.
            /*
            this.MONHOCTableAdapter.Fill(this.qLDSVDataSet2.MONHOC);
            conn = cc.Connected();
            if (conn.State == ConnectionState.Open) ;


            string select = "Select MAMONHOC from MONHOC ";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Dispose();
            cmd.Dispose();
            */
            dgw_MonHoc_Load();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            /*
            string update = "Update MONHOC Set TENMONHOC =N'" + txb_TenMon.Text + "',SOTINCHI ='" +
                            txb_SoTC.Text + "', HOCKY ='" + txb_HocKy + "' where MAMONHOC ='" + txb_MaMon.Text + "' ";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView_MON();
            cmd.Dispose();
            */
            string mutation = "exec dbo.USP_Mutation_UpdateMonHoc @mamh, @tenmh, @sotc, @hocky";
            int result = DataProvider.Instance.ExecuteNonQuery(mutation, new object[]
            {
                txb_MaMon.Text,
                txb_TenMon.Text,
                txb_SoTC.Text,
                txb_HocKy.Text
            });
            if (result <= 0)
            {
                MessageBox.Show("Sửa thông tin môn học thất bại!"); return;
            }
            dgw_MonHoc_Load();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            string delete = "delete from MONHOC where MAMONHOC ='" + txb_MaMon.Text + "' ";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

            cmd.Dispose();

            dgw_MonHoc_Load();

        }
        
        private void dgw_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgw_MonHoc.Rows[e.RowIndex];
            if (row == null) return;
            string mamh = Convert.ToString(row.Cells[0].Value);
            DataTable dataBook = DataProvider.Instance.ExecuteQuery("exec dbo.USP_Query_MonHoc @mamh", new object[] { mamh });
            if (dataBook.Rows.Count == 0) return;
            txb_MaMon.Text = dataBook.Rows[0]["Mã môn học"].ToString();
            txb_TenMon.Text = dataBook.Rows[0]["Tên môn học"].ToString();
            txb_SoTC.Text = dataBook.Rows[0]["Số tín chỉ"].ToString();
            txb_HocKy.Text = dataBook.Rows[0]["Học kỳ"].ToString();
        }
       
    }
}
