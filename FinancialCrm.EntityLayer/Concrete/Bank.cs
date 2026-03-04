using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.EntityLayer.Concrete
{
    public class Bank
    {
        public int BankId { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankTitle { get; set; }
        public decimal BankBalance { get; set; }

        // İlişki: Bir bankanın birden fazla süreci (işlemi) olabilir
        public List<BankProcess> BankProcesses { get; set; }
    }
}
