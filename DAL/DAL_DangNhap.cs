using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_DangNhap : KetNoi
    {
        public DTO_TaiKhoan LayTaiKhoan(string tentaikhoan, string matkhau)
        {
            DTO_TaiKhoan list = new DTO_TaiKhoan();

            if (base.conn.State == ConnectionState.Closed) base.conn.Open();

            string sql = "select * from taikhoan where tentaikhoan=@tentaikhoan and matkhau=@matKhau";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@tentaikhoan", tentaikhoan);
            cmd.Parameters.AddWithValue("@matKhau", matkhau);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                list.TenTaiKhoan = dr[0] + "";
                list.MatKhau = dr[1] + "";
                list.LoaiTaiKhoan = dr[2] + "";
            }
            else
            {
                list = null;
            }


            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return list;
        }
    }
}
