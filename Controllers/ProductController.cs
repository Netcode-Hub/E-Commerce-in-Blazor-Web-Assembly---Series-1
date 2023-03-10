using Microsoft.AspNetCore.Mvc;
using ORMExplained.Server.Repositories.Interfaces;
using ORMExplained.Shared.DTO;
using ORMExplained.Shared.Models;

namespace ORMExplained.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;
        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        [HttpPost("Add-Product")]
        public async Task<ActionResult<ServiceModel>> AddProduct(Product NewProduct)
        {
            return Ok(await productRepo.AddProduct(NewProduct));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceModel>> GetProducts()
        {
            return Ok(await productRepo.GetProducts());
        }

        [HttpGet("Get-Product/{ProductId:int}")]
        public async Task<ActionResult<ServiceModel>> GetProduct(int ProductId)
        {
            return Ok(await productRepo.GetProduct(ProductId));
        }
    }
}
