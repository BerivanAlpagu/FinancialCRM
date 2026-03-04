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
    // GenericRepository'deki hazır kodları Banka tablosu için kullanıcakk
    public class EfBankRepository : GenericRepository<Bank>, IBankDal
    {
    }
}
