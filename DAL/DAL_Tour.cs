using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;

namespace DAL
{
    public class DAL_Tour:KetNoi
    {
        public DataTable GetTableTour(string sql)
        {
            return base.GetTable(sql);
        }
        public bool checkmaTour(DTO_Tour obj)
        {
            String sql = "Select * From tour where maTour = '"+obj.MaTour+"'";
            DataTable t = base.GetTable(sql);
            return (t.Rows.Count > 0);
        }
        public DataTable checklinkAnh(string dieukien)
        {
            String sql = "Select linkAnh From tour where linkAnh LIKE '" + dieukien+"%'";
            return base.GetTable(sql);
        }
        public bool InsertTour(DTO_Tour obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "insert into tour(maTour, maKhuVuc, tenTour, diemXuatPhat, diemDenCuoi, dichVu, ngayKhoiHanh, thoiGianTour, giaTour, linkAnh, lichTrinh) values(@maTour, @maKhuVuc, @tenTour, @diemXuatPhat, @diemDenCuoi, @dichVu, @ngayKhoiHanh, @thoiGianTour, @giaTour, @linkAnh, @lichTrinh)";
            SqlCommand cmd = new SqlCommand(sql, base.conn);

            cmd.Parameters.AddWithValue("@maTour", obj.MaTour);
            cmd.Parameters.AddWithValue("@maKhuVuc", obj.MaKhuVuc);
            cmd.Parameters.AddWithValue("@tenTour", obj.TenTour);
            cmd.Parameters.AddWithValue("@diemXuatPhat", obj.DiemXuatPhat);
            cmd.Parameters.AddWithValue("@diemDenCuoi", obj.DiemDenCuoi);
            cmd.Parameters.AddWithValue("@dichVu", obj.DichVu);
            cmd.Parameters.AddWithValue("@ngayKhoiHanh", obj.NgayKhoiHanh);
            cmd.Parameters.AddWithValue("@thoiGianTour", obj.ThoiGianTour);
            cmd.Parameters.AddWithValue("@giaTour", obj.GiaTour);
            cmd.Parameters.AddWithValue("@linkAnh", obj.LinkAnh);
            cmd.Parameters.AddWithValue("@lichTrinh", obj.LichTrinh);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }

        public bool UpdateTour(DTO_Tour obj)
        {
            bool check;
            String sql = "update tour set maKhuVuc = @maKhuVuc, tenTour = @tenTour, diemXuatPhat = @diemXuatPhat, diemDenCuoi = @diemDenCuoi, dichVu = @dichVu, ngayKhoiHanh = @ngayKhoiHanh, thoiGianTour = @thoiGianTour, giaTour = @giaTour, linkAnh = @linkAnh, lichTrinh = @lichTrinh where maTour = @maTour";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(sql, base.conn);

            cmd.Parameters.AddWithValue("@maTour", obj.MaTour);
            cmd.Parameters.AddWithValue("@maKhuVuc", obj.MaKhuVuc);
            cmd.Parameters.AddWithValue("@tenTour", obj.TenTour);
            cmd.Parameters.AddWithValue("@diemXuatPhat", obj.DiemXuatPhat);
            cmd.Parameters.AddWithValue("@diemDenCuoi", obj.DiemDenCuoi);
            cmd.Parameters.AddWithValue("@dichVu", obj.DichVu);
            cmd.Parameters.AddWithValue("@ngayKhoiHanh", obj.NgayKhoiHanh);
            cmd.Parameters.AddWithValue("@thoiGianTour", obj.ThoiGianTour);
            cmd.Parameters.AddWithValue("@giaTour", obj.GiaTour);
            cmd.Parameters.AddWithValue("@linkAnh", obj.LinkAnh);
            cmd.Parameters.AddWithValue("@lichTrinh", obj.LichTrinh);

            check = base.ThucThi(cmd);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return check;
        }
        public bool DeleteTour(DTO_Tour obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "delete From tour where maTour = @maTour";
            SqlCommand cmd = new SqlCommand(sql, base.conn);

            cmd.Parameters.AddWithValue("@maTour", obj.MaTour);
            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }
        public DataTable LookupTour(string dieukien)
        {
            DataTable table = new DataTable();
            try
            {
                if (base.conn.State == ConnectionState.Closed) base.conn.Open();
                String sql = "Select * From tour where maTour LIKE '%" + dieukien + "%' OR tenTour LIKE '%" + dieukien + "%'";
                SqlDataAdapter data = new SqlDataAdapter(sql, conn);
                data.Fill(table);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "LỖI ĐỊNH DẠNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException se)
            {
                if (se.Message.Contains("Cannot insert duplicate key"))
                    MessageBox.Show("Lỗi trùng khoá chính", "LỖI THỰC THI SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(se.Message, "LỖI THỰC THI SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "LỖI Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }
        public DataTable Lookupkhachhangtheoma(DTO_Booked obj)
        {
            string sql = "Select tour.matour,mabooked,booked.makhachhang, songuoilon, sotreem From tour inner join booked on tour.matour = booked.matour inner join khachhang on khachhang.makhachhang = booked.makhachhang where tour.matour = '" + obj.MaTour+"'";
            return base.GetTable(sql);
        }
        public bool checkso(string so)
        {
            string regex = "^[0-9]*$";
            return Regex.IsMatch(so, regex);
        }
    }
}
