using FakeBackend;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core2AuthDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager _userManager;

        public HomeController(UserManager userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var profile = _userManager.GetProfile(User.Identity.Name);
            return View(profile);
        }
    }
}