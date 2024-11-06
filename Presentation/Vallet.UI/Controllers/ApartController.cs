using Microsoft.AspNetCore.Mvc;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.UI.Controllers
{
    public class ApartController : Controller
    {
        readonly IValletClient _valletClient;

        public ApartController(IValletClient valletClient)
        {
            _valletClient = valletClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPatch]
        public IActionResult CreateApart()
        {
            return View();
        }
    }
}
