using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.EntityLayer.Concrete;
using System.Collections.Generic;

namespace FinancialCrm.BusinessLayer.Abstract
{
    public interface ICategoryService 
    {
        void TInsert(Category entity);
    void TDelete(Category entity);
    void TUpdate(Category entity);
    List<Category> TGetList();
    Category TGetById(int id);
}
}
