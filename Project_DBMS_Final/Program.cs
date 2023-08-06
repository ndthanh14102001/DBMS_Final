using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ConnectDB connectDB = new ConnectDB();
            //SqlConnection conn = connectDB.getConnect();
            //string querry = "Select * from GIANGVIEN";

            //SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            //DataTable dtable = new DataTable();
            //sda.Fill(dtable);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
