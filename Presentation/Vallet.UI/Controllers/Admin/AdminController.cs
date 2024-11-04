using Microsoft.AspNetCore.Mvc;
using Vallet.Domain.DTO;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.UI.Controllers.Admin
{
    public class AdminController : Controller
    {
        readonly IValletClient _valletClient;

        public AdminController(IValletClient valletClient)
        {
            _valletClient = valletClient;
        } 
        public async Task<IActionResult> Index()
        {
            var list = await _valletClient.GetNoRoot<List<DtoUser>>("Users");
            return View(list.Data);
        }
    }
}
