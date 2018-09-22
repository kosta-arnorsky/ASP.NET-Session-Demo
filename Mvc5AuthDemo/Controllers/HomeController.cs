using FakeBackend;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace Mvc5AuthDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager _userManager;

        public HomeController()
        {
            // Use dependency injection
            _userManager = new UserManager(new { someoption = "somevalue" });
        }

        public ActionResult Index()
        {
            var user = _userManager.GetUser(User.Identity.GetUserId());
            return View(user);
        }
    }
}