using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface IBillService 
    {
        void TInsert(Bill entity);
        void TDelete(Bill entity);
        void TUpdate(Bill entity);
        List<Bill> TGetList();
        Bill TGetById(int id);
    }
}
