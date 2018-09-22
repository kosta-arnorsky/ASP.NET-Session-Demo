using FakeBackend;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Mvc5AuthDemo.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Mvc5AuthDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager _userManager;

        public AccountController()
        {
            // Use dependency injection
            _userManager = new UserManager(new { someoption = "somevalue" });
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _userManager.GetUser(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("auth", "Invalid credentials.");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username)
            };
            var identity = new ClaimsIdentity(claims, DefaultAuthenticationTypes.ApplicationCookie);
            AuthenticationManager.SignIn(identity);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login");
        }
    }
}