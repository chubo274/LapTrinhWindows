using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_DatTour
    {
        DAL_DatTour dal = new DAL_DatTour();
        public int tongtien(int giaTour, Decimal soNguoiLon, Decimal soTreEm)
        {
            return dal.tongtien(giaTour, soNguoiLon, soTreEm);
        }
        public bool InsertKhachHang(DTO_KhachHang obj)
        {
            return dal.InsertKhachHang(obj);
        }
        public void InsertBooked(DTO_Booked obj)
        {
            dal.InsertBooked(obj);
        }
        public DataTable checkKhachHang(DTO_KhachHang obj)
        {
            return dal.checkKhachHang(obj);
        }
        public DataTable checkmaKhachHang(string makhach)
        {
            return dal.checkmaKhachHang(makhach);
        }
        public DataTable checkmabooked(string mabooked)
        {
            return dal.checkmabooked(mabooked);
        }
        public bool checkso(string so)
        {
            return dal.checkso(so);
        }
        public int stt()
        {
            return dal.stt();
        }
    }
}
