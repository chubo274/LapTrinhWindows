using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DTO;

namespace DAL
{
    public class DAL_DatTour : KetNoi
    {
        public int stt()
        {
            return base.GetTable("Select * From khachhang").Rows.Count+1;            
        }
        public int tongtien(int giaTour, Decimal soNguoiLon, Decimal soTreEm)
        {
             return (giaTour * int.Parse(soNguoiLon.ToString().Trim()) + giaTour/2 * int.Parse(soTreEm.ToString().Trim()));

        }
        public bool InsertKhachHang(DTO_KhachHang obj)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "insert into khachhang(maKhachHang, tenKhachHang, ngaySinh, gioiTinh, soDienThoai, gmail, diaChi) values(@maKhachHang, @tenKhachHang, @ngaySinh, @gioiTinh, @soDienThoai, @gmail, @diaChi)";
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
        public DataTable checkKhachHang(DTO_KhachHang obj)
        {
            String sql = "Select MaKhachHang From khachhang where TenKhachHang = N'" + obj.TenKhachHang+ "' and SoDienThoai = '" + obj.SoDienThoai + "' and NgaySinh = '" + obj.NgaySinh + "' and GioiTinh = N'" + obj.GioiTinh + "'";
            return  base.GetTable(sql);
        }
        public DataTable checkmaKhachHang(string MaKhachHang)
        {
            String sql = "Select MaKhachHang From khachhang where MaKhachHang LIKE '" + MaKhachHang + "%'";
            return  base.GetTable(sql);
        }
        public DataTable checkmabooked(string MaBooked)
        {
            String sql = "Select MaBooked From Booked where MaBooked LIKE '" + MaBooked + "%'";
            return base.GetTable(sql);
        }
        public void InsertBooked(DTO_Booked obj)
        {
            string sql = "insert into booked values('" + obj.MaBooked + "','" + obj.MaTour + "','" + obj.MaKhachHang + "','" + obj.NgayDatTour + "','" + obj.NgayKhoiHanh + "'," + int.Parse(obj.SoNguoiLon.ToString()) + "," + int.Parse(obj.SoTreEm.ToString()) + "," + int.Parse(obj.TongTien.ToString()) + ")";
            base.ExecuteSQL(sql);
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

        public int sttbk()
        {
            return base.GetTable("Select * From booked").Rows.Count + 1;
        }
        
    }
}
