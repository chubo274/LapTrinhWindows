using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tour
    {
        private string maTour;
        private string maKhuVuc;
        private string tenTour;
        private string diemXuatPhat;
        private string diemDenCuoi;
        private string dichVu;
        private string ngayKhoiHanh;
        private string thoiGianTour;
        private int giaTour;
        private string linkAnh;
        private string lichTrinh;

        public string MaTour { get => maTour; set => maTour = value; }
        public string TenTour { get => tenTour; set => tenTour = value; }
        public string DiemXuatPhat { get => diemXuatPhat; set => diemXuatPhat = value; }
        public string DiemDenCuoi { get => diemDenCuoi; set => diemDenCuoi = value; }
        public string DichVu { get => dichVu; set => dichVu = value; }
        public string ThoiGianTour { get => thoiGianTour; set => thoiGianTour = value; }
        public int GiaTour { get => giaTour; set => giaTour = value; }
        public string MaKhuVuc { get => maKhuVuc; set => maKhuVuc = value; }
        public string NgayKhoiHanh { get => ngayKhoiHanh; set => ngayKhoiHanh = value; }
        public string LinkAnh { get => linkAnh; set => linkAnh = value; }
        public string LichTrinh { get => lichTrinh; set => lichTrinh = value; }

        public DTO_Tour()
        {

        }
        public DTO_Tour(string maTour, string maKhuVuc, string tenTour, string diemXuatPhat, string diemDenCuoi, string dichVu, string ngayKhoiHanh, string thoiGianTour, int giaTour, string linkAnh, string lichTrinh)
        {
            this.MaTour = maTour;
            this.MaKhuVuc = maKhuVuc;
            this.TenTour = tenTour;
            this.DiemXuatPhat = diemXuatPhat;
            this.DiemDenCuoi = diemDenCuoi;
            this.DichVu = dichVu;
            this.NgayKhoiHanh = ngayKhoiHanh;
            this.ThoiGianTour = thoiGianTour;
            this.GiaTour = giaTour;
            this.LinkAnh = linkAnh;
            this.LichTrinh = lichTrinh;
        }
    }
}
