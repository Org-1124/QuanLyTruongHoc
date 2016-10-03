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

        private void btnThem_Click(object sender, EventArgs e)
        {
            lc = LuaChon.Them;
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
        private void UnReadOnly()
        {
            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch(lc)
            {
                case LuaChon.Them:
                    ThemHocSinh();
                    LoadDuLieu();
                    break;
            }
        }
    }
}
