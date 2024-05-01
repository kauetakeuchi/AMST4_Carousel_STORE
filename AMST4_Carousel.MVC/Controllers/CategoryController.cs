using AMST4_Carousel.MVC.Context;
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
    }
}
