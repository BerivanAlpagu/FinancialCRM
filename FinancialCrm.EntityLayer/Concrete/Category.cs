using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // İlişki: Bir kategorinin birden fazla harcaması olabilir o yüzden List<Spending> kullanıyoruz
        public List<Expend> Expends { get; set; }
    }
}
