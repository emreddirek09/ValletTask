using Microsoft.AspNetCore.Mvc;

namespace Vallet.UI.Controllers
{
    [Route("/[Controller]/[Action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Test2(string tas)
        {
            return Ok();
        }
    }
}
