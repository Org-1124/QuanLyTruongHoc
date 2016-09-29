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
    public partial class Form1 : Form
    {
        TabPage tabPage1 = new TabPage();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhocsinh_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            Form2 f = new Form2();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            
            tabPage1.Controls.Add(f);
            f.Visible = true;
            tabPage1.Text = "Học Sinh";
            tabControl1.TabPages.Add(tabPage1);
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            Form2 f = new Form2();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            tabPage1.Controls.Add(f);
            f.Visible = true;
            tabPage1.Text = "Giao Viên";
            tabControl1.TabPages.Add(tabPage1);
        }
    }
}
