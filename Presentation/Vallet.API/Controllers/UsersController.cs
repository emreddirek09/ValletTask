using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vallet.Application.Repositories;
using Vallet.Domain.Entities.Concretes;

namespace Vallet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly private IUserWriteRepository _userWriteRepository;
        readonly private IUserReadRepository _userReadRepository;

        public UsersController(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }

        [HttpGet]
        public async void GET()
        {
            await _userWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), CreatedTime = DateTime.Now, FullName = "Emre Direk", Email = "emreddirek@gmail.com", PhoneNumber = "5332853709", Role = "Admin"},
                new() { Id = Guid.NewGuid(), CreatedTime = DateTime.Now, FullName = "Cemre Erol", Email = "cemre@gmail.com", PhoneNumber = "5453404182", Role = "Admin"},
                new() { Id = Guid.NewGuid(), CreatedTime = DateTime.Now, FullName = "Doruk", Email = "doruk@gmail.com", PhoneNumber = "5352808161", Role = "user"}
            });

            var count = _userWriteRepository.SaveAsync();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GET(string id)
        {
            User user = await _userReadRepository.GetByIdAsync(id);
            return Ok(user);
        }
    }
}
