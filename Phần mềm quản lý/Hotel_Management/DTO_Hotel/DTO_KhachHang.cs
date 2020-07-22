using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_KhachHang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string gioitinh;
        private string cmnd;
        private string quoctich;
        private string sdt;
        private string ngaysinh;
       

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Quoctich { get => quoctich; set => quoctich = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
    }
}
