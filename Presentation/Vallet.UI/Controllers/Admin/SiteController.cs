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

            DataResult<List<DtoSite.Site>>? result = new();

            result = await _valletClient.GetList<DtoSite.Site>("Sites/Get");

            return View(result.Data);

        }

        [HttpPost]
        public async Task<IActionResult> DeleteSite(string Id)
        {
            var result = await _valletClient.DeleteAync<bool>($"Sites/Delete/{Id}");

            if (result.Success)
            {
                return RedirectToAction("index");
            }

            return RedirectToAction("index");
        }
        [HttpPost]
        public async Task<IActionResult> SiteCreate(DtoSite.Site dto)
        {
            var result = await _valletClient.PostAsync<DtoSite.Site, bool>(dto, "Sites/Post");
            if (result.Success)
            {
                return RedirectToAction("index");
            }
            return RedirectToAction("index");

        } 
    }
}
