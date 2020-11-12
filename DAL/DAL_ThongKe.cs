using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_ThongKe : KetNoi
    {
        public DataTable GetTable()
        {
            string sql = "SELECT booked.matour, tentour,booked.makhachhang,tenkhachhang,ngaydattour, songuoilon,sotreem,giatour,tongtien FROM tour inner join booked on tour.matour = booked.matour inner join khachhang on khachhang.makhachhang = booked.makhachhang ";
            return base.GetTable(sql);
        }

        public DataTable LookUp2dieukien(string maTour, string tuNgay, string denNgay)
        {
            string sql = "SELECT booked.matour, tentour,booked.makhachhang,tenkhachhang,ngaydattour, songuoilon,sotreem,giatour,tongtien FROM tour inner join booked on tour.matour = booked.matour inner join khachhang on khachhang.makhachhang = booked.makhachhang where tour.matour = '" + maTour + "' and ngaydattour between '" + tuNgay + "' and  '" + denNgay + "'";
            return base.GetTable(sql);
        }
        public DataTable LookUpma(string maTour)
        {
            string sql = "SELECT booked.matour, tentour,booked.makhachhang,tenkhachhang,ngaydattour, songuoilon,sotreem,giatour,tongtien FROM tour inner join booked on tour.matour = booked.matour inner join khachhang on khachhang.makhachhang = booked.makhachhang where tour.matour = '" + maTour + "' ";
            return base.GetTable(sql);
        }
        public void Export(DataTable dt, string sheetName, string title, int tongthu)
        {

            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "I1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Arial";

            head.Font.Size = "18";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Tour";

            cl1.ColumnWidth = 14.0;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Tour";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Mã Khách Hàng";

            cl3.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Tên Khách Hàng";

            cl4.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày Đặt Tour";

            cl5.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số Người Lớn";

            cl6.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Số Trẻ Em";

            cl7.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Giá Tour";

            cl8.ColumnWidth = 14.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Thành Tiền";

            cl9.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if(c==4)
                    {
                        string [] ng = dr[c].ToString().Split(' ');
                        arr[r, c] = ng[0].Trim();
                    }    
                    else
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            Microsoft.Office.Interop.Excel.Range ngaydattourcells = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4, 4];
            Microsoft.Office.Interop.Excel.Range ngaydattourcelle = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, 4];
            Microsoft.Office.Interop.Excel.Range ngaydattour = oSheet.get_Range(ngaydattourcells, ngaydattourcelle);
            //ngaydattour.Value[Microsoft.Office.Interop.Excel.D] = DateTime;
            range.Value2 = arr;

            // Kẻ viền chưa bao tổng

            //range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Tổng tiền thu
            int rowEndthem1 = 4 + dt.Rows.Count;
            int columnEndbot1 = dt.Columns.Count - 1;
            Microsoft.Office.Interop.Excel.Range tongthus = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEndthem1, columnStart];
            Microsoft.Office.Interop.Excel.Range tongthue = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEndthem1, columnEndbot1];
            Microsoft.Office.Interop.Excel.Range tongthutxt = oSheet.get_Range(tongthus, tongthue);
            tongthutxt.MergeCells = true;
            tongthutxt.Value2 = "Tổng thu";
            tongthutxt.Font.Italic = true;
            tongthutxt.Font.Name = "Arial";
            tongthutxt.Font.Size = "14";
            Microsoft.Office.Interop.Excel.Range tongthucell = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEndthem1, columnEnd];
            Microsoft.Office.Interop.Excel.Range tongthuint = oSheet.get_Range(tongthucell, tongthucell);
            tongthuint.Value2 = tongthu;
            // kẻ viền bao cả tổng
            Microsoft.Office.Interop.Excel.Range kevien = oSheet.get_Range(c1, tongthucell);
            kevien.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột Mã

            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEndthem1, columnStart];

            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Căn trái các cột là số

            /*Microsoft.Office.Interop.Excel.Range ongaydattour = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4, 4]; 

            oSheet.get_Range(ongaydattour, tongthucell).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;          
            */
        }
    }
}
