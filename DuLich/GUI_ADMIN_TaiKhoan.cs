using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DuLich
{
    public partial class GUI_ADMIN_TaiKhoan : Form
    {
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        DTO_TaiKhoan obj = new DTO_TaiKhoan();
        DTO_TaiKhoan taik = new DTO_TaiKhoan();
        public GUI_ADMIN_TaiKhoan()
        {
            //InitializeComponent();
            //hienthi();
        }
        public GUI_ADMIN_TaiKhoan(DTO_TaiKhoan taikh) :this()
        {
            InitializeComponent();
            hienthi();
            taik = taikh;
        }
        void hienthi()
        {
            dgvTaiKhoan.DataSource = tk.GetTaiKhoan();
        }    

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_GiaoDienChucNang giaodien = new GUI_GiaoDienChucNang(taik);
            this.Hide();
            giaodien.ShowDialog();
        }
        void xoatxt()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cbLoaiTaiKhoan.Text = "";
            txtTim.Text = "";
        }
        bool checktrong()
        {
            if(txtTenTaiKhoan.Text.Equals("")|| txtMatKhau.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ các trường", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                obj.TenTaiKhoan = txtTenTaiKhoan.Text.Trim();
                obj.MatKhau = txtMatKhau.Text.Trim();
                obj.LoaiTaiKhoan = cbLoaiTaiKhoan.Text.Trim();
                return true;
            }
        }
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTaiKhoan.CurrentRow.Index;
            txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[index].Cells[0].Value.ToString().Trim();
            txtMatKhau.Text = dgvTaiKhoan.Rows[index].Cells[1].Value.ToString().Trim();
            cbLoaiTaiKhoan.Text = dgvTaiKhoan.Rows[index].Cells[2].Value.ToString().Trim();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable t = tk.LookupTaiKhoan(txtTim.Text);
            if (t.Rows.Count <= 0)
            {
                MessageBox.Show("Không có kết quả", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hienthi();
            }
            else
            {
                dgvTaiKhoan.DataSource = t;
                xoatxt();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable t = tk.LookupTaiKhoan(txtTenTaiKhoan.Text.Trim());
            if (checktrong())
            {
                if (t.Rows.Count > 0)
                {
                    MessageBox.Show("Trùng tên tài khoản", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tk.InsertTaiKhoan(obj);
                    MessageBox.Show("Thêm thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxt();
                    hienthi();
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable t = tk.LookupTaiKhoan(txtTenTaiKhoan.Text.Trim());
            if (checktrong())
            {
                if (t.Rows.Count <= 0)
                {
                    MessageBox.Show("Mã Không Tồn Tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tk.UpdateTaiKhoan(obj);
                    MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoatxt();
                    hienthi();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable t = tk.LookupTaiKhoan(txtTenTaiKhoan.Text.Trim());
            if (t.Rows.Count <= 0)
            {
                MessageBox.Show("Mã Không Tồn Tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tk.DeleteTaiKhoan(obj);
                MessageBox.Show("Xoá thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoatxt();
                hienthi();
            }
        }
    }
}
