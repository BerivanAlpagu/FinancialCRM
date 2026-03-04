using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FinancialCrm.DataAccessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;

namespace FinancialCrm.DataAccessLayer.Abstract
{
    // Bu interfacele, IGenericRepository'den Banka tablosu için miras aldı
    public interface IBillDal : IGenericRepository<Bill>
    {
        // Burası şu an boş kalacak, tüm CRUD işlemleri mirasla gelecekkk
    }
}
