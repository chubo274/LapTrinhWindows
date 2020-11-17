using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DuLich
{
    public partial class GUI_DatTour : Form
    {
        DTO_Tour tour;
        BUS_DatTour dattour = new BUS_DatTour();
        int tongtien = 0;
        public GUI_DatTour()
        {
            InitializeComponent();
        }

        public GUI_DatTour(DTO_Tour obj) : this()
        {
            tour = obj;
            lbTenTour.Text = tour.TenTour.Trim();
            lbDiemXuatPhat.Text = tour.DiemXuatPhat.Trim();
            lbDiemDenCuoi.Text = tour.DiemDenCuoi.Trim();
            lbDichVu.Text = tour.DichVu.Trim();
            lbNgayKhoiHanh.Text = tour.NgayKhoiHanh.Trim();
            lbThoiGIanTour.Text = tour.ThoiGianTour.Trim();
            lbGiaTour.Text = tour.GiaTour.ToString().Trim();
            piclinkAnh.Image = System.Drawing.Image.FromFile(tour.LinkAnh.ToString().Trim());
            piclinkAnh.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = "";
            dtpNgaySinh.Text = "";
            txtSoDienThoai.Text = "";
            txtGmail.Text = "";
            txtDiaChi.Text = "";
            numNguoiLon.Value = 0;
            numTreEm.Value = 0;
            lbTongTien.Text = "";
        }
        bool checktrong()
        {
            if (txtTenKhachHang.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dattour.checkso(txtTenKhachHang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng trường tên khách hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpNgaySinh.Text.Equals(DateTime.Now.ToShortDateString()) || DateTime.Compare(dtpNgaySinh.Value,DateTime.Now)>0)
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtSoDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!dattour.checkso(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại: Tức toàn chữ số và ít hơn 12 chữ số", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numNguoiLon.Value == 0 && numTreEm.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số vé bạn muốn đặt!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        bool checklenghth()
        {
            if (txtTenKhachHang.Text.Trim().Length > 30)
            {
                MessageBox.Show("Tên khách hàng không thể nhập quá 30 ký tự", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtGmail.Text.Trim().Length > 50)
            {
                MessageBox.Show("Địa chỉ Gmail không thể nhập quá 50 ký tự", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiaChi.Text.Trim().Length > 200)
            {
                MessageBox.Show("Địa chỉ không thể nhập quá 200 ký tự", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (checktrong() && checklenghth())
            {
                tongtien = dattour.tongtien(int.Parse(lbGiaTour.Text), numNguoiLon.Value, numTreEm.Value);
                if (MessageBox.Show("Bạn có chắc chắn muốn đăng tour này với tổng chi phí là: " + tongtien + " không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string makhachhang = dtpNgaySinh.Text.Trim() + "_" + txtSoDienThoai.Text.Trim();
                    DTO_KhachHang khachhang = new DTO_KhachHang();
                    khachhang.MaKhachHang = makhachhang.Trim() + "_0";
                    khachhang.TenKhachHang = txtTenKhachHang.Text.Trim();
                    khachhang.NgaySinh = dtpNgaySinh.Text.Trim();
                    if (rdbNam.Checked)
                    {
                        khachhang.GioiTinh = "Nam";
                    }
                    else khachhang.GioiTinh = "Nữ";
                    khachhang.SoDienThoai = txtSoDienThoai.Text.Trim();
                    khachhang.Gmail = txtGmail.Text.Trim();
                    khachhang.DiaChi = txtDiaChi.Text.Trim();

                    string mabooked = tour.MaTour.Trim() + "_" + khachhang.MaKhachHang.Trim();
                    DTO_Booked booked = new DTO_Booked();
                    booked.MaBooked = mabooked.Trim() + "_0";
                    booked.MaTour = tour.MaTour.Trim();
                    booked.NgayDatTour = DateTime.Now.ToString("dd/MMM/yy").Trim();
                    booked.NgayKhoiHanh = tour.NgayKhoiHanh.Trim();
                    booked.SoNguoiLon = int.Parse(numNguoiLon.Value.ToString());
                    booked.SoTreEm = int.Parse(numTreEm.Value.ToString());
                    booked.TongTien = tongtien;


                    DataTable table2 = dattour.checkmaKhachHang(makhachhang.Trim());
                    int rows = table2.Rows.Count;
                    if (rows <= 0)
                    {
                        booked.MaKhachHang = khachhang.MaKhachHang;
                        dattour.InsertKhachHang(khachhang);
                        dattour.InsertBooked(booked);
                    }
                    else
                    {
                        DataTable table1 = dattour.checkKhachHang(khachhang);
                        if (table1.Rows.Count <= 0)
                        {
                            int length1 = makhachhang.Trim().Length;
                            //int length2 = table2.Rows[rows][0].ToString().Trim().Length;
                            int num = int.Parse(table2.Rows[rows - 1][0].ToString().Trim().Substring(length1 + 1));
                            num++;
                            if (num < 99999)
                            {
                                khachhang.MaKhachHang = makhachhang + "_" + num;
                                booked.MaKhachHang = khachhang.MaKhachHang;
                                booked.MaBooked = tour.MaTour.Trim() + "_" + booked.MaKhachHang.Trim() + "_0";
                                dattour.InsertKhachHang(khachhang);
                                dattour.InsertBooked(booked);
                            }
                            else
                            {
                                MessageBox.Show("Phát hiện spam!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            booked.MaKhachHang = table1.Rows[0][0].ToString().Trim();
                            string mabookeddaco = tour.MaTour.Trim() + "_" + booked.MaKhachHang.Trim();
                            DataTable table3 = dattour.checkmabooked(mabookeddaco.Trim());
                            int rows2 = table3.Rows.Count;
                            if(rows2<=0)
                            {
                                booked.MaBooked = tour.MaTour.Trim() + "_" + booked.MaKhachHang.Trim() + "_0";
                                dattour.InsertBooked(booked);
                            }
                            else
                            {
                                int length2 = mabooked.Trim().Length;
                                int num2 = int.Parse(table3.Rows[rows2 - 1][0].ToString().Trim().Substring(length2 + 1));
                                num2++;
                                if (num2 < 99999)
                                {
                                    booked.MaBooked = tour.MaTour.Trim() + "_" + booked.MaKhachHang.Trim() + "_" + num2;
                                    dattour.InsertBooked(booked);
                                }
                                else
                                {
                                    MessageBox.Show("Phát hiện spam!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }                            
                        }
                    }

                    MessageBox.Show("Đặt thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_TrangChu giaodien = new GUI_TrangChu();
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            GUI_ChiTietTour giaodien = new GUI_ChiTietTour(tour);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void numNguoiLon_ValueChanged(object sender, EventArgs e)
        {
            tongtien = dattour.tongtien(int.Parse(tour.GiaTour.ToString()), numNguoiLon.Value, numTreEm.Value);
            lbTongTien.Text = tongtien.ToString();
        }

        private void numTreEm_ValueChanged(object sender, EventArgs e)
        {
            tongtien = dattour.tongtien(int.Parse(tour.GiaTour.ToString()), numNguoiLon.Value, numTreEm.Value);
            lbTongTien.Text = tongtien.ToString();
        }
    }
}
