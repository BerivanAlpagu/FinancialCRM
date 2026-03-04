using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Concrete
{
    public class BankProcessManager : IBankProcessService
    {
        private readonly IBankProcessDal _bankProcessDal;
        public BankProcessManager(IBankProcessDal bankProcessDal) { _bankProcessDal = bankProcessDal; }

        public void TDelete(BankProcess entity) { _bankProcessDal.Delete(entity); }
        public BankProcess TGetById(int id) { return _bankProcessDal.GetById(id); }
        public List<BankProcess> TGetList() { return _bankProcessDal.GetList(); }
        public void TInsert(BankProcess entity) { _bankProcessDal.Insert(entity); }
        public void TUpdate(BankProcess entity) { _bankProcessDal.Update(entity); }
    }
}
