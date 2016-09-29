using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace QuanLiTruongHoc
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.DangNhap(txtTaiKhoan.Text, txtMK.Text) == true)
            {
                MessageBox.Show("Đăng nhập thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f = new Form1();
                f.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
            }
        }

        private void ckhienthi_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = ckhienthi.Checked ? false : true;
        }
    }
}
