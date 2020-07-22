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
        private string maphong;
        private string sophong;
        private string status;
        private string malp;

        public string Maphong { get => maphong; set => maphong = value; }
        public string Sophong { get => sophong; set => sophong = value; }
        public string Status { get => status; set => status = value; }
        public string Malp { get => malp; set => malp = value; }
    }
}
