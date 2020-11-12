using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_HoTroKhachHang
    {
        DAL_HoTroKhachHang dal = new DAL_HoTroKhachHang();
        public DataTable getTableKhachHang()
        {
            return dal.getTableKhachHang();
        }

        public DataTable getTablebook()
        {
            return dal.getTablebook();
        }
        public bool checkso(string so)
        {
            return dal.checkso(so);
        }
        public int tongtien(int giaTour, int soNguoiLon, int soTreEm)
        {
            return dal.tongtien(giaTour, soNguoiLon, soTreEm);
        }
        public bool UpdateKhachHang(DTO_KhachHang obj)
        {
            return dal.UpdateKhachHang(obj);
        }
        public DataTable Lookupkhachhang(DTO_KhachHang obj)
        {
            return dal.Lookupkhachhang(obj);
        }
        public DataTable Lookupbookedtheoma(DTO_Booked obj, DTO_KhachHang objkh)
        {
            return dal.Lookupbookedtheoma(obj,objkh);
        }

        public DataTable Lookupkhachhangtheoma(DTO_Booked objbk, DTO_KhachHang obj)
        {
            return dal.Lookupkhachhangtheoma(objbk,obj);
        }
        public bool DeleteKhachHang(DTO_Booked obj)
        {
            return dal.DeleteKhachHang(obj);
        }

        public DataTable Lookupbooked(string tentour, string ngaydat)
        {
            return dal.Lookupbooked(tentour, ngaydat);
        }
        public void updateBooked(DTO_Booked obj)
        {
            dal.updateBooked(obj);
        }

        public int checkbook(DTO_Booked obj)
        {
            return dal.checkbook(obj);
        }
        public bool DeleteBooked(DTO_Booked obj)
        {
            return dal.DeleteBooked(obj);
        }
    }
}
