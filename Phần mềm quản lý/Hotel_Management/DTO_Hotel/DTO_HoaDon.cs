using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_HoaDon
    {
        private string mahd;
        private string macthd;
        private string ngaythanhtoan;
        private string tratruoc;
        private string manv;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public string Tratruoc { get => tratruoc; set => tratruoc = value; }
        public string Manv { get => manv; set => manv = value; }
        public string MaCTHD { get => macthd; set => macthd = value; }
    }
}
