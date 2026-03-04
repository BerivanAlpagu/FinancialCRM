using FinancialCrm.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace MyFinancialCrm.WebUI.Controllers
{
    // [Authorize]
    public class DashboardController : Controller
    {
        private readonly IBankService _bankService;
        private readonly IExpendService _expenditureService;
        private readonly IBillService _billService;

        public DashboardController(IBankService bankService, IExpendService expenditureService, IBillService billService)
        {
            _bankService = bankService;
            _expenditureService = expenditureService;
            _billService = billService;
        }

        public IActionResult Index()
        {
            var bankList = _bankService.TGetList();

            ViewBag.BankNames = bankList.Select(x => x.BankTitle).ToList();
            ViewBag.BankBalances = bankList.Select(x => x.BankBalance).ToList();

            var totalBalance = bankList.Sum(x => x.BankBalance);
            ViewBag.TotalBalance = totalBalance.ToString("C2");

            // View tarafında kullandığın için BillCount'u da ekleyelim
            ViewBag.BillCount = _billService.TGetList().Count();

            // DashboardController.cs içindeki ilgili kısım:
            var lastExpenditures = _expenditureService.TGetList()
                                    .OrderByDescending(x => x.ExpendId) // Doğrusu bu!
                                    .Take(5)
                                    .ToList();

            return View(lastExpenditures);
        }
    }
}