using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;

namespace DAL
{
    public class DAL_HoTroKhachHang : KetNoi
    {
        
        public int tongtien(int giaTour, int soNguoiLon, int soTreEm)
        {
            return (giaTour * soNguoiLon + (giaTour / 2) * soTreEm);

        }
        public bool checkso(string so)
        {
            bool check;
            string regex = "^[0-9]*$";
            if (so.Trim().Length < 12 && Regex.IsMatch(so, regex))
            {
                check = true;
            }
            else
                check = false;
            return check;
        }
        public DataTable getTableKhachHang()
        {
            string sql = "Select * From khachhang ";
            return base.GetTable(sql);
        }
        public DataTable getTablebook()
        {
            string sql = "Select mabooked,booked.matour, tentour,makhachhang,ngaydattour,tour.ngaykhoihanh, songuoilon,sotreem,giatour From booked inner join tour on booked.matour = tour.matour";
            return base.GetTable(sql);
        }

        public bool UpdateKhachHang(DTO_KhachHang obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "update khachhang set tenKhachHang = @tenKhachHang, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, soDienThoai = @soDienThoai,gmail = @gmail, diaChi = @diaChi where maKhachHang = @maKhachHang";
            SqlCommand cmd = new SqlCommand(sql, base.conn);

            //string makhachhang = obj.NgaySinh.ToString().Trim()+"_" + obj.SoDienThoai.ToString().Trim();
            cmd.Parameters.AddWithValue("@makhachhang", obj.MaKhachHang);
            cmd.Parameters.AddWithValue("@tenKhachHang", obj.TenKhachHang);
            cmd.Parameters.AddWithValue("@ngaySinh", obj.NgaySinh);
            cmd.Parameters.AddWithValue("@gioiTinh", obj.GioiTinh);
            cmd.Parameters.AddWithValue("@soDienThoai", obj.SoDienThoai);
            cmd.Parameters.AddWithValue("@gmail", obj.Gmail);
            cmd.Parameters.AddWithValue("@diaChi", obj.DiaChi);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }
        public bool DeleteKhachHang(DTO_Booked obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "delete from khachhang where maKhachHang = @maKhachHang";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@makhachhang", obj.MaKhachHang);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }    
        public DataTable Lookupkhachhang(DTO_KhachHang obj)
        {
            string sql = "Select * From khachhang where tenkhachhang Like N'%" + obj.TenKhachHang + "%' OR sodienthoai LIKE '%" + obj.SoDienThoai + "%'";
            return base.GetTable(sql);
        }
        public DataTable Lookupkhachhangtheoma( DTO_Booked objbk, DTO_KhachHang obj)
        {
            string sql = "Select * From khachhang where makhachhang = '" + obj.MaKhachHang + "' or makhachhang = '" + objbk.MaKhachHang + "'";
            return base.GetTable(sql);
        }

        public bool DeleteBooked(DTO_Booked obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "delete from booked where MaBooked = @MaBooked";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@MaBooked", obj.MaBooked);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }
        public void updateBooked(DTO_Booked obj)
        {
            String sql = "update booked set  SoNguoiLon = " + int.Parse(obj.SoNguoiLon.ToString()) + ",SoTreEm = " + int.Parse(obj.SoTreEm.ToString()) + ",TongTien = " + int.Parse(obj.TongTien.ToString()) + " where maBooked ='" + obj.MaBooked + "'";
            base.ExecuteSQL(sql);
        }
        public DataTable Lookupbooked(String tentour, string ngaydattour)
        {
            string sql = "Select mabooked,booked.matour, tentour,makhachhang,ngaydattour,tour.ngaykhoihanh, songuoilon,sotreem,giatour From booked inner join tour on booked.matour = tour.matour where tentour LIKE N'%" + tentour + "%' and ngaydattour <= '" + ngaydattour + "' ";
            return base.GetTable(sql);
        }        
        public DataTable Lookupbookedtheoma(DTO_Booked obj, DTO_KhachHang objkh)
        {
            string sql = "Select mabooked,booked.matour, tentour,makhachhang,ngaydattour,tour.ngaykhoihanh, songuoilon,sotreem,giatour From booked inner join tour on booked.matour = tour.matour where makhachhang = '" + obj.MaKhachHang + "' or makhachhang = '" + objkh.MaKhachHang + "'";
            return base.GetTable(sql);
        }
        public int checkbook(DTO_Booked obj)
        {
            String sql = "Select * From booked where MaKhachHang = N'" + obj.MaKhachHang + "'";
            DataTable t = base.GetTable(sql);
            return (t.Rows.Count);
        }

    }
}
