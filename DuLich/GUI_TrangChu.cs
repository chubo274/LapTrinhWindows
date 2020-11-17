using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;


namespace DuLich
{
    public partial class GUI_TrangChu : Form
    {
        BUS_TrangChu obj = new BUS_TrangChu();
        List<DTO_Tour> cu = new List<DTO_Tour>();
        List<DTO_Tour> moi = new List<DTO_Tour>();
        public GUI_TrangChu()
        {
            InitializeComponent();
            cu = obj.DanhSachTour();
            themnhieu(cu);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuGia = txtTuGia.Text.Trim();
            string denGia = txtDenGia.Text.Trim();
            string tuNgay = txtTuNgay.Text.Trim();
            string denNgay = txtDenNgay.Text.Trim();
            string khuVuc = cbKhuVuc.SelectedValue.ToString().Trim();

            bool ngay = cbNgayKhoiHanh.Checked;
            bool gia = cbKhoangGia.Checked;
            if (gia)
            {
                if(ngay)
                {
                    moi = obj.DanhSachTourdieukien("giatour between '" + tuGia + "' and '" + denGia + "' and ngaykhoihanh between '" + tuNgay + "' and '" + denNgay + "' and makhuvuc = '" + khuVuc + "' ");
                    if (moi.Count <= 0)
                    {
                        MessageBox.Show("Không có kết quả nào", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        xoapanel(cu);
                        themnhieu(moi);
                        cu = moi;
                    }
                }    
                else
                {
                    moi = obj.DanhSachTourdieukien("giatour between '" + tuGia + "' and '" + denGia + "' and makhuvuc = '" + khuVuc + "' ");
                    if (moi.Count <= 0)
                    {
                        MessageBox.Show("Không có kết quả nào", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        xoapanel(cu);
                        themnhieu(moi);
                        cu = moi;
                    }
                }
            }
            else
            {
                if (ngay)
                {
                    moi = obj.DanhSachTourdieukien("ngaykhoihanh between '" + tuNgay + "' and '" + denNgay + "' and ngaykhoihanh between '" + tuNgay + "' and '" + denNgay + "' and makhuvuc = '" + khuVuc + "' ");
                    if (moi.Count <= 0)
                    {
                        MessageBox.Show("Không có kết quả nào", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        xoapanel(cu);
                        themnhieu(moi);
                        cu = moi;
                    }
                }
                else
                {
                    moi = obj.DanhSachTourdieukien("makhuvuc = '" + khuVuc + "' ");
                    if (moi.Count <= 0)
                    {
                        MessageBox.Show("Không có kết quả nào", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        xoapanel(cu);
                        themnhieu(moi);
                        cu = moi;
                    }
                }
            }            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GUI_DangNhap giaodien = new GUI_DangNhap();
            this.Hide();
            giaodien.ShowDialog();
        }

        private void GUI_TrangChu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLichDataSet.khuvuc' table. You can move, or remove it, as needed.
            //this.khuvucTableAdapter.Fill(this.duLichDataSet.khuvuc);
            try
            {
                cbKhuVuc.DataSource = obj.LoadComboBox();
                cbKhuVuc.DisplayMember = "tenkhuvuc";
                cbKhuVuc.ValueMember = "makhuvuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }

        void themnhieu(List<DTO_Tour> danhsach)
        {
            int n = danhsach.Count;

            string[] picturebox = new string[n]; picturebox[0] = "pic0";

            string[] lbTenTour = new string[n]; lbTenTour[0] = "lbTenTour0";
            string[] lbthoigiantour = new string[n]; lbthoigiantour[0] = "lbthoigiantour0";
            string[] lbNgayKhoiHanh = new string[n]; lbNgayKhoiHanh[0] = "lbNgayKhoiHanh0";
            string[] lbGia = new string[n]; lbGia[0] = "lbGia0";

            string[] btnchitiet = new string[n]; btnchitiet[0] = "btnChiTiet0";
            string[] btndatngay = new string[n]; btndatngay[0] = "btnName0";
            int[] y = new int[n]; y[0] = 3;
            DTO_Tour tour0 = danhsach[0];

            them(picturebox[0], lbTenTour[0], lbthoigiantour[0], lbNgayKhoiHanh[0], lbGia[0], btnchitiet[0], btndatngay[0], 3, y[0], tour0);

            for (int i = 1; i < n; i++)
            {
                picturebox[i] = "pic" + i;
                lbTenTour[i] = "lbTenTour" + i;
                lbthoigiantour[i] = "lbthoigiantour" + i;
                lbNgayKhoiHanh[i] = "lbNgayKhoiHanh" + i;
                lbGia[i] = "lbGia" + i;
                btnchitiet[i] = "btnChiTiet" + i;
                btndatngay[i] = "btnName" + i;

                DTO_Tour tour = danhsach[i];

                if (i % 2 != 0)
                {
                    y[i] = y[i - 1];
                    them(picturebox[i], lbTenTour[i], lbthoigiantour[i], lbNgayKhoiHanh[i], lbGia[i], btnchitiet[i], btndatngay[i], 460, y[i], tour);
                }
                else
                {
                    y[i] = y[i - 1] + 193;
                    them(picturebox[i], lbTenTour[i], lbthoigiantour[i], lbNgayKhoiHanh[i], lbGia[i], btnchitiet[i], btndatngay[i], 3, y[i], tour);
                }
            }
        }
        void them(string picturebox, string lbTenTour, string lbthoigiantour, string lbNgayKhoiHanh, string lbGia, string btnchitiet, string btndatngay, int x, int y, DTO_Tour tour)
        {                        
            System.Windows.Forms.GroupBox groupBox = new GroupBox();
            System.Windows.Forms.PictureBox pic = new PictureBox();
            System.Windows.Forms.Label LabelGia = new Label();
            System.Windows.Forms.Label LabelNgayKhoiHanh = new Label();
            System.Windows.Forms.Label Labelthoigiantour = new Label();
            System.Windows.Forms.Label LabelTenTour = new Label();
            System.Windows.Forms.Button buttonchitiet = new Button();
            System.Windows.Forms.Button buttondatngay = new Button();
           
            this.panelDSTour.Controls.Add(groupBox);
            groupBox.Controls.Add(pic);
            groupBox.Controls.Add(LabelTenTour);
            groupBox.Controls.Add(Labelthoigiantour);
            groupBox.Controls.Add(LabelNgayKhoiHanh);
            groupBox.Controls.Add(LabelGia);
            groupBox.Controls.Add(buttonchitiet);
            groupBox.Controls.Add(buttondatngay);

            groupBox.Location = new System.Drawing.Point(x, y);
            groupBox.Size = new System.Drawing.Size(450, 187);

            pic.Location = new System.Drawing.Point(6, 13);
            pic.Name = picturebox;
            pic.Size = new System.Drawing.Size(211, 168);
            pic.Image = System.Drawing.Image.FromFile(tour.LinkAnh.Trim());
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            LabelTenTour.AutoSize = true;
            LabelTenTour.Location = new System.Drawing.Point(223, 18);
            LabelTenTour.Name = lbTenTour;
            LabelTenTour.Size = new System.Drawing.Size(53, 17);
            LabelTenTour.Text = tour.TenTour.Trim();

            Labelthoigiantour.AutoSize = true;
            Labelthoigiantour.Location = new System.Drawing.Point(223, 51);
            Labelthoigiantour.Name = lbthoigiantour;
            Labelthoigiantour.Size = new System.Drawing.Size(130, 17);
            Labelthoigiantour.Text = tour.ThoiGianTour.Trim();

            LabelNgayKhoiHanh.AutoSize = true;
            LabelNgayKhoiHanh.Location = new System.Drawing.Point(223, 84);
            LabelNgayKhoiHanh.Name = lbNgayKhoiHanh;
            LabelNgayKhoiHanh.Size = new System.Drawing.Size(109, 17);
            LabelNgayKhoiHanh.Text = "Ngày Khởi Hành: "+ tour.NgayKhoiHanh.Trim();

            LabelGia.AutoSize = true;
            LabelGia.Location = new System.Drawing.Point(223, 117);
            LabelGia.Name = lbGia;
            LabelGia.Size = new System.Drawing.Size(30, 17);
            LabelGia.Text = tour.GiaTour.ToString().Trim() + " / cho 1 vé";

            buttonchitiet.Location = new System.Drawing.Point(226, 143);
            buttonchitiet.Name = btnchitiet;
            buttonchitiet.Size = new System.Drawing.Size(75, 38);
            buttonchitiet.Text = "Chi Tiết";
            buttonchitiet.Click += Buttonchitiet_Click;

            buttondatngay.Location = new System.Drawing.Point(307, 143);
            buttondatngay.Name = btndatngay;
            buttondatngay.Size = new System.Drawing.Size(99, 38);
            buttondatngay.Text = "Đặt Ngay";
            buttondatngay.Click += Buttondatngay_Click;

            void Buttondatngay_Click(object sender, EventArgs e)
            {
                //buttondatngay = sender as Button;
                GUI_DatTour giaodien = new GUI_DatTour(tour);
                this.Hide();
                giaodien.ShowDialog();
            }

            void Buttonchitiet_Click(object sender, EventArgs e)
            {
                //buttonchitiet = sender as Button;
                GUI_ChiTietTour giaodien = new GUI_ChiTietTour(tour);
                this.Hide();
                giaodien.ShowDialog();
            }
        }
        void xoapanel(List<DTO_Tour> danhsach)
        {
            int n = danhsach.Count;
            for(int i=0;i<n;i++)
            {
                this.panelDSTour.Controls.RemoveAt(0);
            }
        }

        private void GUI_TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbKhoangGia.Checked)
            {
                txtTuGia.Enabled = true;
                txtDenGia.Enabled = true;
            }
            else
            {
                txtTuGia.Enabled = false;
                txtDenGia.Enabled = false;
            }
        }

        private void cbNgayKhoiHanh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNgayKhoiHanh.Checked)
            {
                txtTuNgay.Enabled = true;
                txtDenNgay.Enabled = true;
            }
            else
            {
                txtTuNgay.Enabled = false;
                txtDenNgay.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbNgayKhoiHanh.Checked = false;
            cbKhoangGia.Checked = false;
            xoapanel(cu);
            moi = obj.DanhSachTour();
            themnhieu(moi);
            cu = moi;
        }
    }
}
