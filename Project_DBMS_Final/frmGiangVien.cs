﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS_Final
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void bt_XemChiTiet_Click(object sender, EventArgs e)
        {
            frmGiangVienDayMH formGVDMH = new frmGiangVienDayMH();
            formGVDMH.Show();
        }
    }
}