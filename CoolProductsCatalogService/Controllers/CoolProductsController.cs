using CoolProductsCatalogService.Model.DataAccess;
using CoolProductsCatalogService.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoolProductsCatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolProductsController : ControllerBase
    {
        private IProductsRepository repo = new ProductsRepository();

        // design the end point - uri
        // all products
        // GET .../api/coolproducts
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return repo.GetProducts();
        }

        // get product by id
        // .../api/coolproducts/1

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product p = repo.GetProductById(id);
            if (p == null) // not found
            {
                // return http status code 404
                return NotFound();

            }
            else //found
            {
                // return http status code 200 with data
                return Ok(p);
            }
        }

        // search by name
        // GET.../api/coolproducts/name/iphone
        [HttpGet]
        [Route("name/{pname}")]
        public IActionResult GetProductByName(string pname)
        {
            Product p = repo.GetProductByName(pname);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(p);
            }
        }

        // get products by price
        // .../api/coolproducts/price/60000
        [HttpGet]
        [Route("price/{price}")]
        public IActionResult GetProductByPrice(double price)
        {
            var products = repo.GetProductsByPrice(price);
            if (products == null || products.Count == 0)
                return NotFound();
            return Ok(products);

        }

        // get by brand
        // .../api/coolproducts/brand/apple
        [HttpGet]
        [Route("brand/{brand}")]
        public IActionResult GetProductsByBrand(string brand)
        {
            var products = repo.GetProductsByBrand(brand);
            if (products == null || products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        // get by country
        // .../api/coolproducts/country/india
        [HttpGet]
        [Route("country/{country}")]
        public IActionResult GetProductsByCountry(string country)
        {
            var products = repo.GetProductsByCountry(country);
            if (products == null || products.Count == 0)
                return NotFound();
            return Ok(products);
        }

        // get products by price range
        // .../api/coolproducts/price/min/4000/max/8000
        [HttpGet]
        [Route("price/min/{min}/max/{max}")]
        public IActionResult GetProductsByPriceRange(double min, double max)
        {
            var products = from p in repo.GetProducts()
                           where p.Price >= min && p.Price <= max
                           select p;
            if (products == null || products.Count() == 0)
                return NotFound();
            return Ok(products);

        }

        // get by catagory

        // save
        //update
        // delete

    }
}
