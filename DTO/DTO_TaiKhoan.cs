using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string loaiTaiKhoan;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        public DTO_TaiKhoan()
        {

        }
        public DTO_TaiKhoan(string tenTaiKhoan, string matKhau, string loaiTaiKhoan)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }
    }
}
