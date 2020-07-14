using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_Phong
    {
        private string sophong;
        private string status;
        private string malp;
        private string gia;

        public string Sophong { get => sophong; set => sophong = value; }
        public string Status { get => status; set => status = value; }
        public string Malp { get => malp; set => malp = value; }
        public string Gia { get => gia; set => gia = value; }
    }
}
