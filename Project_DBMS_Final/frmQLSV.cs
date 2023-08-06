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

namespace Project_DBMS_Final
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "SELECT * FROM SINHVIEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTSV.DataSource = dtable;
            dgw_TTSV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgw_TTSV.Refresh();
        }

        private void TimKiemSV()
        {
            ConnectDB connectDB = new ConnectDB();
            SqlConnection conn = connectDB.getConnect();
            string query = "SELECT * FROM SINHVIEN WHERE MALOP = '" + cbo_LopHoc.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgw_TTSV.DataSource = dtable;
            dgw_TTSV.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgw_TTSV.Refresh();
        }

        private void cbo_LopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemSV();
        }
    }
}
