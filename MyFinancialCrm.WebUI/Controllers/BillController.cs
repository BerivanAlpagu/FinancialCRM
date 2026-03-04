using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[Authorize] // Bu etiketi eklediğin an sayfa şifreli hale gelir
public class BillController : Controller
{
    // ... 
}

namespace FinancialCrm.WebUI.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        // Fatura Listesini Görüntüleme
        [HttpGet]
        public IActionResult Index()
        {
            var values = _billService.TGetList();
            return View(values);
        }

        // Yeni Fatura Ekleme
        [HttpPost]
        public IActionResult CreateBill(Bill bill)
        {
            _billService.TInsert(bill);
            return RedirectToAction("Index");
        }

        // Fatura Silme
        public IActionResult DeleteBill(int id)
        {
            var value = _billService.TGetById(id);
            _billService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}