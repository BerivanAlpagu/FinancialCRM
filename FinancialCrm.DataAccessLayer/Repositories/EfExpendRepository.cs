using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Repositories;
using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.DataAccessLayer.Repositories
{
    public class EfExpendRepository : GenericRepository<Expend>, IExpendDal 
    { 
    
    }
}
