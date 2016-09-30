using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTruongHoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            frmGiaoVien frmGiaovien = new frmGiaoVien();
            frmGiaovien.ShowDialog();
        }
    }
}
