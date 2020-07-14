using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Hotel;
using DAL_Hotel;
namespace BUS_Hotel
{
    public class BUS_ThongTinKS
    {
        private DAL_ThongTinKS dal;
        public BUS_ThongTinKS()
        {
            dal = new DAL_ThongTinKS();
        }
        public DTO_ThongTinKS SelectAll()
        {
            return dal.selectAll();
        }
    }
}
