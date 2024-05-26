
namespace GUILayer.ChildForm
{
    partial class FormHoaDon
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
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.printDialogBill = new System.Windows.Forms.PrintDialog();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconDice = new FontAwesome.Sharp.IconPictureBox();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThanhToan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDatSan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDatDichVu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMaHoaDon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSDTKhach = new MaterialSkin.Controls.MaterialLabel();
            this.txtNgayTao = new MaterialSkin.Controls.MaterialLabel();
            this.txtThuNgan = new MaterialSkin.Controls.MaterialLabel();
            this.txtTienCoc = new MaterialSkin.Controls.MaterialLabel();
            this.txtTongTien = new MaterialSkin.Controls.MaterialLabel();
            this.txtPhaiTra = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(18, 334);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 62;
            this.dgvBill.Size = new System.Drawing.Size(1526, 551);
            this.dgvBill.TabIndex = 10;
            this.dgvBill.SelectionChanged += new System.EventHandler(this.dgvBill_SelectionChanged);
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(238, 97);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(313, 37);
            this.cbbKhachHang.TabIndex = 48;
            // 
            // printDialogBill
            // 
            this.printDialogBill.UseEXDialog = true;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(1344, 291);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(38, 38);
            this.iconPictureBox1.TabIndex = 50;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconDice
            // 
            this.iconDice.BackColor = System.Drawing.Color.Transparent;
            this.iconDice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconDice.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.iconDice.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconDice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDice.IconSize = 45;
            this.iconDice.Location = new System.Drawing.Point(508, 25);
            this.iconDice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconDice.Name = "iconDice";
            this.iconDice.Size = new System.Drawing.Size(45, 46);
            this.iconDice.TabIndex = 51;
            this.iconDice.TabStop = false;
            this.iconDice.Click += new System.EventHandler(this.iconDice_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Depth = 0;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1134, 242);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(106, 55);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Depth = 0;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(970, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(106, 55);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.btnThanhToan.Depth = 0;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(764, 242);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Primary = true;
            this.btnThanhToan.Size = new System.Drawing.Size(159, 55);
            this.btnThanhToan.TabIndex = 73;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Depth = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(610, 242);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(106, 55);
            this.btnThem.TabIndex = 74;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(1390, 291);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(153, 32);
            this.txtSearch.TabIndex = 75;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatSan.Depth = 0;
            this.btnDatSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSan.Location = new System.Drawing.Point(48, 242);
            this.btnDatSan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatSan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Primary = true;
            this.btnDatSan.Size = new System.Drawing.Size(122, 55);
            this.btnDatSan.TabIndex = 74;
            this.btnDatSan.Text = "Đặt sân";
            this.btnDatSan.UseVisualStyleBackColor = false;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // btnDatDichVu
            // 
            this.btnDatDichVu.BackColor = System.Drawing.SystemColors.Control;
            this.btnDatDichVu.Depth = 0;
            this.btnDatDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatDichVu.Location = new System.Drawing.Point(201, 242);
            this.btnDatDichVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatDichVu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDatDichVu.Name = "btnDatDichVu";
            this.btnDatDichVu.Primary = true;
            this.btnDatDichVu.Size = new System.Drawing.Size(159, 55);
            this.btnDatDichVu.TabIndex = 73;
            this.btnDatDichVu.Text = "Đặt dịch vụ";
            this.btnDatDichVu.UseVisualStyleBackColor = false;
            this.btnDatDichVu.Click += new System.EventHandler(this.btnDatDichVu_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 42);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(138, 27);
            this.materialLabel2.TabIndex = 77;
            this.materialLabel2.Text = "Mã hoá đơn :";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Depth = 0;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Hint = "";
            this.txtMaHoaDon.Location = new System.Drawing.Point(238, 35);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.PasswordChar = '\0';
            this.txtMaHoaDon.SelectedText = "";
            this.txtMaHoaDon.SelectionLength = 0;
            this.txtMaHoaDon.SelectionStart = 0;
            this.txtMaHoaDon.Size = new System.Drawing.Size(300, 32);
            this.txtMaHoaDon.TabIndex = 76;
            this.txtMaHoaDon.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(40, 105);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(181, 27);
            this.materialLabel1.TabIndex = 77;
            this.materialLabel1.Text = "Tên khách hàng : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(43, 169);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(183, 27);
            this.materialLabel3.TabIndex = 79;
            this.materialLabel3.Text = "SĐT Khách hàng :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(609, 52);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 27);
            this.materialLabel4.TabIndex = 81;
            this.materialLabel4.Text = "Ngày tạo :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(609, 131);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(112, 27);
            this.materialLabel5.TabIndex = 83;
            this.materialLabel5.Text = "Thu ngân :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(1121, 42);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(106, 27);
            this.materialLabel6.TabIndex = 85;
            this.materialLabel6.Text = "Tiền cọc :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(1121, 105);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(113, 27);
            this.materialLabel7.TabIndex = 85;
            this.materialLabel7.Text = "Tổng tiền :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(1121, 168);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(96, 27);
            this.materialLabel8.TabIndex = 85;
            this.materialLabel8.Text = "Phải trả :";
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.AutoSize = true;
            this.txtSDTKhach.Depth = 0;
            this.txtSDTKhach.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtSDTKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSDTKhach.Location = new System.Drawing.Point(232, 169);
            this.txtSDTKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSDTKhach.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(0, 27);
            this.txtSDTKhach.TabIndex = 86;
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.AutoSize = true;
            this.txtNgayTao.Depth = 0;
            this.txtNgayTao.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtNgayTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNgayTao.Location = new System.Drawing.Point(758, 52);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNgayTao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.Size = new System.Drawing.Size(0, 27);
            this.txtNgayTao.TabIndex = 87;
            // 
            // txtThuNgan
            // 
            this.txtThuNgan.AutoSize = true;
            this.txtThuNgan.Depth = 0;
            this.txtThuNgan.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtThuNgan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtThuNgan.Location = new System.Drawing.Point(758, 131);
            this.txtThuNgan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtThuNgan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtThuNgan.Name = "txtThuNgan";
            this.txtThuNgan.Size = new System.Drawing.Size(0, 27);
            this.txtThuNgan.TabIndex = 88;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.AutoSize = true;
            this.txtTienCoc.Depth = 0;
            this.txtTienCoc.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtTienCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTienCoc.Location = new System.Drawing.Point(1287, 42);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTienCoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(0, 27);
            this.txtTienCoc.TabIndex = 87;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Depth = 0;
            this.txtTongTien.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTongTien.Location = new System.Drawing.Point(1287, 105);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTongTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(0, 27);
            this.txtTongTien.TabIndex = 87;
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.AutoSize = true;
            this.txtPhaiTra.Depth = 0;
            this.txtPhaiTra.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtPhaiTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPhaiTra.Location = new System.Drawing.Point(1287, 168);
            this.txtPhaiTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPhaiTra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Size = new System.Drawing.Size(0, 27);
            this.txtPhaiTra.TabIndex = 87;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1562, 900);
            this.Controls.Add(this.txtThuNgan);
            this.Controls.Add(this.txtPhaiTra);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtNgayTao);
            this.Controls.Add(this.txtSDTKhach);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.iconDice);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDatDichVu);
            this.Controls.Add(this.btnDatSan);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.dgvBill);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHoaDon";
            this.Text = "Hoá đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.PrintDialog printDialogBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconDice;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialRaisedButton btnThanhToan;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnDatSan;
        private MaterialSkin.Controls.MaterialRaisedButton btnDatDichVu;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMaHoaDon;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel txtSDTKhach;
        private MaterialSkin.Controls.MaterialLabel txtNgayTao;
        private MaterialSkin.Controls.MaterialLabel txtThuNgan;
        private MaterialSkin.Controls.MaterialLabel txtTienCoc;
        private MaterialSkin.Controls.MaterialLabel txtTongTien;
        private MaterialSkin.Controls.MaterialLabel txtPhaiTra;
    }
}