using DAL_Hotel;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS_Hotel
{
    public class BUS_CTDV
    {
        private DAL_CTDV dal;

        public BUS_CTDV()
        {
            dal = new DAL_CTDV();
        }
        public string Delete(DTO_CTDV obj)
        {
            return dal.Delete(obj);
        }
        public string DeleteAll(DTO_CTDV obj)
        {
            return dal.DeleteAll(obj);
        }

        public string Insert(DTO_CTDV obj)
        {
            return dal.Insert(obj);
        }

        public string Update(DTO_CTDV obj)
        {
            return dal.Update(obj);
        }

        public string SelectAll(List<DTO_CTDV> lsobj)
        {
            return dal.selectAll(lsobj);
        }
    }
}
