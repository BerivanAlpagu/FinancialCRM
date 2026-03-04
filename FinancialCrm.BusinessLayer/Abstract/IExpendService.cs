using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface IExpendService 
    {
        void TInsert(Expend entity);
    void TDelete(Expend entity);
    void TUpdate(Expend entity);
    List<Expend> TGetList();
    Expend TGetById(int id);
}
}
