using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string gmail;
        private string diaChi;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string maKhachHang, string tenKhachHang, string ngaySinh, string gioiTinh, string soDienThoai, string gmail, string diaChi)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SoDienThoai = soDienThoai;
            this.Gmail = gmail;
            this.DiaChi = diaChi;
        }
    }
}
