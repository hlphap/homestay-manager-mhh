using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_NhanVien
    {
        private string manv;

        public string Manv { get => manv; set => manv = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Address { get => address; set => address = value; }

        private string name;
        private string date;
        private string sex;
        private string sdt;
        private string address;

    }
}
