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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal) { _userDal = userDal; }

        public void TDelete(User entity) { _userDal.Delete(entity); }
        public User TGetById(int id) { return _userDal.GetById(id); }
        public List<User> TGetList() { return _userDal.GetList(); }
        public void TInsert(User entity) { _userDal.Insert(entity); }
        public void TUpdate(User entity) { _userDal.Update(entity); }
    }
}
