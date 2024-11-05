using Microsoft.AspNetCore.Mvc;
using Vallet.Application.BaseResult.Concretes;
using Vallet.Domain.DTO;
using Vallet.UI.Helpers.ClientHelper;
using static Vallet.Domain.DTO.DtoUser;

namespace Vallet.UI.Controllers.Admin
{
    public class AdminController : Controller
    {
        readonly IValletClient _valletClient;

        public AdminController(IValletClient valletClient)
        {
            _valletClient = valletClient;
        } 

        public async Task<IActionResult> Index2()
        {
            DataResult<List<DtoUser.Datum>> list = new();

            list = await _valletClient.GetNoRoot<List<DtoUser.Datum>>("Users");

            return View(list.Data);
        }

        public async Task<IActionResult> Index()
        {
            DataResult<List<DtoUser.Datum>>? result = new();

            result = await _valletClient.GetList<DtoUser.Datum>("Users/Get");

            return View(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Id)
        {
            var result = await _valletClient.GetNoRoot<bool>("Users/Delete/?Id=" + Id);
            if (result.Success)
            { 
                return RedirectToAction("index");
            }
             
            return RedirectToAction("index");
        }
    }
}
