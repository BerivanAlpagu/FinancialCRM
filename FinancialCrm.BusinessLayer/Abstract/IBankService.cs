using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface IBankService
    {
        void TInsert(Bank bank);
        void TDelete(Bank bank);
        void TUpdate(Bank bank);
        List<Bank> TGetList();
        Bank TGetById(int id);
    }
}
