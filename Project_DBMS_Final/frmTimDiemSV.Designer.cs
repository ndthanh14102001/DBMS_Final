﻿namespace Project_DBMS_Final
{
    partial class frmTimDiemSV
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
            this.gB_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.lbl_MonHoc = new System.Windows.Forms.Label();
            this.txb_MaSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSv = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.gB_TTCT = new System.Windows.Forms.GroupBox();
            this.dgw_TCD = new System.Windows.Forms.DataGridView();
            this.lbl_TCD = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_TimKiem.SuspendLayout();
            this.gB_TTCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_TimKiem
            // 
            this.gB_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_TimKiem.Controls.Add(this.cbo_MonHoc);
            this.gB_TimKiem.Controls.Add(this.lbl_MonHoc);
            this.gB_TimKiem.Controls.Add(this.txb_MaSV);
            this.gB_TimKiem.Controls.Add(this.lbl_MaSv);
            this.gB_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TimKiem.Location = new System.Drawing.Point(16, 80);
            this.gB_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TimKiem.Name = "gB_TimKiem";
            this.gB_TimKiem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TimKiem.Size = new System.Drawing.Size(931, 108);
            this.gB_TimKiem.TabIndex = 29;
            this.gB_TimKiem.TabStop = false;
            this.gB_TimKiem.Text = "Tìm kiếm";
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(659, 46);
            this.cbo_MonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(248, 27);
            this.cbo_MonHoc.TabIndex = 3;
            // 
            // lbl_MonHoc
            // 
            this.lbl_MonHoc.AutoSize = true;
            this.lbl_MonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MonHoc.Location = new System.Drawing.Point(576, 50);
            this.lbl_MonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MonHoc.Name = "lbl_MonHoc";
            this.lbl_MonHoc.Size = new System.Drawing.Size(70, 19);
            this.lbl_MonHoc.TabIndex = 3;
            this.lbl_MonHoc.Text = "Môn học";
            // 
            // txb_MaSV
            // 
            this.txb_MaSV.Location = new System.Drawing.Point(353, 47);
            this.txb_MaSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb_MaSV.Name = "txb_MaSV";
            this.txb_MaSV.Size = new System.Drawing.Size(160, 26);
            this.txb_MaSV.TabIndex = 1;
            // 
            // lbl_MaSv
            // 
            this.lbl_MaSv.AutoSize = true;
            this.lbl_MaSv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaSv.Location = new System.Drawing.Point(243, 50);
            this.lbl_MaSv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSv.Name = "lbl_MaSv";
            this.lbl_MaSv.Size = new System.Drawing.Size(95, 19);
            this.lbl_MaSv.TabIndex = 0;
            this.lbl_MaSv.Text = "Mã sinh viên";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Location = new System.Drawing.Point(1145, 116);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(153, 44);
            this.btn_TimKiem.TabIndex = 15;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // gB_TTCT
            // 
            this.gB_TTCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gB_TTCT.Controls.Add(this.dgw_TCD);
            this.gB_TTCT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gB_TTCT.Location = new System.Drawing.Point(16, 196);
            this.gB_TTCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TTCT.Name = "gB_TTCT";
            this.gB_TTCT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_TTCT.Size = new System.Drawing.Size(1541, 471);
            this.gB_TTCT.TabIndex = 28;
            this.gB_TTCT.TabStop = false;
            this.gB_TTCT.Text = "Thông tin chi tiết";
            // 
            // dgw_TCD
            // 
            this.dgw_TCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_TCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaMon,
            this.DiemQuaTrinh,
            this.DiemCK,
            this.DiemTK,
            this.HocKi,
            this.XepLoai,
            this.GhiChu});
            this.dgw_TCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_TCD.Location = new System.Drawing.Point(4, 23);
            this.dgw_TCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_TCD.Name = "dgw_TCD";
            this.dgw_TCD.RowHeadersWidth = 51;
            this.dgw_TCD.Size = new System.Drawing.Size(1533, 444);
            this.dgw_TCD.TabIndex = 0;
            // 
            // lbl_TCD
            // 
            this.lbl_TCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TCD.AutoSize = true;
            this.lbl_TCD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TCD.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_TCD.Location = new System.Drawing.Point(641, 31);
            this.lbl_TCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TCD.Name = "lbl_TCD";
            this.lbl_TCD.Size = new System.Drawing.Size(190, 26);
            this.lbl_TCD.TabIndex = 28;
            this.lbl_TCD.Text = "TRA CỨU ĐIỂM";
            this.lbl_TCD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemQuaTrinh.HeaderText = "Điểm quá trình";
            this.DiemQuaTrinh.MinimumWidth = 6;
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            // 
            // DiemCK
            // 
            this.DiemCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemCK.HeaderText = "Điểm cuối kỳ";
            this.DiemCK.MinimumWidth = 6;
            this.DiemCK.Name = "DiemCK";
            // 
            // DiemTK
            // 
            this.DiemTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTK.HeaderText = "Điểm tổng kết";
            this.DiemTK.MinimumWidth = 6;
            this.DiemTK.Name = "DiemTK";
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
            // frmTimDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 665);
            this.Controls.Add(this.lbl_TCD);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.gB_TimKiem);
            this.Controls.Add(this.gB_TTCT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu điểm sinh viên";
            this.Load += new System.EventHandler(this.frmTimDiemSV_Load);
            this.gB_TimKiem.ResumeLayout(false);
            this.gB_TimKiem.PerformLayout();
            this.gB_TTCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_TCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_TimKiem;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.Label lbl_MonHoc;
        private System.Windows.Forms.TextBox txb_MaSV;
        private System.Windows.Forms.Label lbl_MaSv;
        private System.Windows.Forms.GroupBox gB_TTCT;
        private System.Windows.Forms.DataGridView dgw_TCD;
        private System.Windows.Forms.Label lbl_TCD;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn XepLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}