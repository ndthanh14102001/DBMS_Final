﻿namespace Project_DBMS_Final
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TCD = new System.Windows.Forms.Label();
            this.dgw_TCD = new System.Windows.Forms.DataGridView();
            this.btn_BatdauLoc = new System.Windows.Forms.Button();
            this.gB_TTCT = new System.Windows.Forms.GroupBox();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.lbl_MaSv = new System.Windows.Forms.Label();
            this.gB_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbb_xeploai = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).BeginInit();
            this.gB_TTCT.SuspendLayout();
            this.gB_TimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TCD
            // 
            this.lbl_TCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TCD.AutoSize = true;
            this.lbl_TCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TCD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TCD.Location = new System.Drawing.Point(479, 17);
            this.lbl_TCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TCD.Name = "lbl_TCD";
            this.lbl_TCD.Size = new System.Drawing.Size(178, 32);
            this.lbl_TCD.TabIndex = 32;
            this.lbl_TCD.Text = "THỐNG KÊ ";
            this.lbl_TCD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgw_TCD
            // 
            this.dgw_TCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MASV,
            this.HOTEN,
            this.NGAYSINH,
            this.GIOITINH,
            this.DIACHI,
            this.MALOP,
            this.TINHTRANG});
            this.dgw_TCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_TCD.Location = new System.Drawing.Point(4, 28);
            this.dgw_TCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_TCD.Name = "dgw_TCD";
            this.dgw_TCD.RowHeadersWidth = 62;
            this.dgw_TCD.Size = new System.Drawing.Size(1261, 556);
            this.dgw_TCD.TabIndex = 0;
            // 
            // btn_BatdauLoc
            // 
            this.btn_BatdauLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatdauLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BatdauLoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_BatdauLoc.Location = new System.Drawing.Point(1016, 51);
            this.btn_BatdauLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BatdauLoc.Name = "btn_BatdauLoc";
            this.btn_BatdauLoc.Size = new System.Drawing.Size(183, 42);
            this.btn_BatdauLoc.TabIndex = 31;
            this.btn_BatdauLoc.Text = "Bắt Đầu Lọc";
            this.btn_BatdauLoc.UseVisualStyleBackColor = true;
            this.btn_BatdauLoc.Click += new System.EventHandler(this.btn_BatdauLoc_Click);
            // 
            // gB_TTCT
            // 
            this.gB_TTCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_TTCT.Controls.Add(this.dgw_TCD);
            this.gB_TTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTCT.Location = new System.Drawing.Point(8, 224);
            this.gB_TTCT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_TTCT.Name = "gB_TTCT";
            this.gB_TTCT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_TTCT.Size = new System.Drawing.Size(1269, 589);
            this.gB_TTCT.TabIndex = 33;
            this.gB_TTCT.TabStop = false;
            this.gB_TTCT.Text = "Thông tin chi tiết";
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(569, 55);
            this.cboMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(278, 30);
            this.cboMaMH.TabIndex = 3;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MonHoc.Location = new System.Drawing.Point(461, 63);
            this.lbl_MonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(79, 22);
            this.lbl_MonHoc.TabIndex = 3;
            this.lbl_MonHoc.Text = "Môn học";
            // 
            // lbl_MaSv
            // 
            this.lbl_MaSv.AutoSize = true;
            this.lbl_MaSv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaSv.Location = new System.Drawing.Point(85, 65);
            this.lbl_MaSv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSv.Name = "lbl_MaSv";
            this.lbl_MaSv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MaSv.Size = new System.Drawing.Size(89, 22);
            this.lbl_MaSv.TabIndex = 0;
            this.lbl_MaSv.Text = "Xếp Loại ";
            // 
            // gB_TimKiem
            // 
            this.gB_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_TimKiem.Controls.Add(this.cbb_xeploai);
            this.gB_TimKiem.Controls.Add(this.btn_BatdauLoc);
            this.gB_TimKiem.Controls.Add(this.cboMaMH);
            this.gB_TimKiem.Controls.Add(this.lbl_MonHoc);
            this.gB_TimKiem.Controls.Add(this.lbl_MaSv);
            this.gB_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TimKiem.Location = new System.Drawing.Point(8, 79);
            this.gB_TimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_TimKiem.Name = "gB_TimKiem";
            this.gB_TimKiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gB_TimKiem.Size = new System.Drawing.Size(1264, 135);
            this.gB_TimKiem.TabIndex = 34;
            this.gB_TimKiem.TabStop = false;
            this.gB_TimKiem.Text = "Thống kê theo học lực";
            // 
            // cbb_xeploai
            // 
            this.cbb_xeploai.FormattingEnabled = true;
            this.cbb_xeploai.Items.AddRange(new object[] {
            "Trung Bình ",
            "Khá",
            "Giỏi",
            "Xuất Sắc"});
            this.cbb_xeploai.Location = new System.Drawing.Point(221, 55);
            this.cbb_xeploai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_xeploai.Name = "cbb_xeploai";
            this.cbb_xeploai.Size = new System.Drawing.Size(205, 30);
            this.cbb_xeploai.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "stt";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 150;
            // 
            // MASV
            // 
            this.MASV.HeaderText = "Mã sinh viên";
            this.MASV.MinimumWidth = 8;
            this.MASV.Name = "MASV";
            this.MASV.Width = 150;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 8;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 150;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 8;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 150;
            // 
            // GIOITINH
            // 
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 8;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 150;
            // 
            // DIACHI
            // 
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 8;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 150;
            // 
            // MALOP
            // 
            this.MALOP.HeaderText = "Mã lớp";
            this.MALOP.MinimumWidth = 8;
            this.MALOP.Name = "MALOP";
            this.MALOP.Width = 150;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.MinimumWidth = 8;
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.Width = 150;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 831);
            this.Controls.Add(this.lbl_TCD);
            this.Controls.Add(this.gB_TTCT);
            this.Controls.Add(this.gB_TimKiem);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).EndInit();
            this.gB_TTCT.ResumeLayout(false);
            this.gB_TimKiem.ResumeLayout(false);
            this.gB_TimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TCD;
        private System.Windows.Forms.DataGridView dgw_TCD;
        private System.Windows.Forms.Button btn_BatdauLoc;
        private System.Windows.Forms.GroupBox gB_TTCT;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.Label lbl_MaSv;
        private System.Windows.Forms.GroupBox gB_TimKiem;
        private System.Windows.Forms.ComboBox cbb_xeploai;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
    }
}