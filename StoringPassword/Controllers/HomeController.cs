using Microsoft.AspNetCore.Mvc;

namespace StoringPassword.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("Login") != null)
            return View();

        return RedirectToAction("Login", "Account");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login", "Account");
    }
}