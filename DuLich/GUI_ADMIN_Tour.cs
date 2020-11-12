using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using BUS;

namespace DuLich
{
    public partial class GUI_ADMIN_Tour : Form
    {
        BUS_Tour tour = new BUS_Tour();
        BUS_HoTroKhachHang sup = new BUS_HoTroKhachHang();
        DTO_Tour obj = new DTO_Tour();
        DTO_Booked bk = new DTO_Booked();
        DTO_KhachHang kh = new DTO_KhachHang();
        DTO_TaiKhoan t = new DTO_TaiKhoan();
        OpenFileDialog open = new OpenFileDialog();
        public GUI_ADMIN_Tour()
        {
            //InitializeComponent();
            //hienthi();
        }
        public GUI_ADMIN_Tour(DTO_TaiKhoan tk):this()
        {
            InitializeComponent();
            hienthi();
            t = tk;
        }
        void hienthi()
        {
            dgvTour.DataSource = tour.GetTableTour();
        }

        private void GUI_ADMIN_Tour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLichDataSet.khuvuc' table. You can move, or remove it, as needed.
            this.khuvucTableAdapter.Fill(this.duLichDataSet.khuvuc);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GUI_GiaoDienChucNang giaodien = new GUI_GiaoDienChucNang(t);
            this.Hide();
            giaodien.ShowDialog();
        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvTour.CurrentRow.Index;
            txtMaTour.Text = dgvTour.Rows[index].Cells[0].Value.ToString().Trim();
            cbKhuVuc.Text = dgvTour.Rows[index].Cells[1].Value.ToString().Trim();
            txtTenTour.Text = dgvTour.Rows[index].Cells[2].Value.ToString().Trim();
            txtDiemXuatPhat.Text = dgvTour.Rows[index].Cells[3].Value.ToString().Trim();
            txtDiemDenCuoi.Text = dgvTour.Rows[index].Cells[4].Value.ToString().Trim();
            txtDichVu.Text = dgvTour.Rows[index].Cells[5].Value.ToString().Trim();
            dtpNgayKhoiHanh.Text = dgvTour.Rows[index].Cells[6].Value.ToString().Trim();
            txtThoiGianTour.Text = dgvTour.Rows[index].Cells[7].Value.ToString().Trim();
            txtGiaTour.Text = dgvTour.Rows[index].Cells[8].Value.ToString().Trim();
            txtLinkAnh.Text = dgvTour.Rows[index].Cells[9].Value.ToString().Trim();
            rtextLichTrinh.Text = dgvTour.Rows[index].Cells[10].Value.ToString().Trim();
            picAnh.Visible = true;
            picAnh.Image = Image.FromFile(txtLinkAnh.Text.Trim());
        }
        void xoatxt()
        {
            txtMaTour.Text = "";
            cbKhuVuc.Text = "";
            txtTenTour.Text = "";
            txtDiemXuatPhat.Text = "";
            txtDiemDenCuoi.Text = "";
            txtDichVu.Text = "";
            dtpNgayKhoiHanh.Text = "";
            txtThoiGianTour.Text = "";
            txtGiaTour.Text = "";
            txtLinkAnh.Text = "";
            rtextLichTrinh.Text = "";
            picAnh.Visible = false;
        }
        bool checktrong()
        {
            if (txtMaTour.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Mã Tour!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cbKhuVuc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn giá trị trường Khu vực!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtTenTour.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Tên Tour!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiemXuatPhat.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Điểm xuất phát!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiemDenCuoi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Điểm đến cuối!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDichVu.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Dịch vụ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtThoiGianTour.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Thời gian Tour!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtGiaTour.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền thông tin vào trường Giá Tour!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!tour.checkso(txtGiaTour.Text))
            {
                MessageBox.Show("Giá tour phải là số!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.Parse(txtGiaTour.Text) < 0)
            {
                MessageBox.Show("Giá tour phải dương!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                obj = new DTO_Tour();
                obj.MaTour = txtMaTour.Text;
                obj.MaKhuVuc = cbKhuVuc.SelectedValue.ToString().Trim();
                obj.TenTour = txtTenTour.Text;
                obj.DiemXuatPhat = txtDiemXuatPhat.Text;
                obj.DiemDenCuoi = txtDiemDenCuoi.Text;
                obj.DichVu = txtDichVu.Text;
                obj.NgayKhoiHanh = dtpNgayKhoiHanh.Text;
                obj.ThoiGianTour = txtThoiGianTour.Text;
                obj.GiaTour = int.Parse(txtGiaTour.Text);
                obj.LinkAnh = txtLinkAnh.Text;
                obj.LichTrinh = rtextLichTrinh.Text;
                return true;
            }
        }
        bool checklength()
        {
            if(txtMaTour.Text.Trim().Length>10)
            {
                MessageBox.Show("Trường thông tin Mã tour quá dài, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtTenTour.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Tên tour quá dài, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiemXuatPhat.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Điểm xuất phát có độ dài quá mức, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDiemDenCuoi.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Điểm đến cuối có độ dài quá mức, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtDichVu.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Dịch vụ có độ dài quá mức, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtThoiGianTour.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Thời gian tour có độ dài quá mức, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtGiaTour.Text.Trim().Length > 50)
            {
                MessageBox.Show("Trường thông tin Thời gian tour có độ dài quá mức, vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checktrong() && checklength())
            {
                if (!checkngaycothesua())
                {
                    MessageBox.Show("Ngày khởi hành không thể là ngày trước ngày hiện tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (MessageBox.Show("Bạn có chắc chắn thêm tour này và hiện trên trang chủ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tour.checkmaTour(obj))
                    {
                        MessageBox.Show("Trùng mã tour!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        obj.LinkAnh = saveFiles(open);
                        if (tour.InsertTour(obj))
                        {
                            MessageBox.Show("Thêm thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            xoatxt();
                        }
                    }
                }
                    
            }
        }
        bool checkngaycothesua()
        {
            return DateTime.Compare(dtpNgayKhoiHanh.Value, DateTime.Now) > 0;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checktrong() && checklength())
            {
                if(!checkngaycothesua())
                {
                    MessageBox.Show("Ngày khởi hành không thể là ngày trước ngày hiện tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (MessageBox.Show("Bạn có chắc chắn sửa tour này, đồng thời cập nhật thông tin và giá cả cho lịch sử booked của tour này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tour.checkmaTour(obj))
                    {
                        obj.LinkAnh = saveFiles(open);
                        bk.MaTour = obj.MaTour;
                        DataTable tb = tour.Lookupkhachhangtheoma(bk);
                        bk.NgayKhoiHanh = obj.NgayKhoiHanh;
                        if (tb.Rows.Count > 1)
                        {
                            for (int i = 0; i < tb.Rows.Count; i++)
                            {
                                bk.MaBooked = tb.Rows[i][1].ToString();
                                bk.SoNguoiLon = int.Parse(tb.Rows[i][3].ToString());
                                bk.SoTreEm = int.Parse(tb.Rows[i][4].ToString());
                                int giaTour = obj.GiaTour;
                                bk.TongTien = (giaTour*bk.SoNguoiLon + (giaTour/2) * bk.SoTreEm);
                                sup.updateBooked(bk);
                            }
                            if (tour.UpdateTour(obj))
                            {
                                MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                hienthi();
                                xoatxt();
                            }
                        }
                        else if (tb.Rows.Count == 1)
                        {
                            bk.MaBooked = tb.Rows[0][1].ToString();
                            sup.updateBooked(bk);
                            if (tour.UpdateTour(obj))
                            {
                                MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                hienthi();
                                xoatxt();
                            }
                        }
                        else
                        if (tour.UpdateTour(obj))
                        {
                            MessageBox.Show("Sửa thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            xoatxt();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã cần sửa không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }                       

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá vĩnh viễn tour này, đồng thời cũng sẽ xoá lịch sử booked của tour và thông tin người dùng nếu đó là lần đặt hàng đầu tiên của họ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tour.checkmaTour(obj))
                {
                    bk.MaTour = obj.MaTour;
                    DataTable tb = tour.Lookupkhachhangtheoma(bk);
                    if (tb.Rows.Count > 1)
                    {
                        for(int i=0;i< tb.Rows.Count;i++)
                        {
                            bk.MaBooked = tb.Rows[0][1].ToString();
                            sup.DeleteBooked(bk);
                        }
                        if (tour.DeleteTour(obj))
                        {
                            MessageBox.Show("xoá thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            xoatxt();
                        }
                    }
                    else if (tb.Rows.Count == 1)
                    {
                        bk.MaBooked = tb.Rows[0][1].ToString();
                        bk.MaKhachHang = tb.Rows[0][2].ToString();
                        sup.DeleteBooked(bk);
                        sup.DeleteKhachHang(bk);
                        if (tour.DeleteTour(obj))
                        {
                            MessageBox.Show("xoá thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            xoatxt();
                        }

                    }
                    else
                    {
                        if (tour.DeleteTour(obj))
                        {
                            MessageBox.Show("xoá thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            xoatxt();
                        }
                    }    
                        
                }
                else
                {
                    MessageBox.Show("Mã cần xoá không tồn tại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
                
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable t = tour.LookupTour(txtTim.Text.Trim());
            if (t.Rows.Count <= 0)
            {
                MessageBox.Show("Không có kết quả nào!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                dgvTour.DataSource = t;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string[] ten = open.FileName.Split('\\');
                txtLinkAnh.Text = ten[ten.Length - 1];
                string[] tenanh = txtLinkAnh.Text.Trim().Split('.');
                txtLinkAnh.Text = tenanh[tenanh.Length - 2];
                picAnh.ImageLocation = open.FileName;
            }
        }
        public string saveFiles(OpenFileDialog open)
        {
            string link = txtLinkAnh.Text;
            if (open.FileName != "")
            {
                Image images = Bitmap.FromFile(open.FileName);
                DataTable t = tour.checklinkAnh("../Images/" + txtLinkAnh.Text.Trim());
                if (t.Rows.Count > 0)
                {
                    if(t.Rows.Count == 1)
                    {
                        link = "../Images/" + txtLinkAnh.Text + "(0).jpg";
                    }    
                    else
                    {
                        string linkcu = t.Rows[t.Rows.Count - 1][0].ToString().Trim();
                        string ketqua;

                        string[] ten = linkcu.Split('\\');
                        ketqua = ten[ten.Length - 1].Trim();
                        string[] tenanh = ketqua.Trim().Split('.');
                        ketqua = tenanh[tenanh.Length - 1].Trim();
                        string[] ten2 = ketqua.Trim().Split(')');
                        ketqua = ten2[ten2.Length - 2].Trim();
                        string[] ten3 = ketqua.Trim().Split('(');
                        ketqua = ten3[ten3.Length - 1].Trim();
                        int somoi = int.Parse(ketqua) + 1;
                        if(somoi<999999)
                        link = "../Images/" + txtLinkAnh.Text + "("+somoi+").jpg";
                        else
                            MessageBox.Show("Quá tải kho lưu trữ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    link = "../Images/" + txtLinkAnh.Text +".jpg";
                }
                if(link.Trim().Length<200)
                    images.Save(link);
                else
                    MessageBox.Show("Tên file ảnh quá dài, vui lòng đổi lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return link;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
