using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_LoaiPhong
    {
        private string malp;
        private string tenlp;
        private string trangthietbi;
        private string gia;
        private string donvi;

        public string Malp { get => malp; set => malp = value; }
        public string Tenlp { get => tenlp; set => tenlp = value; }
        public string Trangthietbi { get => trangthietbi; set => trangthietbi = value; }
        public string Gia { get => gia; set => gia = value; }
        public string Donvi { get => donvi; set => donvi = value; }
    }
}
