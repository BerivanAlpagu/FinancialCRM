using FinancialCrm.BusinessLayer.Abstract;
using FinancialCrm.BusinessLayer.Helpers;
using FinancialCrm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyFinancialCrm.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // Practice: Explicitly allow GET requests for the logout link
        public async Task<IActionResult> Logout()
        {
            // Sistemdeki giriş çerezini temizler
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Çıkış yaptıktan sonra kullanıcıyı tekrar giriş sayfasına gönderir
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            // 1. Find the user in Database
            var currentUser = _userService.TGetList().FirstOrDefault(x => x.Username == user.Username);

            if (currentUser != null)
            {
                // 2. Practice: Compare the entered password with the Hashed password in DB
                if (PasswordHelper.VerifyPassword(user.Password, currentUser.Password))
                {
                    // 3. Create an identity claim (Identity Card)
                    var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, currentUser.Username)
            };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // 4. Sign in the user to the system
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    return RedirectToAction("Index", "Dashboard");
                }
            }

            ViewBag.ErrorMessage = "Invalid username or password!";
            return View();
        }

}
}

