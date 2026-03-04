using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface IUserService 
    {
        void TInsert(User entity);
    void TDelete(User entity);
    void TUpdate(User entity);
    List<User> TGetList();
    User TGetById(int id);
}
}
