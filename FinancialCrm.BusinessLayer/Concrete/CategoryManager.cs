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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal) { _categoryDal = categoryDal; }

        public void TDelete(Category category) { _categoryDal.Delete(category); }
        public Category TGetById(int id) { return _categoryDal.GetById(id); }
        public List<Category> TGetList() { return _categoryDal.GetList(); }
        public void TInsert(Category category) { _categoryDal.Insert(category); }
        public void TUpdate(Category category) { _categoryDal.Update(category); }
    }
}
