using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Vallet.Application.BaseResult.Concretes;
using Vallet.Domain.DTO;
using Vallet.UI.Helpers.ClientHelper;

namespace Vallet.UI.Controllers
{
    public class BlockController : Controller
    {
        readonly IValletClient _valletClient;

        public BlockController(IValletClient valletClient)
        {
            _valletClient = valletClient;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<Vallet.Domain.DTO.DtoBlok> model = new List<Vallet.Domain.DTO.DtoBlok>();

            if (ModelState.IsValid)
                return View(model);
            DataResult<List<DtoSite.Site>> sites = new();
            sites = await _valletClient.GetList<DtoSite.Site>("Sites/GetGroup");

            var siteSelectList = sites.Data
                                .Select(site => new SelectListItem
                                {
                                    Value = site.id.ToString(),
                                    Text = site.siteName
                                })
                                .ToList();

            return View(new Tuple<IEnumerable<DtoBlok>, IEnumerable<SelectListItem>>(model, siteSelectList));

        }


        [HttpPost]
        public async Task<IActionResult> UserCreate(DtoUser.Datum dto)
        {
            var result = await _valletClient.PostAsync<DtoUser.Datum, bool>(dto, "Blok/Post");
            if (result.Success)
            {
                return RedirectToAction("index");
            }
            return RedirectToAction("index");

        }
    }
}
