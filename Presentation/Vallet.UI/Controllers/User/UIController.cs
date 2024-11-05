using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers.User
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
