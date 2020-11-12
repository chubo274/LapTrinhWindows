using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DuLich
{
    public partial class GUI_ADMIN_HoTroKhachHang : Form
    {
        BUS_HoTroKhachHang sup = new BUS_HoTroKhachHang();
        DTO_KhachHang kh = new DTO_KhachHang();
        DTO_Tour tr = new DTO_Tour();
        DTO_TaiKhoan taik = new DTO_TaiKhoan();
        DTO_Booked bk = new DTO_Booked();
        public GUI_ADMIN_HoTroKhachHang()
        {
            //InitializeComponent();
            //hienthi();
            //dtpNgayHomNay.Text = DateTime.Now.ToString("dd/MMM/yy").Trim();
        }

        public GUI_ADMIN_HoTroKhachHang(DTO_TaiKhoan tk) : this()
        {
            InitializeComponent();
            hienthi();
            lbNgayHomNay.Text = DateTime.Now.ToString("dd/MMM/yy").Trim();
            taik = tk;
            xoatxtbook();
            xoatxtkhach();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_GiaoDienChucNang giaodien = new GUI_GiaoDienChucNang(taik);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index1 = dgvBook.CurrentRow.Index;
            txtTenTour.Text = dgvBook.Rows[index1].Cells[2].Value.ToString().Trim();
            dtpNgayDat.Text = dgvBook.Rows[index1].Cells[4].Value.ToString().Trim();
            lbNgayKhoiHanh.Text = dgvBook.Rows[index1].Cells[5].Value.ToString().Trim();
            string[] ngaykh = lbNgayKhoiHanh.Text.Trim().Split(' ');
            lbNgayKhoiHanh.Text = ngaykh[0].Trim();
            lbSoNguoiLon.Text = dgvBook.Rows[index1].Cells[6].Value.ToString().Trim();
            lbSoTreEm.Text = dgvBook.Rows[index1].Cells[7].Value.ToString().Trim();
            lbGiaTour.Text = dgvBook.Rows[index1].Cells[8].Value.ToString().Trim();
            if(!lbGiaTour.Text.Trim().Equals("______________________")|| !lbGiaTour.Text.Trim().Equals(""))
            {
                lbTongTien.Text = sup.tongtien(int.Parse(lbGiaTour.Text), int.Parse(lbSoNguoiLon.Text), int.Parse(lbSoTreEm.Text)).ToString(); ;
            }

            bk.MaBooked = dgvBook.Rows[index1].Cells[0].Value.ToString().Trim();
            bk.MaTour = dgvBook.Rows[index1].Cells[1].Value.ToString().Trim();
            bk.MaKhachHang = dgvBook.Rows[index1].Cells[3].Value.ToString().Trim();
            bk.NgayDatTour = dtpNgayDat.Value.ToString("dd/MMM/yy");
            bk.NgayKhoiHanh = dgvBook.Rows[index1].Cells[5].Value.ToString().Trim();
            if(dgvBook.Rows[index1].Cells[6].Value.ToString().Trim().Equals(""))
            {
                bk.SoNguoiLon = 0;
            }    
            else
            bk.SoNguoiLon = int.Parse(dgvBook.Rows[index1].Cells[6].Value.ToString().Trim());
            if (dgvBook.Rows[index1].Cells[7].Value.ToString().Trim().Equals(""))
            {
                bk.SoTreEm = 0;
            }
            else
                bk.SoTreEm = int.Parse(dgvBook.Rows[index1].Cells[7].Value.ToString().Trim());
            bk.TongTien = int.Parse(lbTongTien.Text.Trim());

            tr.TenTour = dgvBook.Rows[index1].Cells[2].Value.ToString().Trim();
            if (dgvBook.Rows[index1].Cells[8].Value.ToString().Trim().Equals(""))
            {
                tr.GiaTour = 0;
            }
            else
            tr.GiaTour = int.Parse(dgvBook.Rows[index1].Cells[8].Value.ToString().Trim());
            dgvKhach.DataSource = sup.Lookupkhachhangtheoma(bk,kh);
            btnSuaBook.Enabled = true;
            btnHuyTour.Enabled = true;
            kh.MaKhachHang = "";
            btnSuaKhach.Enabled = false;
            xoatxtkhach();
        }


        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index2 = dgvKhach.CurrentRow.Index;
            lbTenKhachHang.Text = dgvKhach.Rows[index2].Cells[1].Value.ToString().Trim();
            lbNgaySinh.Text = dgvKhach.Rows[index2].Cells[2].Value.ToString().Trim();
            string[] ng = lbNgaySinh.Text.Trim().Split(' ');
            lbNgaySinh.Text = ng[0].Trim();
            if (dgvKhach.Rows[index2].Cells[3].Value.ToString().Trim().Equals("Nam"))
            {
                rdbNam.Checked = true;
            }
            else
                rdbNu.Checked = true;
            lbSoDienThoai.Text = dgvKhach.Rows[index2].Cells[4].Value.ToString().Trim();
            lbGmail.Text = dgvKhach.Rows[index2].Cells[5].Value.ToString().Trim();
            lbDiaChi.Text = dgvKhach.Rows[index2].Cells[6].Value.ToString().Trim();

            kh.MaKhachHang = dgvKhach.Rows[index2].Cells[0].Value.ToString().Trim();
            laythongtinsuakhachhang();

            dgvBook.DataSource = sup.Lookupbookedtheoma(bk, kh);
            btnSuaKhach.Enabled = true;
            bk.MaBooked = "";
            bk.MaKhachHang = "";
            btnSuaBook.Enabled = false;
            btnHuyTour.Enabled = false;
            xoatxtbook();
        }
        void laythongtinsuakhachhang()
        {
            kh.TenKhachHang = lbTenKhachHang.Text.Trim();
            kh.NgaySinh = lbNgaySinh.Text.Trim();    
            if (rdbNam.Checked)
            {
                kh.GioiTinh = "Nam";
            }    
            else
                kh.GioiTinh = "Nữ";
            kh.SoDienThoai = lbSoDienThoai.Text.Trim();
            kh.Gmail = lbGmail.Text.Trim();
            kh.DiaChi = lbDiaChi.Text.Trim();
        }
        void xoatxtbook()
        {
            lbNgayKhoiHanh.Text = "______________________";
            dtpNgayDat.Text = "";
            txtTenTour.Text = "";
            lbSoNguoiLon.Text = "______________________";
            lbSoTreEm.Text = "______________________";
            lbGiaTour.Text = "______________________";
            lbTongTien.Text = "______________________";         

        }
        void xoatxtkhach()
        {
            rdbNam.Checked = true;
            lbTenKhachHang.Text = "";
            lbSoDienThoai.Text = "";
            lbGmail.Text = "______________________";
            lbDiaChi.Text = "______________________";
            lbNgaySinh.Text = "______________________";
        }
        void hienthi()
        {

            dgvBook.DataSource = sup.getTablebook();
            dgvKhach.DataSource = sup.getTableKhachHang();
        }
        bool checkngaycothesua()
        {
            DateTimePicker date1 = new DateTimePicker();
            date1.Text = lbNgayKhoiHanh.Text.Trim();
            return DateTime.Compare(date1.Value, DateTime.Now) >0;
        }

        private void bnTim_Click(object sender, EventArgs e)
        {
            if (txtTenTour.Text.Equals(""))
            {
                DataTable t = new DataTable();
                t = sup.Lookupbooked("", dtpNgayDat.Text);
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Không có kết quả cho bất kỳ tour nào từ trước giờ đến ngày: " + dtpNgayDat.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvBook.DataSource = t;
                    //dgvKhach.DataSource = sup.Lookupkhachhangtheoma(bk, kh);
                    //string ten = dgvKhach.Rows[0].Cells[1].Value.ToString().Trim();
                    //MessageBox.Show("Kết quả của 2 bảng tương ứng với các tour được book và thông tin khách hàng có mã " + ten, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxtbook();
                    xoatxtkhach();
                }
            }
            else
            {
                DataTable t = new DataTable();
                t = sup.Lookupbooked(txtTenTour.Text.Trim(), dtpNgayDat.Text);
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Không có kết quả cho tên Tour: " + txtTenTour.Text.Trim() + " từ trước giờ đến ngày: " + dtpNgayDat.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvBook.DataSource = t;
                    //dgvKhach.DataSource = sup.Lookupkhachhangtheoma(bk,kh);
                    //string ten = dgvKhach.Rows[0].Cells[1].Value.ToString().Trim();
                    //MessageBox.Show("Kết quả của 2 bảng tương ứng với các tour được book và thông tin khách hàng có mã " + ten, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxtbook();
                    xoatxtkhach();

                }
            }
        }

        private void btnSuaBook_Click(object sender, EventArgs e)
        {
            if(checkngaycothesua())
            {
                kh.MaKhachHang = bk.MaKhachHang;
                GUI_ADMIN_HoTro_SuaBook giaodien = new GUI_ADMIN_HoTro_SuaBook(bk, tr, kh,taik);
                this.Hide();
                giaodien.ShowDialog();
            }    
            else
            {
                MessageBox.Show("Hệ thống không hỗ trợ vì Đã đến hoặc quá ngày khởi hành của tour này", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienLai_Click(object sender, EventArgs e)
        {
            hienthi();
            xoatxtbook();
            xoatxtkhach();
        }

        private void btnTimKhach_Click(object sender, EventArgs e)
        {
            if (lbTenKhachHang.Text.Equals("") && lbSoDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên Khách hoặc Số điện thoại trước khi tìm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable t = new DataTable();
                t = sup.Lookupkhachhang(kh);
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Không có kết quả cho tên Khách: " + lbTenKhachHang.Text + "với số điện thoại: " + lbSoDienThoai.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvKhach.DataSource = t;
                    //dgvBook.DataSource = sup.Lookupbookedtheoma(bk,kh);
                    //string ten = dgvKhach.Rows[0].Cells[1].Value.ToString().Trim();
                    //MessageBox.Show("Kết quả của 2 bảng tương ứng với các tour được book và thông tin khách hàng có mã " + ten, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxtbook();
                    xoatxtkhach();
                }
            }
        }

        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            bk.MaKhachHang = kh.MaKhachHang;
            GUI_ADMIN_HoTro_SuaKhachHang giaodien = new GUI_ADMIN_HoTro_SuaKhachHang(kh,bk,taik);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnHuyTour_Click(object sender, EventArgs e)
        {
            if (checkngaycothesua())
            {
                GUI_ADMIN_HoTro_SuaBook giaodien = new GUI_ADMIN_HoTro_SuaBook(bk, tr, kh, taik);
                this.Hide();
                giaodien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hệ thống không hỗ trợ vì Đã đến hoặc quá ngày khởi hành của tour này", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
