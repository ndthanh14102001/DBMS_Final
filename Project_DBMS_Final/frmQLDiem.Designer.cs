﻿namespace Project_DBMS_Final
{
    partial class frmQLDiem
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
            this.lbl_TTD = new System.Windows.Forms.Label();
            this.gB_LuaChon = new System.Windows.Forms.GroupBox();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.cbo_HocKi = new System.Windows.Forms.ComboBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.lbl_HocKi = new System.Windows.Forms.Label();
            this.lbl_Lop = new System.Windows.Forms.Label();
            this.gB_TTChiTiet = new System.Windows.Forms.GroupBox();
            this.txb_XepLoai = new System.Windows.Forms.TextBox();
            this.lbl_HanhKiem = new System.Windows.Forms.Label();
            this.lbl_DiemTK = new System.Windows.Forms.Label();
            this.txt_DiemTK = new System.Windows.Forms.TextBox();
            this.txb_DiemCK = new System.Windows.Forms.TextBox();
            this.lbl_DiemCK = new System.Windows.Forms.Label();
            this.txt_DiemQT = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txb_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_DiemQT = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_MaSV = new System.Windows.Forms.Label();
            this.gB_GhiChu = new System.Windows.Forms.GroupBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.gB_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgw_DiemSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.gB_LuaChon.SuspendLayout();
            this.gB_TTChiTiet.SuspendLayout();
            this.gB_GhiChu.SuspendLayout();
            this.gB_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DiemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TTD
            // 
            this.lbl_TTD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TTD.AutoSize = true;
            this.lbl_TTD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TTD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TTD.Location = new System.Drawing.Point(533, 23);
            this.lbl_TTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TTD.Name = "lbl_TTD";
            this.lbl_TTD.Size = new System.Drawing.Size(347, 26);
            this.lbl_TTD.TabIndex = 0;
            this.lbl_TTD.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            this.lbl_TTD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_LuaChon
            // 
            this.gB_LuaChon.Controls.Add(this.cbo_MonHoc);
            this.gB_LuaChon.Controls.Add(this.cbo_HocKi);
            this.gB_LuaChon.Controls.Add(this.cbo_Lop);
            this.gB_LuaChon.Controls.Add(this.lbl_MonHoc);
            this.gB_LuaChon.Controls.Add(this.lbl_HocKi);
            this.gB_LuaChon.Controls.Add(this.lbl_Lop);
            this.gB_LuaChon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_LuaChon.Location = new System.Drawing.Point(28, 73);
            this.gB_LuaChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_LuaChon.Name = "gB_LuaChon";
            this.gB_LuaChon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_LuaChon.Size = new System.Drawing.Size(473, 176);
            this.gB_LuaChon.TabIndex = 1;
            this.gB_LuaChon.TabStop = false;
            this.gB_LuaChon.Text = "Lựa chọn";
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(91, 133);
            this.cbo_MonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(363, 27);
            this.cbo_MonHoc.TabIndex = 9;
            // 
            // cbo_HocKi
            // 
            this.cbo_HocKi.FormattingEnabled = true;
            this.cbo_HocKi.Location = new System.Drawing.Point(91, 82);
            this.cbo_HocKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_HocKi.Name = "cbo_HocKi";
            this.cbo_HocKi.Size = new System.Drawing.Size(173, 27);
            this.cbo_HocKi.TabIndex = 8;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(91, 38);
            this.cbo_Lop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(363, 27);
            this.cbo_Lop.TabIndex = 7;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MonHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MonHoc.Location = new System.Drawing.Point(8, 143);
            this.lbl_MonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(74, 19);
            this.lbl_MonHoc.TabIndex = 6;
            this.lbl_MonHoc.Text = "Môn học ";
            this.lbl_MonHoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HocKi
            // 
            this.lbl_HocKi.AutoSize = true;
            this.lbl_HocKi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HocKi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HocKi.Location = new System.Drawing.Point(8, 92);
            this.lbl_HocKi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HocKi.Name = "lbl_HocKi";
            this.lbl_HocKi.Size = new System.Drawing.Size(55, 19);
            this.lbl_HocKi.TabIndex = 5;
            this.lbl_HocKi.Text = "Học kì";
            this.lbl_HocKi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Lop
            // 
            this.lbl_Lop.AutoSize = true;
            this.lbl_Lop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Lop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Lop.Location = new System.Drawing.Point(8, 42);
            this.lbl_Lop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lop.Name = "lbl_Lop";
            this.lbl_Lop.Size = new System.Drawing.Size(36, 19);
            this.lbl_Lop.TabIndex = 4;
            this.lbl_Lop.Text = "Lớp";
            this.lbl_Lop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_TTChiTiet
            // 
            this.gB_TTChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_TTChiTiet.Controls.Add(this.txb_XepLoai);
            this.gB_TTChiTiet.Controls.Add(this.lbl_HanhKiem);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemTK);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiemTK);
            this.gB_TTChiTiet.Controls.Add(this.txb_DiemCK);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemCK);
            this.gB_TTChiTiet.Controls.Add(this.txt_DiemQT);
            this.gB_TTChiTiet.Controls.Add(this.txt_HoTen);
            this.gB_TTChiTiet.Controls.Add(this.txb_MaSV);
            this.gB_TTChiTiet.Controls.Add(this.lbl_DiemQT);
            this.gB_TTChiTiet.Controls.Add(this.lbl_HoTen);
            this.gB_TTChiTiet.Controls.Add(this.lbl_MaSV);
            this.gB_TTChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTChiTiet.Location = new System.Drawing.Point(16, 270);
            this.gB_TTChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TTChiTiet.Name = "gB_TTChiTiet";
            this.gB_TTChiTiet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TTChiTiet.Size = new System.Drawing.Size(1371, 143);
            this.gB_TTChiTiet.TabIndex = 7;
            this.gB_TTChiTiet.TabStop = false;
            this.gB_TTChiTiet.Text = "Thông tin chi tiết";
            // 
            // txb_XepLoai
            // 
            this.txb_XepLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_XepLoai.Location = new System.Drawing.Point(987, 33);
            this.txb_XepLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_XepLoai.Name = "txb_XepLoai";
            this.txb_XepLoai.Size = new System.Drawing.Size(273, 26);
            this.txb_XepLoai.TabIndex = 15;
            // 
            // lbl_HanhKiem
            // 
            this.lbl_HanhKiem.AutoSize = true;
            this.lbl_HanhKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HanhKiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HanhKiem.Location = new System.Drawing.Point(867, 42);
            this.lbl_HanhKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HanhKiem.Name = "lbl_HanhKiem";
            this.lbl_HanhKiem.Size = new System.Drawing.Size(67, 19);
            this.lbl_HanhKiem.TabIndex = 14;
            this.lbl_HanhKiem.Text = "Xếp loại";
            this.lbl_HanhKiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_DiemTK
            // 
            this.lbl_DiemTK.AutoSize = true;
            this.lbl_DiemTK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemTK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemTK.Location = new System.Drawing.Point(867, 95);
            this.lbl_DiemTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiemTK.Name = "lbl_DiemTK";
            this.lbl_DiemTK.Size = new System.Drawing.Size(106, 19);
            this.lbl_DiemTK.TabIndex = 13;
            this.lbl_DiemTK.Text = "Điểm tổng kết";
            this.lbl_DiemTK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_DiemTK
            // 
            this.txt_DiemTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DiemTK.Location = new System.Drawing.Point(987, 86);
            this.txt_DiemTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiemTK.Name = "txt_DiemTK";
            this.txt_DiemTK.Size = new System.Drawing.Size(273, 26);
            this.txt_DiemTK.TabIndex = 12;
            // 
            // txb_DiemCK
            // 
            this.txb_DiemCK.Location = new System.Drawing.Point(523, 86);
            this.txb_DiemCK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_DiemCK.Name = "txb_DiemCK";
            this.txb_DiemCK.Size = new System.Drawing.Size(277, 26);
            this.txb_DiemCK.TabIndex = 11;
            // 
            // lbl_DiemCK
            // 
            this.lbl_DiemCK.AutoSize = true;
            this.lbl_DiemCK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemCK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemCK.Location = new System.Drawing.Point(413, 95);
            this.lbl_DiemCK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiemCK.Name = "lbl_DiemCK";
            this.lbl_DiemCK.Size = new System.Drawing.Size(98, 19);
            this.lbl_DiemCK.TabIndex = 10;
            this.lbl_DiemCK.Text = "Điểm cuối kì";
            this.lbl_DiemCK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_DiemQT
            // 
            this.txt_DiemQT.Location = new System.Drawing.Point(129, 86);
            this.txt_DiemQT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiemQT.Name = "txt_DiemQT";
            this.txt_DiemQT.Size = new System.Drawing.Size(252, 26);
            this.txt_DiemQT.TabIndex = 9;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(523, 33);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(277, 26);
            this.txt_HoTen.TabIndex = 8;
            // 
            // txb_MaSV
            // 
            this.txb_MaSV.Location = new System.Drawing.Point(129, 33);
            this.txb_MaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_MaSV.Name = "txb_MaSV";
            this.txb_MaSV.Size = new System.Drawing.Size(252, 26);
            this.txb_MaSV.TabIndex = 7;
            // 
            // lbl_DiemQT
            // 
            this.lbl_DiemQT.AutoSize = true;
            this.lbl_DiemQT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiemQT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_DiemQT.Location = new System.Drawing.Point(8, 95);
            this.lbl_DiemQT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiemQT.Name = "lbl_DiemQT";
            this.lbl_DiemQT.Size = new System.Drawing.Size(110, 19);
            this.lbl_DiemQT.TabIndex = 6;
            this.lbl_DiemQT.Text = "Điểm quá trình";
            this.lbl_DiemQT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_HoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_HoTen.Location = new System.Drawing.Point(413, 43);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(77, 19);
            this.lbl_HoTen.TabIndex = 5;
            this.lbl_HoTen.Text = "Họ và tên ";
            this.lbl_HoTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_MaSV
            // 
            this.lbl_MaSV.AutoSize = true;
            this.lbl_MaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_MaSV.Location = new System.Drawing.Point(8, 42);
            this.lbl_MaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSV.Name = "lbl_MaSV";
            this.lbl_MaSV.Size = new System.Drawing.Size(95, 19);
            this.lbl_MaSV.TabIndex = 4;
            this.lbl_MaSV.Text = "Mã sinh viên";
            this.lbl_MaSV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gB_GhiChu
            // 
            this.gB_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_GhiChu.Controls.Add(this.txt_GhiChu);
            this.gB_GhiChu.Location = new System.Drawing.Point(516, 73);
            this.gB_GhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_GhiChu.Name = "gB_GhiChu";
            this.gB_GhiChu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_GhiChu.Size = new System.Drawing.Size(871, 176);
            this.gB_GhiChu.TabIndex = 8;
            this.gB_GhiChu.TabStop = false;
            this.gB_GhiChu.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GhiChu.Location = new System.Drawing.Point(9, 25);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(852, 134);
            this.txt_GhiChu.TabIndex = 0;
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Nhap.Location = new System.Drawing.Point(1435, 165);
            this.btn_Nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(100, 44);
            this.btn_Nhap.TabIndex = 0;
            this.btn_Nhap.Text = "Thêm";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            // 
            // gB_DanhSach
            // 
            this.gB_DanhSach.Controls.Add(this.dgw_DiemSV);
            this.gB_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_DanhSach.Location = new System.Drawing.Point(16, 439);
            this.gB_DanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_DanhSach.Name = "gB_DanhSach";
            this.gB_DanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_DanhSach.Size = new System.Drawing.Size(1519, 176);
            this.gB_DanhSach.TabIndex = 10;
            this.gB_DanhSach.TabStop = false;
            this.gB_DanhSach.Text = "Danh sách";
            // 
            // dgw_DiemSV
            // 
            this.dgw_DiemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_DiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_DiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaLop,
            this.MaMon,
            this.DiemQT,
            this.DiemCK,
            this.DiemTongKet,
            this.HocKi,
            this.XepLoai,
            this.GhiChu});
            this.dgw_DiemSV.Location = new System.Drawing.Point(4, 22);
            this.dgw_DiemSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_DiemSV.Name = "dgw_DiemSV";
            this.dgw_DiemSV.RowHeadersWidth = 51;
            this.dgw_DiemSV.Size = new System.Drawing.Size(1515, 150);
            this.dgw_DiemSV.TabIndex = 0;
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.HeaderText = "Mã môn ";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            // 
            // DiemQT
            // 
            this.DiemQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemQT.HeaderText = "Điểm quá trình";
            this.DiemQT.MinimumWidth = 6;
            this.DiemQT.Name = "DiemQT";
            // 
            // DiemCK
            // 
            this.DiemCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemCK.HeaderText = "Điểm cuối kì";
            this.DiemCK.MinimumWidth = 6;
            this.DiemCK.Name = "DiemCK";
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTongKet.HeaderText = "Điểm tổng kết";
            this.DiemTongKet.MinimumWidth = 6;
            this.DiemTongKet.Name = "DiemTongKet";
            // 
            // HocKi
            // 
            this.HocKi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HocKi.HeaderText = "Học kì";
            this.HocKi.MinimumWidth = 6;
            this.HocKi.Name = "HocKi";
            // 
            // XepLoai
            // 
            this.XepLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.XepLoai.HeaderText = "Xếp loại";
            this.XepLoai.MinimumWidth = 6;
            this.XepLoai.Name = "XepLoai";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(1435, 229);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 41);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(1435, 293);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 37);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 622);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.gB_DanhSach);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.gB_GhiChu);
            this.Controls.Add(this.gB_TTChiTiet);
            this.Controls.Add(this.gB_LuaChon);
            this.Controls.Add(this.lbl_TTD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm sinh viên";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            this.gB_LuaChon.ResumeLayout(false);
            this.gB_LuaChon.PerformLayout();
            this.gB_TTChiTiet.ResumeLayout(false);
            this.gB_TTChiTiet.PerformLayout();
            this.gB_GhiChu.ResumeLayout(false);
            this.gB_GhiChu.PerformLayout();
            this.gB_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DiemSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TTD;
        private System.Windows.Forms.GroupBox gB_LuaChon;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.ComboBox cbo_HocKi;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.Label lbl_HocKi;
        private System.Windows.Forms.Label lbl_Lop;
        private System.Windows.Forms.GroupBox gB_TTChiTiet;
        private System.Windows.Forms.TextBox txb_XepLoai;
        private System.Windows.Forms.Label lbl_HanhKiem;
        private System.Windows.Forms.Label lbl_DiemTK;
        private System.Windows.Forms.TextBox txt_DiemTK;
        private System.Windows.Forms.TextBox txb_DiemCK;
        private System.Windows.Forms.Label lbl_DiemCK;
        private System.Windows.Forms.TextBox txt_DiemQT;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txb_MaSV;
        private System.Windows.Forms.Label lbl_DiemQT;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lbl_MaSV;
        private System.Windows.Forms.GroupBox gB_GhiChu;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.GroupBox gB_DanhSach;
        private System.Windows.Forms.DataGridView dgw_DiemSV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

