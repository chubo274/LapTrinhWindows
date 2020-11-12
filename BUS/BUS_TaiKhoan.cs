using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Collections.Generic;

namespace BUS
{        
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan TK = new DAL_TaiKhoan();
        public DataTable GetTaiKhoan()
        {
            return TK.GetTaiKhoan();
        }
        public DataTable LookupTaiKhoan(string dieukien)
        {
            return TK.LookupTaiKhoan(dieukien);
        }
        public bool InsertTaiKhoan(DTO_TaiKhoan tk)
        {
            return TK.InsertTaiKhoan(tk);
        }
        public bool UpdateTaiKhoan(DTO_TaiKhoan tk)
        {
            return TK.UpdateTaiKhoan(tk);
        }
        public bool DeleteTaiKhoan(DTO_TaiKhoan tk)
        {
            return TK.DeleteTaiKhoan(tk);
        }
    }
}
