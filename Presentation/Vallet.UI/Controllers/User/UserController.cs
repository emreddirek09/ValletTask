using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers.User
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
