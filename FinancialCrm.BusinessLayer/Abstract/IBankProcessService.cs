using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface IBankProcessService 
    {
        void TInsert(BankProcess entity);
    void TDelete(BankProcess entity);
    void TUpdate(BankProcess entity);
    List<BankProcess> TGetList();
    BankProcess TGetById(int id);
}
}
