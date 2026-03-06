using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCrm.WebUI.Controllers
{
    [Authorize] // Şifrelemeyi buraya koyduk
    public class BankController : Controller
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _bankService.TGetList();
            return View(values);
        }

        [HttpPost]
        public IActionResult CreateBank(Bank bank)
        {
            _bankService.TInsert(bank);
            TempData["SuccessMessage"] = "Bank Account has been added successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBank(int id)
        {
            var value = _bankService.TGetById(id);
            _bankService.TDelete(value); // EKSİKTİ, EKLEDİK!
            TempData["SuccessMessage"] = "The bank account has been deleted successfully.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBank(int id)
        {
            var value = _bankService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBank(Bank bank)
        {
            _bankService.TUpdate(bank);
            TempData["SuccessMessage"] = "Changes saved successfully!";
            return RedirectToAction("Index");
        }
    }
}