using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.EntityLayer.Concrete
{
    public class BankProcess
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public DateTime Datetime { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }

        // İlişki: İşlem bir bankaya aittir
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
