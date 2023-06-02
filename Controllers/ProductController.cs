using Merchantdized.Data;
using Merchantdized.Model;
using Merchantdized.Model.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Merchantdized.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private  ApiResponse _response;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
            _response = new ApiResponse();

        }

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetProducts()
        {
            _response.Result = _db.Products;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpGet("{id:int}", Name ="GetProduct")]
        public async Task<ActionResult<ApiResponse>> GetProduct(int id)
        {
            if(id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            Product product = _db.Products.FirstOrDefault(u => u.Id == id);
            if(product == null)
            {
                _response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_response);
            }
            _response.Result = product;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateProduct([FromBody] ProductCreateDTO productCreateDTO)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
