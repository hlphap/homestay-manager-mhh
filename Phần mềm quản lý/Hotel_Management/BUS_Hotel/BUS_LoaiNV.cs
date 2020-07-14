using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_LoaiNV
    {

        private DAL_LoaiNV dal;

        public BUS_LoaiNV()
        {
            dal = new DAL_LoaiNV();
        }

        public string LoadDichVu(List<DTO_LoaiNV> lsobj)
        {
            return dal.selectAll(lsobj);
        }

        public string Delete(DTO_LoaiNV obj)
        {
            return dal.Delete(obj);
        }

        public string Insert(DTO_LoaiNV obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_LoaiNV obj)
        {
            return dal.Update(obj);
        }

        public string Search(string kq, List<DTO_LoaiNV> lsobj)
        {
            return dal.Search(kq, lsobj);
        }
    }
}
