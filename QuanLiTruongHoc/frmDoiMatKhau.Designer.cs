﻿namespace QuanLiTruongHoc
{
    partial class frmDoiMatKhau
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
            this.btndoimk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chekmk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(208, 180);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(94, 33);
            this.btndoimk.TabIndex = 0;
            this.btndoimk.Text = "Đổi Mật Khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndoimk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chekmk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtxacnhan);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 263);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // chekmk
            // 
            this.chekmk.AutoSize = true;
            this.chekmk.Location = new System.Drawing.Point(28, 189);
            this.chekmk.Name = "chekmk";
            this.chekmk.Size = new System.Drawing.Size(66, 17);
            this.chekmk.TabIndex = 6;
            this.chekmk.Text = "Hiển Thị";
            this.chekmk.UseVisualStyleBackColor = true;
            this.chekmk.CheckedChanged += new System.EventHandler(this.chekmk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Location = new System.Drawing.Point(158, 133);
            this.txtxacnhan.Multiline = true;
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.PasswordChar = '*';
            this.txtxacnhan.Size = new System.Drawing.Size(221, 25);
            this.txtxacnhan.TabIndex = 5;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(158, 41);
            this.txttk.Multiline = true;
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(221, 25);
            this.txttk.TabIndex = 3;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(158, 84);
            this.txtmk.Multiline = true;
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(221, 25);
            this.txtmk.TabIndex = 4;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chekmk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
    }
}