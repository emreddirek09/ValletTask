using Microsoft.AspNetCore.Mvc;
using Vallet.Application.BaseResult.Concretes;
using Vallet.Application.Features.Queries.FUser.GetByIdUser;
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
            DataResult<List<DtoUser.Datum>>? result = new();

            result = await _valletClient.GetList<DtoUser.Datum>("Users/Get");

            return View(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> UserCreate(DtoUser.Datum dto)
        {
            var result = await _valletClient.PostAsync<DtoUser.Datum, bool>(dto, "Users/Post");
            if (result.Success)
            {
                return RedirectToAction("index");
            }
            return RedirectToAction("index");

        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string Id)
        { 
            var result = await _valletClient.DeleteAync<bool>($"Users/Delete/{Id}");

            if (result.Success)
            {
                return RedirectToAction("index");
            }

            return RedirectToAction("index");
        }

        [HttpGet]
        public async Task<IActionResult> UserUpdate(string Id)
        {
            DataResult<GetByIdUserQueryResponse>? result = new();

             result = await _valletClient.GetNoRoot<GetByIdUserQueryResponse>($"Users/GetById/{Id}");
            if (result.Success) 
                return View(result.Data);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UserUpdate(GetByIdUserQueryResponse dto)
        {
            var result = await _valletClient.PostAsync<GetByIdUserQueryResponse, bool>(dto, "Users/PuT");
            if (result.Success)
            {
                return RedirectToAction("index");
            }
            return RedirectToAction("index");
        }
    }
}
