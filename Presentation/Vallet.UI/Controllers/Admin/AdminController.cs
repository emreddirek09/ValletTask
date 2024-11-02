using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
