using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhuVuc
    {
        private string maKhuVuc;
        private string tenKhuVuc;

        public string MaKhuVuc { get => maKhuVuc; set => maKhuVuc = value; }
        public string TenKhuVuc { get => tenKhuVuc; set => tenKhuVuc = value; }

        public DTO_KhuVuc()
        {

        }

        public DTO_KhuVuc(string maKhuVuc, string tenKhuVuc)
        {
            this.MaKhuVuc = maKhuVuc;
            this.TenKhuVuc = tenKhuVuc;
        }
    }
}
