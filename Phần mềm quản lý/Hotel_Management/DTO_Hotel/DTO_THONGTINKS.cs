using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Hotel
{
    public class DTO_ThongTinKS
    {
        private string _maks;
        private string _tenks;
        private string _diachiks;
        private string _emailks;
        private string _sdtks;
        private string _websiteks;

        public string Maks{ get => _maks; set => _maks = value; }
        public string Tenks { get => _tenks; set => _tenks = value; }
        public string Diachiks { get => _diachiks; set => _diachiks = value; }
        public string Emailks { get => _emailks; set => _emailks = value; }
        public string SDTks { get => _sdtks; set => _sdtks = value; }
        public string Websiteks { get => _websiteks; set => _websiteks = value; }

    }
}
