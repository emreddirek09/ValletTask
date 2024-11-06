using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
