using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers.Admin
{
    public class DebtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
