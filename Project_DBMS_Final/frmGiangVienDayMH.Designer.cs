namespace Project_DBMS_Final
{
    partial class frmGiangVienDayMH
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_TroVe = new System.Windows.Forms.Button();
            this.gb_DanhSach = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_ThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.lb_MaGV = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_MaMonHoc = new System.Windows.Forms.Label();
            this.lb_TenMonHoc = new System.Windows.Forms.Label();
            this.lb_SoTinChi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.gb_ThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1084, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN MÔN HỌC CỦA GIẢNG VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Them
            // 
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(990, 172);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(75, 36);
            this.bt_Them.TabIndex = 2;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(990, 231);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(75, 35);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            // 
            // bt_TroVe
            // 
            this.bt_TroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TroVe.Location = new System.Drawing.Point(990, 282);
            this.bt_TroVe.Name = "bt_TroVe";
            this.bt_TroVe.Size = new System.Drawing.Size(75, 39);
            this.bt_TroVe.TabIndex = 4;
            this.bt_TroVe.Text = "Trở về";
            this.bt_TroVe.UseVisualStyleBackColor = true;
            this.bt_TroVe.Click += new System.EventHandler(this.bt_TroVe_Click);
            // 
            // gb_DanhSach
            // 
            this.gb_DanhSach.Controls.Add(this.dgv_DanhSach);
            this.gb_DanhSach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DanhSach.Location = new System.Drawing.Point(328, 66);
            this.gb_DanhSach.Name = "gb_DanhSach";
            this.gb_DanhSach.Size = new System.Drawing.Size(640, 365);
            this.gb_DanhSach.TabIndex = 5;
            this.gb_DanhSach.TabStop = false;
            this.gb_DanhSach.Text = "Danh sách";
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.MaMH,
            this.TenMon,
            this.SoTC});
            this.dgv_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSach.Location = new System.Drawing.Point(3, 18);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.Size = new System.Drawing.Size(634, 344);
            this.dgv_DanhSach.TabIndex = 0;
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // MaMH
            // 
            this.MaMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMH.HeaderText = "Mã môn";
            this.MaMH.Name = "MaMH";
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.Name = "TenMon";
            // 
            // SoTC
            // 
            this.SoTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.Name = "SoTC";
            // 
            // gb_ThongTinChiTiet
            // 
            this.gb_ThongTinChiTiet.Controls.Add(this.textBox5);
            this.gb_ThongTinChiTiet.Controls.Add(this.textBox4);
            this.gb_ThongTinChiTiet.Controls.Add(this.textBox3);
            this.gb_ThongTinChiTiet.Controls.Add(this.textBox2);
            this.gb_ThongTinChiTiet.Controls.Add(this.textBox1);
            this.gb_ThongTinChiTiet.Controls.Add(this.lb_SoTinChi);
            this.gb_ThongTinChiTiet.Controls.Add(this.lb_TenMonHoc);
            this.gb_ThongTinChiTiet.Controls.Add(this.lb_MaMonHoc);
            this.gb_ThongTinChiTiet.Controls.Add(this.lb_HoTen);
            this.gb_ThongTinChiTiet.Controls.Add(this.lb_MaGV);
            this.gb_ThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ThongTinChiTiet.Location = new System.Drawing.Point(12, 77);
            this.gb_ThongTinChiTiet.Name = "gb_ThongTinChiTiet";
            this.gb_ThongTinChiTiet.Size = new System.Drawing.Size(310, 351);
            this.gb_ThongTinChiTiet.TabIndex = 6;
            this.gb_ThongTinChiTiet.TabStop = false;
            this.gb_ThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // lb_MaGV
            // 
            this.lb_MaGV.AutoSize = true;
            this.lb_MaGV.Location = new System.Drawing.Point(6, 35);
            this.lb_MaGV.Name = "lb_MaGV";
            this.lb_MaGV.Size = new System.Drawing.Size(84, 15);
            this.lb_MaGV.TabIndex = 0;
            this.lb_MaGV.Text = "Mã giảng viên";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(6, 71);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(43, 15);
            this.lb_HoTen.TabIndex = 1;
            this.lb_HoTen.Text = "Họ tên";
            // 
            // lb_MaMonHoc
            // 
            this.lb_MaMonHoc.AutoSize = true;
            this.lb_MaMonHoc.Location = new System.Drawing.Point(6, 109);
            this.lb_MaMonHoc.Name = "lb_MaMonHoc";
            this.lb_MaMonHoc.Size = new System.Drawing.Size(74, 15);
            this.lb_MaMonHoc.TabIndex = 2;
            this.lb_MaMonHoc.Text = "Mã môn học";
            // 
            // lb_TenMonHoc
            // 
            this.lb_TenMonHoc.AutoSize = true;
            this.lb_TenMonHoc.Location = new System.Drawing.Point(6, 144);
            this.lb_TenMonHoc.Name = "lb_TenMonHoc";
            this.lb_TenMonHoc.Size = new System.Drawing.Size(77, 15);
            this.lb_TenMonHoc.TabIndex = 3;
            this.lb_TenMonHoc.Text = "Tên môn học";
            // 
            // lb_SoTinChi
            // 
            this.lb_SoTinChi.AutoSize = true;
            this.lb_SoTinChi.Location = new System.Drawing.Point(6, 183);
            this.lb_SoTinChi.Name = "lb_SoTinChi";
            this.lb_SoTinChi.Size = new System.Drawing.Size(57, 15);
            this.lb_SoTinChi.TabIndex = 4;
            this.lb_SoTinChi.Text = "Số tín chỉ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 178);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 139);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 104);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 66);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 20);
            this.textBox5.TabIndex = 9;
            // 
            // frmGiangVienDayMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 443);
            this.Controls.Add(this.gb_ThongTinChiTiet);
            this.Controls.Add(this.gb_DanhSach);
            this.Controls.Add(this.bt_TroVe);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.label1);
            this.Name = "frmGiangVienDayMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVienDayMH";
            this.gb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.gb_ThongTinChiTiet.ResumeLayout(false);
            this.gb_ThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_TroVe;
        private System.Windows.Forms.GroupBox gb_DanhSach;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.GroupBox gb_ThongTinChiTiet;
        private System.Windows.Forms.Label lb_MaGV;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_SoTinChi;
        private System.Windows.Forms.Label lb_TenMonHoc;
        private System.Windows.Forms.Label lb_MaMonHoc;
        private System.Windows.Forms.Label lb_HoTen;
    }
}