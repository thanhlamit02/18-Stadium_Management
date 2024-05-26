﻿
namespace GUILayer
{
    partial class FormControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnStatistic = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.pnlCashier = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnDSNV = new System.Windows.Forms.Button();
            this.btnCashier = new FontAwesome.Sharp.IconButton();
            this.btnService = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnStadium = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.iconMinimize = new FontAwesome.Sharp.IconButton();
            this.iconZoom = new FontAwesome.Sharp.IconButton();
            this.iconExit = new FontAwesome.Sharp.IconButton();
            this.lblCurrentForm = new System.Windows.Forms.Label();
            this.iconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDMY = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.pnlCashier.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.btnStatistic);
            this.PanelMenu.Controls.Add(this.btnHoaDon);
            this.PanelMenu.Controls.Add(this.btnCustomer);
            this.PanelMenu.Controls.Add(this.pnlCashier);
            this.PanelMenu.Controls.Add(this.btnCashier);
            this.PanelMenu.Controls.Add(this.btnService);
            this.PanelMenu.Controls.Add(this.btnSetting);
            this.PanelMenu.Controls.Add(this.btnLogOut);
            this.PanelMenu.Controls.Add(this.btnStadium);
            this.PanelMenu.Controls.Add(this.pnlLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(255, 1038);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnStatistic.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistic.IconSize = 35;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(0, 608);
            this.btnStatistic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnStatistic.Size = new System.Drawing.Size(255, 77);
            this.btnStatistic.TabIndex = 18;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 35;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 531);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(255, 77);
            this.btnHoaDon.TabIndex = 17;
            this.btnHoaDon.Text = "Hoá đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 35;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 454);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnCustomer.Size = new System.Drawing.Size(255, 77);
            this.btnCustomer.TabIndex = 14;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlCashier
            // 
            this.pnlCashier.BackColor = System.Drawing.Color.Indigo;
            this.pnlCashier.Controls.Add(this.btnTaiKhoan);
            this.pnlCashier.Controls.Add(this.btnDSNV);
            this.pnlCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCashier.ForeColor = System.Drawing.Color.White;
            this.pnlCashier.Location = new System.Drawing.Point(0, 339);
            this.pnlCashier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCashier.Name = "pnlCashier";
            this.pnlCashier.Size = new System.Drawing.Size(255, 115);
            this.pnlCashier.TabIndex = 13;
            this.pnlCashier.Visible = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("SVN-Gilroy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 57);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(255, 52);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "DS Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnDSNV
            // 
            this.btnDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSNV.FlatAppearance.BorderSize = 0;
            this.btnDSNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNV.Font = new System.Drawing.Font("SVN-Gilroy", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDSNV.Location = new System.Drawing.Point(0, 0);
            this.btnDSNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(255, 57);
            this.btnDSNV.TabIndex = 0;
            this.btnDSNV.Text = "DS Nhân viên";
            this.btnDSNV.UseVisualStyleBackColor = true;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCashier.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCashier.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCashier.IconSize = 35;
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.Location = new System.Drawing.Point(0, 262);
            this.btnCashier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnCashier.Size = new System.Drawing.Size(255, 77);
            this.btnCashier.TabIndex = 12;
            this.btnCashier.Text = "Nhân viên";
            this.btnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnService.IconColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnService.IconSize = 35;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 185);
            this.btnService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnService.Size = new System.Drawing.Size(255, 77);
            this.btnService.TabIndex = 10;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 884);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnSetting.Size = new System.Drawing.Size(255, 77);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 961);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnLogOut.Size = new System.Drawing.Size(255, 77);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnStadium
            // 
            this.btnStadium.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStadium.FlatAppearance.BorderSize = 0;
            this.btnStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStadium.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStadium.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStadium.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.btnStadium.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStadium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStadium.IconSize = 35;
            this.btnStadium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStadium.Location = new System.Drawing.Point(0, 108);
            this.btnStadium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStadium.Name = "btnStadium";
            this.btnStadium.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.btnStadium.Size = new System.Drawing.Size(255, 77);
            this.btnStadium.TabIndex = 1;
            this.btnStadium.Text = "Sân bóng";
            this.btnStadium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStadium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStadium.UseVisualStyleBackColor = true;
            this.btnStadium.Click += new System.EventHandler(this.btnStadium_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(255, 108);
            this.pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(76, 5);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(98, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.lblRole);
            this.panelTitlebar.Controls.Add(this.lblDateTime);
            this.panelTitlebar.Controls.Add(this.iconMinimize);
            this.panelTitlebar.Controls.Add(this.iconZoom);
            this.panelTitlebar.Controls.Add(this.iconExit);
            this.panelTitlebar.Controls.Add(this.lblCurrentForm);
            this.panelTitlebar.Controls.Add(this.iconCurrentForm);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(255, 0);
            this.panelTitlebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1585, 108);
            this.panelTitlebar.TabIndex = 1;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("SVN-Gilroy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRole.Location = new System.Drawing.Point(1116, 54);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(101, 26);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Thu Ngân";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("SVN-Gilroy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDateTime.Location = new System.Drawing.Point(549, 48);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(101, 32);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "12:30:33";
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.IconSize = 25;
            this.iconMinimize.Location = new System.Drawing.Point(1442, 5);
            this.iconMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(45, 46);
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.UseVisualStyleBackColor = true;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconZoom
            // 
            this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
            this.iconZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconZoom.IconSize = 25;
            this.iconZoom.Location = new System.Drawing.Point(1486, 5);
            this.iconZoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconZoom.Name = "iconZoom";
            this.iconZoom.Size = new System.Drawing.Size(45, 46);
            this.iconZoom.TabIndex = 3;
            this.iconZoom.UseVisualStyleBackColor = true;
            this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.IconSize = 25;
            this.iconExit.Location = new System.Drawing.Point(1528, 5);
            this.iconExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(45, 46);
            this.iconExit.TabIndex = 2;
            this.iconExit.UseVisualStyleBackColor = true;
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // lblCurrentForm
            // 
            this.lblCurrentForm.AutoSize = true;
            this.lblCurrentForm.Font = new System.Drawing.Font("SVN-Gilroy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentForm.Location = new System.Drawing.Point(84, 48);
            this.lblCurrentForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentForm.Name = "lblCurrentForm";
            this.lblCurrentForm.Size = new System.Drawing.Size(0, 26);
            this.lblCurrentForm.TabIndex = 1;
            // 
            // iconCurrentForm
            // 
            this.iconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentForm.IconSize = 48;
            this.iconCurrentForm.Location = new System.Drawing.Point(28, 35);
            this.iconCurrentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconCurrentForm.Name = "iconCurrentForm";
            this.iconCurrentForm.Size = new System.Drawing.Size(48, 49);
            this.iconCurrentForm.TabIndex = 0;
            this.iconCurrentForm.TabStop = false;
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelshadow.Location = new System.Drawing.Point(260, 98);
            this.panelshadow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(942, 14);
            this.panelshadow.TabIndex = 2;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChildForm.BackgroundImage")));
            this.pnlChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChildForm.Controls.Add(this.lblDate);
            this.pnlChildForm.Controls.Add(this.lblDMY);
            this.pnlChildForm.Controls.Add(this.lblTime);
            this.pnlChildForm.Location = new System.Drawing.Point(255, 108);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1586, 931);
            this.pnlChildForm.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("SVN-Gilroy Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(36, 853);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(179, 53);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Monday";
            // 
            // lblDMY
            // 
            this.lblDMY.AutoSize = true;
            this.lblDMY.BackColor = System.Drawing.Color.Transparent;
            this.lblDMY.Font = new System.Drawing.Font("SVN-Gilroy Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMY.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDMY.Location = new System.Drawing.Point(236, 853);
            this.lblDMY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDMY.Name = "lblDMY";
            this.lblDMY.Size = new System.Drawing.Size(253, 53);
            this.lblDMY.TabIndex = 8;
            this.lblDMY.Text = "05/06/2001";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("SVN-Gilroy SemiBold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(973, 5);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(613, 192);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "10:08:01";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1840, 1038);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainControl";
            this.PanelMenu.ResumeLayout(false);
            this.pnlCashier.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentForm)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.pnlChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnStadium;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentForm;
        private System.Windows.Forms.Label lblCurrentForm;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel pnlChildForm;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconZoom;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDMY;
        private System.Windows.Forms.Label lblDate;
        private FontAwesome.Sharp.IconButton btnService;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private System.Windows.Forms.Panel pnlCashier;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDSNV;
        private FontAwesome.Sharp.IconButton btnCashier;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnStatistic;
        private System.Windows.Forms.Label lblRole;
    }
}