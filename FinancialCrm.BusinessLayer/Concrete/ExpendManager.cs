using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ExpendManager : IExpendService
{
    private readonly IExpendDal _expendDal;
    public ExpendManager(IExpendDal expendDal) { _expendDal = expendDal; }
    public void TDelete(Expend expend) { _expendDal.Delete(expend); }
    public Expend TGetById(int id) { return _expendDal.GetById(id); }
    public List<Expend> TGetList() { return _expendDal.GetList(); }
    public void TInsert(Expend expend) { _expendDal.Insert(expend); }
    public void TUpdate(Expend expend) { _expendDal.Update(expend); }
}
