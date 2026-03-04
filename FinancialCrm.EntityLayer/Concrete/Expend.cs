using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.EntityLayer.Concrete
{
    public class Expend
    {
        public int ExpendId { get; set; } // "serial primary key" ile eşleşir
        public string ExpendTitle { get; set; }
        public decimal ExpendAmount { get; set; }
        public DateTime ExpendDate { get; set; } // SQL "date" tipi için

        // Foreign Key İlişkisi
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
