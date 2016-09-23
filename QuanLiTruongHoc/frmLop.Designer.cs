namespace QuanLiTruongHoc
{
    partial class frmLop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDLop = new System.Windows.Forms.Label();
            this.TenLop = new System.Windows.Forms.Label();
            this.SoHS = new System.Windows.Forms.Label();
            this.LopTruong = new System.Windows.Forms.Label();
            this.GiaoVien = new System.Windows.Forms.Label();
            this.txtIDLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtSoLuongHS = new System.Windows.Forms.TextBox();
            this.cboTenLopTruong = new System.Windows.Forms.ComboBox();
            this.cboTenGiaoVien = new System.Windows.Forms.ComboBox();
            this.gbthem = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbthem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // IDLop
            // 
            this.IDLop.AutoSize = true;
            this.IDLop.Location = new System.Drawing.Point(12, 22);
            this.IDLop.Name = "IDLop";
            this.IDLop.Size = new System.Drawing.Size(42, 13);
            this.IDLop.TabIndex = 1;
            this.IDLop.Text = "ID Lớp ";
            // 
            // TenLop
            // 
            this.TenLop.AutoSize = true;
            this.TenLop.Location = new System.Drawing.Point(12, 77);
            this.TenLop.Name = "TenLop";
            this.TenLop.Size = new System.Drawing.Size(50, 13);
            this.TenLop.TabIndex = 2;
            this.TenLop.Text = "Tên Lớp ";
            // 
            // SoHS
            // 
            this.SoHS.AutoSize = true;
            this.SoHS.Location = new System.Drawing.Point(250, 22);
            this.SoHS.Name = "SoHS";
            this.SoHS.Size = new System.Drawing.Size(63, 13);
            this.SoHS.TabIndex = 3;
            this.SoHS.Text = "Số học sinh";
            // 
            // LopTruong
            // 
            this.LopTruong.AutoSize = true;
            this.LopTruong.Location = new System.Drawing.Point(250, 77);
            this.LopTruong.Name = "LopTruong";
            this.LopTruong.Size = new System.Drawing.Size(62, 13);
            this.LopTruong.TabIndex = 4;
            this.LopTruong.Text = "Lớp Trưởng";
            // 
            // GiaoVien
            // 
            this.GiaoVien.AutoSize = true;
            this.GiaoVien.Location = new System.Drawing.Point(573, 22);
            this.GiaoVien.Name = "GiaoVien";
            this.GiaoVien.Size = new System.Drawing.Size(56, 13);
            this.GiaoVien.TabIndex = 5;
            this.GiaoVien.Text = "Giáo Viên ";
            // 
            // txtIDLop
            // 
            this.txtIDLop.Location = new System.Drawing.Point(69, 19);
            this.txtIDLop.Name = "txtIDLop";
            this.txtIDLop.Size = new System.Drawing.Size(116, 20);
            this.txtIDLop.TabIndex = 6;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(69, 74);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(116, 20);
            this.txtTenLop.TabIndex = 7;
            // 
            // txtSoLuongHS
            // 
            this.txtSoLuongHS.Location = new System.Drawing.Point(329, 19);
            this.txtSoLuongHS.Name = "txtSoLuongHS";
            this.txtSoLuongHS.Size = new System.Drawing.Size(176, 20);
            this.txtSoLuongHS.TabIndex = 8;
            // 
            // cboTenLopTruong
            // 
            this.cboTenLopTruong.FormattingEnabled = true;
            this.cboTenLopTruong.Location = new System.Drawing.Point(329, 74);
            this.cboTenLopTruong.Name = "cboTenLopTruong";
            this.cboTenLopTruong.Size = new System.Drawing.Size(176, 21);
            this.cboTenLopTruong.TabIndex = 9;
            // 
            // cboTenGiaoVien
            // 
            this.cboTenGiaoVien.FormattingEnabled = true;
            this.cboTenGiaoVien.Location = new System.Drawing.Point(635, 19);
            this.cboTenGiaoVien.Name = "cboTenGiaoVien";
            this.cboTenGiaoVien.Size = new System.Drawing.Size(176, 21);
            this.cboTenGiaoVien.TabIndex = 10;
            // 
            // gbthem
            // 
            this.gbthem.Controls.Add(this.txtTimKiem);
            this.gbthem.Controls.Add(this.btnTimKiem);
            this.gbthem.Controls.Add(this.btnLuu);
            this.gbthem.Controls.Add(this.btnXoa);
            this.gbthem.Controls.Add(this.btnSua);
            this.gbthem.Controls.Add(this.btnThem);
            this.gbthem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbthem.Location = new System.Drawing.Point(0, 134);
            this.gbthem.Name = "gbthem";
            this.gbthem.Size = new System.Drawing.Size(849, 64);
            this.gbthem.TabIndex = 11;
            this.gbthem.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(600, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(681, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(762, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(519, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(290, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(69, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 489);
            this.Controls.Add(this.gbthem);
            this.Controls.Add(this.cboTenGiaoVien);
            this.Controls.Add(this.cboTenLopTruong);
            this.Controls.Add(this.txtSoLuongHS);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtIDLop);
            this.Controls.Add(this.GiaoVien);
            this.Controls.Add(this.LopTruong);
            this.Controls.Add(this.SoHS);
            this.Controls.Add(this.TenLop);
            this.Controls.Add(this.IDLop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLop";
            this.Text = "Quản lý lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbthem.ResumeLayout(false);
            this.gbthem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label IDLop;
        private System.Windows.Forms.Label TenLop;
        private System.Windows.Forms.Label SoHS;
        private System.Windows.Forms.Label LopTruong;
        private System.Windows.Forms.Label GiaoVien;
        private System.Windows.Forms.TextBox txtIDLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtSoLuongHS;
        private System.Windows.Forms.ComboBox cboTenLopTruong;
        private System.Windows.Forms.ComboBox cboTenGiaoVien;
        private System.Windows.Forms.GroupBox gbthem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}