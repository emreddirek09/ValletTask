using Microsoft.AspNetCore.Mvc;
using Vallet.Application.BaseResult.Concretes;
using Vallet.Domain.DTO;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.UI.Controllers.Admin
{
    public class SiteController : Controller
    {
        readonly IValletClient _valletClient;

        public SiteController(IValletClient valletClient)
        {
            _valletClient = valletClient;
        }
        public async Task<IActionResult> Index()
        {
            DataResult<DtoSite.Root>? result = new();

            result = await _valletClient.GetNoRoot<DtoSite.Root>("Sites/Get");

            return View(result.Data);
             
        }
    }
}
