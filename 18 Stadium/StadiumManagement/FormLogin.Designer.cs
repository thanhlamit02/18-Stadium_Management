﻿
namespace GUILayer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbexit = new System.Windows.Forms.Label();
            this.lbmini = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.HideSelection = false;
            this.txtUser.Location = new System.Drawing.Point(190, 338);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(268, 32);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Tài khoản";
            this.txtUser.Click += new System.EventHandler(this.txtuser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(129, 377);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 2);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(130, 486);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 2);
            this.panel2.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("SVN-Gilroy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = false;
            this.txtPass.Location = new System.Drawing.Point(192, 448);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(268, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Mật khẩu";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Click += new System.EventHandler(this.txtpass_Click);
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(159, 545);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(225, 63);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Xác nhận";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexit.ForeColor = System.Drawing.Color.White;
            this.lbexit.Location = new System.Drawing.Point(488, 14);
            this.lbexit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(28, 33);
            this.lbexit.TabIndex = 8;
            this.lbexit.Text = "x";
            this.lbexit.Click += new System.EventHandler(this.lbexit_Click);
            // 
            // lbmini
            // 
            this.lbmini.AutoSize = true;
            this.lbmini.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmini.ForeColor = System.Drawing.Color.White;
            this.lbmini.Location = new System.Drawing.Point(446, 5);
            this.lbmini.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmini.Name = "lbmini";
            this.lbmini.Size = new System.Drawing.Size(34, 47);
            this.lbmini.TabIndex = 9;
            this.lbmini.Text = "-";
            this.lbmini.Click += new System.EventHandler(this.lbmini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SVN-Gilroy SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 64);
            this.label1.TabIndex = 12;
            this.label1.Text = "Đăng nhập";
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Image = global::GUILayer.Properties.Resources.eye_open2;
            this.btnShowPass.Location = new System.Drawing.Point(404, 452);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(70, 31);
            this.btnShowPass.TabIndex = 20;
            this.btnShowPass.TabStop = false;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnHidePass
            // 
            this.btnHidePass.BackColor = System.Drawing.Color.Transparent;
            this.btnHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePass.FlatAppearance.BorderSize = 0;
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.ForeColor = System.Drawing.Color.Transparent;
            this.btnHidePass.Image = global::GUILayer.Properties.Resources.eye_close;
            this.btnHidePass.Location = new System.Drawing.Point(404, 452);
            this.btnHidePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(70, 31);
            this.btnHidePass.TabIndex = 13;
            this.btnHidePass.UseVisualStyleBackColor = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUILayer.Properties.Resources.password_2;
            this.pictureBox2.Location = new System.Drawing.Point(72, 440);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUILayer.Properties.Resources.username_2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 331);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(142, 18);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 169);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(536, 662);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lbmini);
            this.Controls.Add(this.lbexit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbexit;
        private System.Windows.Forms.Label lbmini;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.Button btnShowPass;
    }
}