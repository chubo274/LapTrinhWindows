using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan : KetNoi
    {
        public DataTable GetTaiKhoan()
        {
            return base.GetTable("Select * From taikhoan");
        }
        public DataTable LookupTaiKhoan(string dieukien )
        {
            DataTable table = new DataTable();
            try
            {
                if (base.conn.State == ConnectionState.Closed) base.conn.Open();
                String sql = "Select * From taikhoan where tenTaiKhoan LIKE '%" + dieukien + "%'";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        public bool InsertTaiKhoan(DTO_TaiKhoan tk)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "insert into taikhoan(tentaikhoan,matkhau,loaitaikhoan) values(@tentaikhoan,@matkhau,@loaitaikhoan)";

            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@tentaikhoan", tk.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@matkhau", tk.MatKhau);
            cmd.Parameters.AddWithValue("@loaitaikhoan", tk.LoaiTaiKhoan);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }

        public bool UpdateTaiKhoan(DTO_TaiKhoan tk)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "update taikhoan set matkhau = @matkhau,loaitaikhoan = @loaitaikhoan where tentaikhoan = @tentaikhoan";

            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@tentaikhoan", tk.TenTaiKhoan);
            cmd.Parameters.AddWithValue("@matkhau", tk.MatKhau);
            cmd.Parameters.AddWithValue("@loaitaikhoan", tk.LoaiTaiKhoan);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }

        public bool DeleteTaiKhoan(DTO_TaiKhoan tk)
        {
            bool check;
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            String sql = "delete from taikhoan where tentaikhoan = @tentaikhoan)";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            cmd.Parameters.AddWithValue("@tentaikhoan", tk.TenTaiKhoan);

            check = base.ThucThi(cmd);
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return check;
        }
    }
}
