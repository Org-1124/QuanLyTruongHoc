using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QuanLiTruongHoc
{
    public partial class frmHocSinh : Form
    {
        enum LuaChon
        {
            Them,
            Sua,
            Xoa,
            Luu
        }
        LuaChon lc;
        public frmHocSinh()
        {
            InitializeComponent();
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            SuaHeaderText();
        }

        private void SuaHeaderText()
        {
            dgvHocSinh.Columns["IDHocSinh"].HeaderText = "Mã học sinh";
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvHocSinh.Columns["IDLop"].Visible = false;
            dgvHocSinh.Columns["SDT"].HeaderText = "Điện thoại";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["TenLop"].HeaderText = "Tên Lớp";
        }

        private void LoadDuLieu()
        {
            dgvHocSinh.DataSource = HocSinhDAO.LoadDataHocSinh();
            cboLop.DataSource = LopDAO.LoadDataLop();
            cboLop.ValueMember = "IDLop";
            cboLop.DisplayMember = "TenLop";
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            DataTable dt = (DataTable)dgvHocSinh.DataSource;
            for(int i = 0;i<dt.Rows.Count;i++)
            {
                ac.Add(dt.Rows[i][1].ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = ac;
            ReadOnly();
        }

        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr =  dgvHocSinh.SelectedRows[0];
            txtIDHocSinh.Text = dr.Cells["IDHocSinh"].Value.ToString();
            txtHoTen.Text = dr.Cells["HoTen"].Value.ToString();
            txtDiaChi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dr.Cells["SDT"].Value.ToString();
            DateTime dt;
            DateTime.TryParse(dr.Cells["NgaySinh"].Value.ToString(), out dt);
            try
            {
                dtpNgaySinh.Value = dt;
                cboLop.SelectedValue = (int)dr.Cells["IDLop"].Value;
                rdbNam.Checked = dr.Cells["GioiTinh"].Value.ToString().Equals("Nam") ? true : false;
                rdbNu.Checked = dr.Cells["GioiTinh"].Value.ToString().Equals("Nữ") ? true : false;
            }
            catch
            {
                dtpNgaySinh.Value = DateTimePicker.MinimumDateTime;
                rdbNam.Checked = false;
                rdbNu.Checked = false;
                cboLop.SelectedValue = 1;
            }
        }

        private void AnButton()
        {
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
        }

        private void HienButton()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lc = LuaChon.Them;
            AnButton();
            UnReadOnly();
            txtHoTen.Text = "";
            txtIDHocSinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void ThemHocSinh()
        {
            HocSinhDTO hs = new HocSinhDTO();
            hs.HoTen = txtHoTen.Text;
            hs.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            hs.SDT = txtSDT.Text;
            hs.NgaySinh = dtpNgaySinh.Value;
            hs.IDLop = (int)cboLop.SelectedValue;
            hs.DiaChi = txtDiaChi.Text;
            hs.IDHocSinh = HocSinhDAO.IDHocSinhCuoiCung() + 1;
            HocSinhDAO.ThemHS(hs);
        }

        private void SuaHocSinh()
        {
            HocSinhDTO hs = new HocSinhDTO();
            hs.IDHocSinh = int.Parse(txtIDHocSinh.Text);
            hs.HoTen = txtHoTen.Text;
            hs.IDLop = (int)cboLop.SelectedValue;
            hs.GioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            hs.NgaySinh = dtpNgaySinh.Value;
            hs.SDT = txtSDT.Text;
            hs.DiaChi = txtDiaChi.Text;
            HocSinhDAO.SuaHS(hs);
        }

        private void XoaHocSinh()
        {
            HocSinhDTO hs = new HocSinhDTO();
            hs.IDHocSinh = int.Parse(txtIDHocSinh.Text);
            HocSinhDAO.XoaHS(hs);
        }

        private void UnReadOnly()
        {
            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
        }

        private void ReadOnly()
        {
            txtHoTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (txtHoTen.Text == "") kt = false;
            else if (txtDiaChi.Text == "") kt = false;
            else if (rdbNam.Checked == false && rdbNu.Checked == false) kt = false;
            else if (txtSDT.Text == "") kt = false;
            if(kt==false)
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
                return;
            }
            switch(lc)
            {
                case LuaChon.Them:
                    ThemHocSinh();
                    LoadDuLieu();
                    break;
                case LuaChon.Sua:
                    SuaHocSinh();
                    LoadDuLieu();
                    break;
                case LuaChon.Xoa:
                    XoaHocSinh();
                    LoadDuLieu();
                    break;
                    
            }
            HienButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtIDHocSinh.Text = "";
            HienButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lc = LuaChon.Sua;
            AnButton();
            UnReadOnly();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lc = LuaChon.Xoa;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = HocSinhDAO.TimKiemHocSinh(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }
    }
}
