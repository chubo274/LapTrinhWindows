using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class KetNoi
    {
        public static String connString = @"Data Source=DESKTOP-PM6R5EE;Initial Catalog=DuLich;Integrated Security=True";
        public SqlConnection conn = null;
        public KetNoi()
        {
            conn = new SqlConnection(connString);
        }

        public DataTable GetTable(string sql)
        {
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            data.Fill(table);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return table;
        }
        public void ExecuteSQL(String sql)
        {
            SqlConnection conn2 = new SqlConnection(connString);
            conn2.Open();
            SqlCommand cmd = new SqlCommand(sql,conn2);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            conn2.Close();
        }
        public bool ThucThi(SqlCommand cmd)
        {
            
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "LỖI ĐỊNH DẠNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (SqlException se)
            {
                if (se.Message.Contains("Cannot insert duplicate key"))
                {
                    MessageBox.Show("Lỗi trùng khoá chính", "LỖI THỰC THI SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show(se.Message, "LỖI THỰC THI SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "LỖI Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
