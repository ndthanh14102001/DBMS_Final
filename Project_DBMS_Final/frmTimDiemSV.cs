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
    public partial class frmTimDiemSV : Form
    {
        static String connString = @"Data Source=LAPTOP-BSGMGP3K\NHATHUY;Initial Catalog=QLDSV;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);
        public frmTimDiemSV()
        {
            InitializeComponent();
        }

        private void frmTimDiemSV_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KETQUA ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgw_TCD.DataSource = dt;


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
