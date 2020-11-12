using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DuLich
{
    public partial class GUI_DangNhap : Form
    {
        BUS_DangNhap ob;
        public GUI_DangNhap()
        {
            InitializeComponent();
            ob = new BUS_DangNhap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            GUI_TrangChu giaodien = new GUI_TrangChu();
            this.Hide();
            giaodien.ShowDialog();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (tenTaiKhoan.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (matKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DTO_TaiKhoan item = ob.LayTaiKhoan(tenTaiKhoan, matKhau);

            if(item != null)
            {
                GUI_GiaoDienChucNang giaodien = new GUI_GiaoDienChucNang(item);
                this.Hide();
                giaodien.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }
    }
}
