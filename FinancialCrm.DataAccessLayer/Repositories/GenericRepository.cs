using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.DataAccessLayer.Repositories
{
    // Interface'deki tüm metodları buraya yazıyoruz
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // veritabanı köprüsü (Context)
        FinancialCrmContext context = new FinancialCrmContext();

        public void Insert(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChanges(); // Değişiklikleri SQL'e yansıtır
        }

        public void Delete(T t)
        {
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Set<T>().Update(t);
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
