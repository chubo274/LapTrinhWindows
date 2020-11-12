using System;
using System.Windows.Forms;
using DTO;

namespace DuLich
{
    public partial class GUI_GiaoDienChucNang : Form
    {
        DTO_TaiKhoan t = new DTO_TaiKhoan();
        public GUI_GiaoDienChucNang()
        {
            InitializeComponent();
        }
        public GUI_GiaoDienChucNang(DTO_TaiKhoan tk) :this()
        {
            t = tk;
            if(t.LoaiTaiKhoan.Equals("Staff"))
            {
                btnTaiKhoan.Enabled = false;
            } 
            else
                btnTaiKhoan.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GUI_DangNhap giaodien = new GUI_DangNhap();
            this.Hide();
            giaodien.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ADMIN_Tour giaodien = new GUI_ADMIN_Tour(t);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            GUI_ADMIN_ThongKe giaodien = new GUI_ADMIN_ThongKe(t);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            GUI_ADMIN_HoTroKhachHang giaodien = new GUI_ADMIN_HoTroKhachHang(t);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            GUI_ADMIN_TaiKhoan giaodien = new GUI_ADMIN_TaiKhoan(t);
            this.Hide();
            giaodien.ShowDialog();
        }
    }
}
