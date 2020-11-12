using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DuLich
{
    public partial class GUI_ChiTietTour : Form
    {
        DTO_Tour tour;
        public GUI_ChiTietTour()
        {
            InitializeComponent();
        }
        public GUI_ChiTietTour(DTO_Tour obj) : this()
        {
            tour = obj;
            lbTenTour.Text = tour.TenTour.Trim();
            lbDiemXuatPhat.Text = tour.DiemXuatPhat.Trim();
            lbDiemDenCuoi.Text = tour.DiemDenCuoi.Trim();
            lbDichVu.Text = tour.DichVu.Trim();
            lbNgayKhoiHanh.Text = tour.NgayKhoiHanh.Trim();
            lbThoiGIanTour.Text = tour.ThoiGianTour.Trim();
            lbGiaTour.Text = tour.GiaTour.ToString().Trim();
            rtxtLichTrinh.Text = tour.LichTrinh.Trim();
            picLinkAnh.Image = System.Drawing.Image.FromFile(tour.LinkAnh.ToString().Trim());
            picLinkAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_TrangChu giaodien = new GUI_TrangChu();
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnDatNgay_Click(object sender, EventArgs e)
        {
            GUI_DatTour giaodien = new GUI_DatTour(tour);
            this.Hide();
            giaodien.ShowDialog();
        }
    }
}
