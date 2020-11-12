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
    public partial class GUI_ADMIN_ThongKe : Form
    {
        BUS_ThongKe tk = new BUS_ThongKe();
        DTO_TaiKhoan tai = new DTO_TaiKhoan();
        DataTable t = new DataTable();

        public GUI_ADMIN_ThongKe()
        {
            //InitializeComponent();
            //hienthi();
        }
        public GUI_ADMIN_ThongKe(DTO_TaiKhoan tk) :this()
        {
            InitializeComponent();
            hienthi();
            tai = tk;
        }


        private void GUI_ADMIN_ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLichDataSet.tour' table. You can move, or remove it, as needed.
            this.tourTableAdapter.Fill(this.duLichDataSet.tour);

        }
        void hienthi()
        {
            DataTable tb = tk.GetTabler();
            int tongthu = 0;
            dgvThongKe.DataSource = tb;
            for(int i=0;i< tb.Rows.Count;i++)
            {
                tongthu = int.Parse(tb.Rows[i][8].ToString().Trim())+tongthu;
            }
            lbTongThu.Text = tongthu.ToString();
        }
        void timkothay()
        {
            hienthi();
            lbThongBao.Text = "Tổng từ tất cả tour đã được book:";
        }
        void timthay(DataTable timtable)
        {
            int tongthu = 0;
            for (int i = 0; i < timtable.Rows.Count; i++)
            {
                tongthu = int.Parse(dgvThongKe.Rows[i].Cells[8].Value.ToString().Trim()) + tongthu;
            }
            lbTongThu.Text = tongthu.ToString();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string maTour = cbTenTour.Text.Trim();
            string tuNgay = dtpTuNgay.Text.Trim();
            string denNgay = dtpDenNgay.Text.Trim();            
            if (ckbNgay.Checked)
            {
                t = tk.LookUp2dieukien(maTour, tuNgay, denNgay);
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Tour mã '" + maTour + "' chưa từng được book từ '" + tuNgay + "' đến '" + denNgay + "'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timkothay();
                }
                else
                {
                    lbThongBao.Text = "Tổng thu Tour mã '" + maTour + "' từng được book từ '" + tuNgay + "' đến '" + denNgay + "' là:";
                    dgvThongKe.DataSource = t;
                    timthay(t);
                }
            }
            else
            {
                t = tk.LookUpma(cbTenTour.Text.Trim());
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Tour mã '" + maTour + "' chưa từng được book từ trước đến nay", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timkothay();
                }
                else
                {
                    lbThongBao.Text = "Tổng thu Tour mã '" + maTour + "' từ trước đến nay là:";
                    dgvThongKe.DataSource = t;
                    timthay(t);
                }    

            }
            
        }

        private void ckbNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbNgay.Checked)
            {
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
            else
            {
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_GiaoDienChucNang giaodien = new GUI_GiaoDienChucNang(tai);
            this.Hide();
            giaodien.ShowDialog();
        }

        /*
        DataTable dinhdanglaicotngay(DataGridView d)
        {
            DataTable ex = (DataTable)dgvThongKe.DataSource;
            for (int i = 0; i < ex.Rows.Count; i++)
            {
                dtp.Text = dgvThongKe.Rows[i].Cells[4].Value.ToString().Trim();
                ex.Rows[i][4] = dtp.Value.ToString("dd/MMM/yy");
            }
            return ex;
        }
        */
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xuất thống kê này ra file excel không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(lbThongBao.Text.Trim().Equals("Tổng từ tất cả tour đã được book:"))
                {
                    tk.Export((DataTable)dgvThongKe.DataSource, "Thống kê doanh thu", "Thống kê doanh thu từ trước đến nay của tất cả tour từng được book", int.Parse(lbTongThu.Text));
                    MessageBox.Show("Xuất file thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tk.Export((DataTable)dgvThongKe.DataSource, "Thống kê doanh thu", lbThongBao.Text.Trim(),int.Parse(lbTongThu.Text));
                    MessageBox.Show("Xuất file thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
