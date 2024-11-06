using Microsoft.AspNetCore.Mvc;
using Vallet.Application.BaseResult.Concretes;
using Vallet.Domain.DTO;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.UI.Controllers
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
            IEnumerable<Vallet.Domain.DTO.DtoBlok> model = new List<Vallet.Domain.DTO.DtoBlok>();
            DataResult<List<DtoSite.Site>>? result = new();
            result = await _valletClient.GetList<DtoSite.Site>("Sites/Get");
            if (result.Data is null)
                return View(model);
            else
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
