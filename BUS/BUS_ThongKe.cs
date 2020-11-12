using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;


namespace BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dal = new DAL_ThongKe();
        public DataTable GetTabler()
        {            
            return dal.GetTable();
        }
        public DataTable LookUp2dieukien(string maTour, string tuNgay, string denNgay)
        {
            return dal.LookUp2dieukien(maTour, tuNgay, denNgay);
        }
        public DataTable LookUpma(string maTour)
        {
            return dal.LookUpma(maTour);
        }

        public void Export(DataTable dt, string sheetName, string title, int tongthu)
        {
            dal.Export(dt, sheetName, title, tongthu);
        }
    }
}
