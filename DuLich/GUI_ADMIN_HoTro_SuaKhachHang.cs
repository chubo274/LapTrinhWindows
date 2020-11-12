using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DuLich
{
    public partial class GUI_ADMIN_HoTro_SuaKhachHang : Form
    {
        DTO_KhachHang kh = new DTO_KhachHang();
        DTO_Booked bk = new DTO_Booked();
        BUS_HoTroKhachHang sup = new BUS_HoTroKhachHang();
        DTO_TaiKhoan tk = new DTO_TaiKhoan();
        public GUI_ADMIN_HoTro_SuaKhachHang()
        {
            //InitializeComponent();
        }
        public GUI_ADMIN_HoTro_SuaKhachHang(DTO_KhachHang k,DTO_Booked b ,DTO_TaiKhoan taiKhoan):this()
        {
            InitializeComponent();
            kh = k;
            bk = b;
            txtTenKhachHang.Text = kh.TenKhachHang;
            dtpNgaySinh.Text = kh.NgaySinh;
            if (kh.GioiTinh.ToString().Equals("Nam"))
            {
                rdbNam.Checked = true;
            }
            else
                rdbNu.Checked = true;
            txtSoDienThoai.Text = kh.SoDienThoai;
            txtGmail.Text = kh.Gmail;
            txtDiaChi.Text = kh.DiaChi;
            tk = taiKhoan;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_ADMIN_HoTroKhachHang giaodien = new GUI_ADMIN_HoTroKhachHang(tk);
            this.Hide();
            giaodien.ShowDialog();
        }
        void laythongtinsuakhachhang()
        {
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.NgaySinh = dtpNgaySinh.Text.Trim();
            if (rdbNam.Checked)
            {
                kh.GioiTinh = "Nam";
            }
            else
                kh.GioiTinh = "Nữ";
            kh.SoDienThoai = txtSoDienThoai.Text.Trim();
            kh.Gmail = txtGmail.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
        }
        bool checktrong()
        {
            if (txtTenKhachHang.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sup.checkso(txtTenKhachHang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng trường tên khách hàng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dtpNgaySinh.Text.Equals(DateTime.Now.ToString("dd/MMM/yy").Trim()))
            {
                MessageBox.Show("Vui lòng nhập ngày sinh", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtSoDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!sup.checkso(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại: Tức toàn chữ số và ít hơn 12 chữ số", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiaChi.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnSuaKhach_Click(object sender, EventArgs e)
        {
            if(checktrong()&&checklenghth())
            {
                DataTable tb = sup.Lookupbookedtheoma(bk, kh);
                if (tb.Rows.Count <= 0)
                {
                    MessageBox.Show("Mã khách cần huỷ không tồn tại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    laythongtinsuakhachhang();
                    if (MessageBox.Show("Bạn có chắc chắn muốn sửa lại thông tin khách hàng có mã: " + kh.MaKhachHang + " không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sup.UpdateKhachHang(kh);
                        MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }    
            
        }
    }
}
