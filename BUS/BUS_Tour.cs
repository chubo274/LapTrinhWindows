using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Tour
    {
        DAL_Tour dal = new DAL_Tour();
        public DataTable GetTableTour()
        {
            String sql = "SELECT tour.matour, tenkhuvuc, tour.tentour, tour.diemxuatphat, tour.diemdencuoi, tour.dichvu, tour.ngaykhoihanh, tour.thoigiantour, tour.giatour, tour.linkanh, tour.lichtrinh FROM tour INNER JOIN khuvuc ON tour.makhuvuc = dbo.khuvuc.makhuvuc";
            return dal.GetTableTour(sql);
        }

        public bool InsertTour(DTO_Tour obj)
        {
            return dal.InsertTour(obj);
        }

        public bool UpdateTour(DTO_Tour obj)
        {
            return dal.UpdateTour(obj);
        }

        public bool DeleteTour(DTO_Tour obj)
        {
            return dal.DeleteTour(obj);
        }

        public DataTable LookupTour(string dieukien)
        {
            return dal.LookupTour(dieukien);
        }
        public bool checkmaTour(DTO_Tour obj)
        {
            return dal.checkmaTour(obj);
        }
        public DataTable checklinkAnh(string dieukien)
        {
            return dal.checklinkAnh(dieukien);
        }
        public DataTable Lookupkhachhangtheoma(DTO_Booked obj)
        {
            return dal.Lookupkhachhangtheoma(obj);
        }
        public bool checkso(string so)
        {
            return dal.checkso(so);
        }
    }
}
