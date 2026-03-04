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
    public class BankManager : IBankService
    {
        private readonly IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public void TDelete(Bank bank)
        {
            _bankDal.Delete(bank);
        }

        public Bank TGetById(int id)
        {
            return _bankDal.GetById(id);
        }

        public List<Bank> TGetList()
        {
            return _bankDal.GetList();
        }

        public void TInsert(Bank bank)
        {
            // Örn: if(bank.BankTitle.Length >= 3) { _bankDal.Insert(bank); }
            _bankDal.Insert(bank);
        }

        public void TUpdate(Bank bank)
        {
            _bankDal.Update(bank);
        }
    }
}
