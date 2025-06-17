using Categories.Models;
using Microsoft.AspNetCore.Mvc;

namespace Categories.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }
        public IActionResult Edit([FromRoute]int? id)
        {

            //var category = new Category{ Id = id.HasValue? id.Value: 0};
            var category = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);
            return View(category);
        }

        [HttpPost]

        public IActionResult Edit(Category category)
        {
            if(ModelState.IsValid)
            {
                CategoriesRepository.UpdateCategory(category.Id, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
            //return View(category);

        }

    }
}
