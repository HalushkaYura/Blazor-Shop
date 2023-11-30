using Microsoft.AspNetCore.Mvc;
using MintStores.Core;
using MintStores.Core.Model;
using MintStores.Core.Services;
using System.Data.SqlClient;

namespace MintStores.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IBaseService<Product> _baseProductService;
        private readonly IProductService _productService;
        private readonly ILogger<CategoryController> _logger;

        public ProductController(ILogger<CategoryController> logger, IBaseService<Product> baseService, IProductService productService)
        {
            _logger = logger;
            _baseProductService = baseService;
            _productService = productService;               
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _baseProductService.GetAllItems(); 
                return Ok(products);
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        [HttpGet("GetProductById{id}")]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var products = _baseProductService.GetItemById(id);
                return Ok(products);
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var created = _baseProductService.CreateItem(product);
                return Ok();
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        [HttpPut("UpdateProduct{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            
            try
            {
                var updated = _baseProductService.UpdateItem(id, updatedProduct);
                return Ok();
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        [HttpDelete("DeleteProduct{id}")]
        public IActionResult DeleteProduct(int id)
        {

            try
            {
                var deleted = _baseProductService.DeleteItem(id);
                return Ok();
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        [HttpGet("GetAllProductByCategory/{categoryId}")]
        public IActionResult GetProductsByCategory(int categoryId)
        {

            try
            {
                var products = _productService.GetProductsByCategory(categoryId);
                return Ok(products);
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }
    }
}
