using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_DichVu
    {
        private string madv;
        private string tendv;
        private string giadv;


        public string Madv { get => madv; set => madv = value; }
        public string Tendv { get => tendv; set => tendv = value; }
        public string Giadv { get => giadv; set => giadv = value; }
    }
}
