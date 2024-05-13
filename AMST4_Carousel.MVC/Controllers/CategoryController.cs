using AMST4_Carousel.MVC.Context;
using AMST4_Carousel.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AMST4_Carousel.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDataContext _applicationDataContext;
        public CategoryController(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }
        public IActionResult CategoryList()
        {
            var categories = _applicationDataContext.Category.ToList();
            return View(categories);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _applicationDataContext.Category.Add(category);
            _applicationDataContext.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        public IActionResult AddCategory()
        {
            return View();
        }
    }
} 