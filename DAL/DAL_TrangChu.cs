using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_TrangChu : KetNoi
    {
        public DataTable GetDanhSachTour()
        {
            return base.GetTable("Select * From tour");
        }
        public List<DTO_Tour> DanhSachTour()
        {
            List<DTO_Tour> list = new List<DTO_Tour>();
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            string sql = "Select * From tour";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            SqlDataReader reader = cmd.ExecuteReader();            
            while (reader.Read())
            {
                DTO_Tour x = new DTO_Tour(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), int.Parse(reader[8].ToString()), reader[9].ToString(), reader[10].ToString());
                list.Add(x);
            }
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return list;
        }
        public List<DTO_Tour> DanhSachTourdieukien(string dieukien)
        {
            List<DTO_Tour> list = new List<DTO_Tour>();
            if (base.conn.State == ConnectionState.Closed) base.conn.Open();
            string sql = "Select * From tour where "+ dieukien + "";
            SqlCommand cmd = new SqlCommand(sql, base.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.FieldCount <= 0)
            {
                MessageBox.Show("Không có kết quả nào!!", "Không có kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                while (reader.Read())
                {
                    DTO_Tour x = new DTO_Tour(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), int.Parse(reader[8].ToString()), reader[9].ToString(), reader[10].ToString());
                    list.Add(x);
                }
            }
            if (base.conn.State == ConnectionState.Open) base.conn.Close();
            return list;                
        }
    }
}
