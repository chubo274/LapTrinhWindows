using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Booked
    {
        private string maBooked;
        private string maTour;
        private string maKhachHang;
        private string ngayDatTour;
        private string ngayKhoiHanh;
        private int soNguoiLon;
        private int soTreEm;
        private int tongTien;

        public string MaBooked { get => maBooked; set => maBooked = value; }
        public string MaTour { get => maTour; set => maTour = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string NgayDatTour { get => ngayDatTour; set => ngayDatTour = value; }
        public string NgayKhoiHanh { get => ngayKhoiHanh; set => ngayKhoiHanh = value; }
        public int SoNguoiLon { get => soNguoiLon; set => soNguoiLon = value; }
        public int SoTreEm { get => soTreEm; set => soTreEm = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }

        public DTO_Booked()
        {

        }
        public DTO_Booked(string maBooked, string maTour, string maKhachHang, string ngayDatTour, string ngayKhoiHanh, int soNguoiLon, int soTreEm, int tongTien)
        {
            this.MaBooked = maBooked;
            this.MaTour = maTour;
            this.MaKhachHang = maKhachHang;
            this.NgayDatTour = ngayDatTour;
            this.NgayKhoiHanh = ngayKhoiHanh;
            this.SoNguoiLon = soNguoiLon;
            this.SoTreEm = soTreEm;
            this.TongTien = tongTien;
        }
    }
}
