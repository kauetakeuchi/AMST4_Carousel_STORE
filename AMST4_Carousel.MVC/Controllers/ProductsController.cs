using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AMST4_Carousel.MVC.Context;
using AMST4_Carousel.MVC.Models;

namespace AMST4_Carousel.MVC.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDataContext _context;

    public ProductController(ApplicationDataContext context)
    {
        _context = context;
    }

    public IActionResult ProductList()
    {
        var Product = _context.Product.ToList();
        return View(Product);
    }

    public IActionResult AddProduct()
    {
        return View();
    }

    [HttpPost]

    public IActionResult AddProduct(Product product)
    {
            product.Id = Guid.NewGuid();
            _context.Add(product);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
    }

}