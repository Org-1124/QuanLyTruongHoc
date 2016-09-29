namespace QuanLiTruongHoc
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnhocsinh = new System.Windows.Forms.ToolStripMenuItem();
            this.btngiaovien = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnbomon = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnhocsinh,
            this.btngiaovien,
            this.btnlop,
            this.btnbomon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(951, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnhocsinh
            // 
            this.btnhocsinh.Name = "btnhocsinh";
            this.btnhocsinh.Size = new System.Drawing.Size(67, 20);
            this.btnhocsinh.Text = "Học Sinh";
            this.btnhocsinh.Click += new System.EventHandler(this.btnhocsinh_Click);
            // 
            // btngiaovien
            // 
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.Size = new System.Drawing.Size(69, 20);
            this.btngiaovien.Text = "Giáo Viên";
            this.btngiaovien.Click += new System.EventHandler(this.btngiaovien_Click);
            // 
            // btnlop
            // 
            this.btnlop.Name = "btnlop";
            this.btnlop.Size = new System.Drawing.Size(39, 20);
            this.btnlop.Text = "Lớp";
            // 
            // btnbomon
            // 
            this.btnbomon.Name = "btnbomon";
            this.btnbomon.Size = new System.Drawing.Size(61, 20);
            this.btnbomon.Text = "Bộ Môn";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 418);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 442);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnhocsinh;
        private System.Windows.Forms.ToolStripMenuItem btngiaovien;
        private System.Windows.Forms.ToolStripMenuItem btnlop;
        private System.Windows.Forms.ToolStripMenuItem btnbomon;
        private System.Windows.Forms.TabControl tabControl1;

    }
}

