using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers
{
    public class DebtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
