using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.DataAccessLayer.Abstract
{
    public interface IUserDal : IGenericRepository<User> { }
}
