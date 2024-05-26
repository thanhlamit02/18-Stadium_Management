﻿using BusinessLayer;
using BusinessLayer.Repository;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUILayer.ChildForm.SubForm
{
    public partial class FormChonDichVu : Form
    {
        private readonly ServiceRepository _db;
        public FormChonDichVu()
        {
            InitializeComponent();
            _db = new ServiceRepository();
            LoadListView();
        }

        private void LoadListView()
        {
            int i = 0;
            IEnumerable<ServiceFormatVM> listSVM = _db.GetList("");
            Image img;
            ListViewItem item;
            foreach (ServiceFormatVM svm in listSVM)
            {
                img = svm.Image.ByteArrayToImage();
                if (img != null)
                {
                    imgList.Images.Add(img);
                }
                else
                {
                    imgList.Images.Add(new Bitmap(120, 120));
                }
                item = new ListViewItem
                {
                    Text = $"{svm.Name}\r\n{svm.Price}",
                    Tag = svm.Id,
                    ImageIndex = i++
                };
                lvDV.Items.Add(item);
            }
        }

        public delegate void SendData(int id, string name, double price, Image img);
        public SendData SD { get; set; }
        private void lvDV_Click(object sender, EventArgs e)
        {
            int id = (int)lvDV.SelectedItems[0].Tag;
            Image img = imgList.Images[lvDV.SelectedItems[0].ImageIndex];
            string[] NP = lvDV.SelectedItems[0].Text.Split('\n');
            string name = NP[0];
            double price = Convert.ToDouble(NP[1]);
            SD(id, name, price, img);
            this.Dispose();
        }
    }
}
