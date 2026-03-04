using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BillManager : IBillService
{
    private readonly IBillDal _billDal;
    public BillManager(IBillDal billDal) { _billDal = billDal; }
    public void TDelete(Bill bill) { _billDal.Delete(bill); }
    public Bill TGetById(int id) { return _billDal.GetById(id); }
    public List<Bill> TGetList() { return _billDal.GetList(); }
    public void TInsert(Bill bill) { _billDal.Insert(bill); }
    public void TUpdate(Bill bill) { _billDal.Update(bill); }
}
