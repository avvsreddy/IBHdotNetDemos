using CoolProductsCatalogService.Model.DataAccess;
using CoolProductsCatalogService.Model.Entities;
using Microsoft.AspNet.OData;
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
        [EnableQuery]
        public IActionResult GetAllProducts()
        {
            return Ok(repo.GetProducts().AsQueryable());
        }

        // get product by id
        // .../api/coolproducts/1

        //[HttpGet]
        //[Route("{id}")]
        //public IActionResult GetProductById(int id)
        //{
        //    Product p = repo.GetProductById(id);
        //    if (p == null) // not found
        //    {
        //        // return http status code 404
        //        return NotFound();

        //    }
        //    else //found
        //    {
        //        // return http status code 200 with data
        //        return Ok(p);
        //    }
        //}

        //// search by name
        //// GET.../api/coolproducts/name/iphone
        //[HttpGet]
        //[Route("name/{pname}")]
        //public IActionResult GetProductByName(string pname)
        //{
        //    Product p = repo.GetProductByName(pname);
        //    if (p == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(p);
        //    }
        //}

        //// get products by price
        //// .../api/coolproducts/price/60000
        //[HttpGet]
        //[Route("price/{price}")]
        //public IActionResult GetProductByPrice(double price)
        //{
        //    var products = repo.GetProductsByPrice(price);
        //    if (products == null || products.Count == 0)
        //        return NotFound();
        //    return Ok(products);

        //}

        //// get by brand
        //// .../api/coolproducts/brand/apple
        //[HttpGet]
        //[Route("brand/{brand}")]
        //public IActionResult GetProductsByBrand(string brand)
        //{
        //    var products = repo.GetProductsByBrand(brand);
        //    if (products == null || products.Count == 0)
        //        return NotFound();
        //    return Ok(products);
        //}

        //// get by country
        //// .../api/coolproducts/country/india
        //[HttpGet]
        //[Route("country/{country}")]
        //public IActionResult GetProductsByCountry(string country)
        //{
        //    var products = repo.GetProductsByCountry(country);
        //    if (products == null || products.Count == 0)
        //        return NotFound();
        //    return Ok(products);
        //}

        //// get products by price range
        //// .../api/coolproducts/price/min/4000/max/8000
        //[HttpGet]
        //[Route("price/min/{min}/max/{max}")]
        //public IActionResult GetProductsByPriceRange(double min, double max)
        //{
        //    var products = from p in repo.GetProducts()
        //                   where p.Price >= min && p.Price <= max
        //                   select p;
        //    if (products == null || products.Count() == 0)
        //        return NotFound();
        //    return Ok(products);

        //}

        //// get by catagory
        //[HttpGet]
        //[Route("catagory/{catagory}")]
        //public IActionResult GetProductsByCatagory(string catagory)
        //{
        //    var products = repo.GetProductsByCatagory(catagory);
        //    if (products == null || products.Count == 0)
        //        return NotFound();
        //    return Ok(products);
        //}

        // save
        // POST .../api/coorproducts

        [HttpPost]
        public IActionResult PostProducts(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid product data");
            }
            repo.AddProduct(product);
            // status code - 201/location/data
            return Created($"api/coolproducts/{product.ProductID}", product);
        }

        //update
        [HttpPut]
        public IActionResult PutProducts(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid product data");
            }
            repo.UpdateProduct(product);
            // status code - 201/location/data
            return Ok();
        }
        // delete
        //[Authorize]
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            Product p = repo.GetProductById(id);
            if (p == null) // not found
            {
                return NotFound();

            }
            else //found
            {
                repo.DeleteProduct(id);
                return Ok();
            }
        }
    }
}
