﻿using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormChiTietBill : Form
    {
        private readonly StatisticRepository _db;
        private readonly BillVM _bvm;
        private readonly IEnumerable<RentOrderVM> _rovm;
        private readonly IEnumerable<ServiceOrderVM> _sovm;
        public FormChiTietBill(int Bill_Id)
        {
            InitializeComponent();
            _db = new StatisticRepository();
            _db.GetBillInformation(Bill_Id, out _bvm, out _rovm, out _sovm);
            LoadLabel();
            LoadRentOrder();
            LoadServiceOrder();
        }

        private void LoadLabel()
        {
            lblMaHoaDon.Text = _bvm.BillCode;
            lblNgayLap.Text = _bvm.DateCreated.ToString();
            lblNgayThanhToan.Text = _bvm.DateCheckedOut.ToString();
            lblTenKhachHang.Text = _bvm.Customer_Name;
            lblSoDienThoai.Text = _bvm.Customer_Phone;
            lblTenThuNgan.Text = _bvm.Cashier_Name;
            lblTongCong.Text = _bvm.Total.ToString("N0");
            lblDaCoc.Text = _bvm.Deposit.ToString("N0");
            lblPhaiTra.Text = (_bvm.Total - _bvm.Deposit).ToString("N0");
        }

        private void LoadRentOrder()
        {
            dgvSan.FormatTable();
            dgvSan.DataSource = _rovm.ToSortableBindingList();
            dgvSan.Columns["Id"].Visible = false;
            dgvSan.Columns["Bill_Code"].Visible = false;
            dgvSan.Columns["Stadium_Image"].Visible = false;
            dgvSan.Columns["Stadium_Id"].Visible = false;
            dgvSan.RowsDefaultCellStyle.SelectionBackColor = dgvSan.DefaultCellStyle.BackColor;
            dgvSan.RowsDefaultCellStyle.SelectionForeColor = dgvSan.DefaultCellStyle.ForeColor;
        }

        private void LoadServiceOrder()
        {
            dgvDV.FormatTable();
            dgvDV.DataSource = _sovm.ToSortableBindingList();
            dgvDV.Columns["Id"].Visible = false;
            dgvDV.Columns["Bill_Code"].Visible = false;
            dgvDV.Columns["Service_Image"].Visible = false;
            dgvDV.Columns["Service_Id"].Visible = false;
            dgvDV.RowsDefaultCellStyle.SelectionBackColor = dgvSan.DefaultCellStyle.BackColor;
            dgvDV.RowsDefaultCellStyle.SelectionForeColor = dgvSan.DefaultCellStyle.ForeColor;
        }
    }
}
