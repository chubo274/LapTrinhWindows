using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;
using System.Collections.Generic;

namespace BUS
{
    public class BUS_TrangChu
    {
        DAL_TrangChu TRC = new DAL_TrangChu();
        public DataTable GetDanhSachTour()
        {
            return TRC.GetDanhSachTour();
        }
        public DataTable LoadComboBox()
        {
            return TRC.LoadComboBox();
        }
        public List<DTO_Tour> DanhSachTour()
        {
            return TRC.DanhSachTour();
        }
        public List<DTO_Tour> DanhSachTourdieukien(string dieukien)
        {
            return TRC.DanhSachTourdieukien(dieukien);
        }
    }
}
