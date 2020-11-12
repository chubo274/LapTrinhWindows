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
    public partial class GUI_ADMIN_HoTro_SuaBook : Form
    {
        DTO_Tour tr = new DTO_Tour();
        DTO_KhachHang kh = new DTO_KhachHang();
        DTO_Booked bk = new DTO_Booked();
        BUS_HoTroKhachHang sup = new BUS_HoTroKhachHang();
        DTO_TaiKhoan nhantaikhoan = new DTO_TaiKhoan();
        public GUI_ADMIN_HoTro_SuaBook()
        {
            //InitializeComponent();
        }
        public GUI_ADMIN_HoTro_SuaBook(DTO_Booked b, DTO_Tour t, DTO_KhachHang k,DTO_TaiKhoan taikhoan):this()
        {
            InitializeComponent();
            bk = b;
            tr = t;
            kh = k;
            nhantaikhoan = taikhoan;
            lbNgayHomNay.Text = DateTime.Now.ToString("dd/MMM/yy").Trim();
            laydata();
        }
        void laydata()
        {
            lb.Text = tr.TenTour.Trim();
            lbNgayDat.Text = bk.NgayDatTour;
            lbNgayKhoiHanh.Text = bk.NgayKhoiHanh;
            numNguoiLon.Value = int.Parse(bk.SoNguoiLon.ToString().Trim());
            numTreEm.Value = int.Parse(bk.SoTreEm.ToString().Trim());
            lbGiaTour.Text = tr.GiaTour.ToString();
            lbTongTien.Text = sup.tongtien(int.Parse(tr.GiaTour.ToString()), int.Parse(numNguoiLon.Value.ToString()), int.Parse(numTreEm.Value.ToString())).ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            quaylai();
        }
        void quaylai ()
        {
            GUI_ADMIN_HoTroKhachHang giaodien = new GUI_ADMIN_HoTroKhachHang(nhantaikhoan);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void btnSuaBook_Click(object sender, EventArgs e)
        {
            DataTable tb = sup.Lookupbookedtheoma(bk, kh);
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Mã tour cần sửa không tồn tại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bk.SoNguoiLon = int.Parse(numNguoiLon.Value.ToString().Trim());
                bk.SoTreEm = int.Parse(numTreEm.Value.ToString().Trim());
                bk.TongTien = int.Parse(lbTongTien.Text.Trim());

                if (bk.SoNguoiLon == 0 && bk.SoTreEm == 0)
                {
                    MessageBox.Show("Vui lònng chỉnh số lượng vé người lớn, trẻ nhỏ để phát sinh cước trước khi sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn sửa lại số vé người lớn = " + bk.SoNguoiLon + " và trẻ em = " + bk.SoTreEm + " của tourbooked có mã " + bk.MaBooked + " không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sup.updateBooked(bk);
                        MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //quaylai();
                    }
                }
            }    
            
        }

        private void btnHuyTour_Click(object sender, EventArgs e)
        {
            DataTable tb = sup.Lookupbookedtheoma(bk, kh);
            if(tb.Rows.Count<=0)
            {
                MessageBox.Show("Mã tour cần huỷ không tồn tại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (MessageBox.Show("Bạn có chắc chắn muốn huỷ tourbooked có mã: " + bk.MaBooked + " và sẽ xoá thông tin khách hàng có mã: " + bk.MaKhachHang + " nếu đây là đơn book đầu tiên của họ không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tb.Rows.Count == 1)
                {
                    sup.DeleteBooked(bk);
                    sup.DeleteKhachHang(bk);
                    MessageBox.Show("Huỷ tour thành công và xoá '"+ tb.Rows.Count + "' khách hàng!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    sup.DeleteBooked(bk);
                    MessageBox.Show("Huỷ tour thành công và không xoá khách hàng nào!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void numNguoiLon_ValueChanged(object sender, EventArgs e)
        {
            lbTongTien.Text = sup.tongtien(int.Parse(tr.GiaTour.ToString()), int.Parse(numNguoiLon.Value.ToString()), int.Parse(numTreEm.Value.ToString())).ToString();
        }

        private void numTreEm_ValueChanged(object sender, EventArgs e)
        {
            lbTongTien.Text = sup.tongtien(int.Parse(tr.GiaTour.ToString()), int.Parse(numNguoiLon.Value.ToString()), int.Parse(numTreEm.Value.ToString())).ToString();
        }
    }
}
