using Categories.Models;
using Microsoft.AspNetCore.Mvc;

namespace Categories.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts();
            return View(products);
            //returnView(Product);
          
        }
    }
}
