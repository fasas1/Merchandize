using Merchantdized.Data;
using Merchantdized.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Merchantdized.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityUser> _roleManager;
        private string secretKey;
        private ApiResponse _response;

        public AuthController(ApplicationDbContext db, IConfiguration configuration,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityUser> roleManager)
        {
            _db = db;
            secretKey = configuration.GetValue<string>("ApiSettings:SecretKey");
            _response = new ApiResponse();
            _userManager = userManager;
            _roleManager = roleManager;
        }
    }
}
