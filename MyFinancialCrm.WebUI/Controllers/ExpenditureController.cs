using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FinancialCrm.WebUI.Controllers
{
    public class ExpenditureController : Controller
    {
        
        private readonly IExpendService _expenditureService;
        private readonly ICategoryService _categoryService; // Kategori servisini ekledik

        public ExpenditureController(IExpendService expenditureService, ICategoryService categoryService)
        {
            _expenditureService = expenditureService;
            _categoryService = categoryService; // Dependency Injection ile bağladık
        }

        [HttpGet]
        public IActionResult Index()
        {
            // 1. ÖNCE: Kategorileri çek ve ViewBag'e koy (Dropdown için)
            var categories = _categoryService.TGetList();
            ViewBag.Categories = categories;

            // 2. SONRA: Harcamaları çek
            var values = _expenditureService.TGetList();
            return View(values);
        }

        // Yeni Harcama Ekleme
        [HttpPost]
        public IActionResult CreateExpenditure(Expend expenditure)
        {
            // Harcamanın eklendiği tarihi sistemden otomatik alalım
            expenditure.ExpendDate = DateTime.Now;

            _expenditureService.TInsert(expenditure);
            return RedirectToAction("Index");
        }

        // Harcama Silme
        public IActionResult DeleteExpenditure(int id)
        {
            var value = _expenditureService.TGetById(id);
            _expenditureService.TDelete(value);
            return RedirectToAction("Index");
        }

        // Harcama Güncelleme (Opsiyonel ama profesyonellik katar)
        [HttpGet]
        public IActionResult UpdateExpenditure(int id)
        {
            var categories = _categoryService.TGetList();
            ViewBag.Categories = categories;

            var value = _expenditureService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExpenditure(Expend expenditure)
        {
            _expenditureService.TUpdate(expenditure);
            return RedirectToAction("Index");
        }
    }
}