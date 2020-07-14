using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Hotel
{
    public class BUS_CTHD
    {
        private DAL_CTHD dal;

        public BUS_CTHD()
        {
            dal = new DAL_CTHD();
        }

        //public string LoadDichVu(List<DTO_CTHD> lsobj)
        //{
        //    return dal.selectAll(lsobj);
        //}

        public string Delete(DTO_CTHD obj)
        {
            return dal.Delete(obj);
        }

        public string Insert(DTO_CTHD obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_CTHD obj)
        {
            return dal.Update(obj);
        }

        public string Search(string kq, List<DTO_CTHD> lsobj)
        {
            return dal.Search(kq, lsobj);
        }
        public string TaoMaCTHD()
        {
            return dal.TaoMa();
        }

        public string selectAll(List<DTO_CTHD> lsobj)
        {
            return dal.selectAll(lsobj);
        }

    }
}
