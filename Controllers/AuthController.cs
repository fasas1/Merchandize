using Merchantdized.Data;
using Merchantdized.Model;
using Merchantdized.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Merchantdized.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private ApiResponse _response;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationUser> _roleManager;
        public string secretKey;

        public AuthController(ApplicationDbContext db, IConfiguration configuration,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationUser> roleManager)
        {
            _db = db;
            _response = new ApiResponse();
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task <IActionResult> Register([FromBody] RegisterRequestDTO model)
        {
            ApplicationUser userFromDb = _db.ApplicationUsers.FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());
            if (userFromDb == null)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.ErrorMessages.Add("User Already Exist");
                return BadRequest(_response);
            }
        }
    }
}
