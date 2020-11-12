using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dal = new DAL_DangNhap();
        public DTO_TaiKhoan LayTaiKhoan(string tentaikhoan, string matkhau)
        {
            return dal.LayTaiKhoan(tentaikhoan,matkhau);
        }
    }
}
