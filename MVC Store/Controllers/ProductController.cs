using BusinessLogic.Services;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        ProductService _productService;
        CategoryService _categoryService;
        public ProductController(ProductService productService, CategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            Phone[] phones = _productService.GetAll();
            _categoryService.GetAll();

            return View(phones);
        }

        [HttpGet]
        public IActionResult AddPhone()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPhone(Phone phoneFromForm)
        {
            _productService.Add(phoneFromForm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPhone(int phoneId)
        {
            Phone phone = _productService.Get(phoneId);
            //TODO GetCategories

            return View(phone);
        }
        [HttpPost]
        public IActionResult EditPhone(Phone phoneFromForm)
        {
            _productService.Edit(phoneFromForm);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePhone(int phoneId)
        {
            _productService.Delete(phoneId);
            return RedirectToAction("Index");
        }
    }
}