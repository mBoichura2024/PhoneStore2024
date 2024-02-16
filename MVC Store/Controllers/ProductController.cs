using BusinessLogic.Services;
using DataAccess;
using DataAccess.Entities;
<<<<<<< Updated upstream
=======
using Microsoft.AspNetCore.Authorization;
>>>>>>> Stashed changes
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        ProductService _productService;
        CategoryService _categoryService;
<<<<<<< Updated upstream
        public ProductController(ProductService productService, CategoryService categoryService)
=======
        public ProductController(ProductService productService,
                                 CategoryService categoryService)
>>>>>>> Stashed changes
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
<<<<<<< Updated upstream
            Phone[] phones = _productService.GetAll();
            _categoryService.GetAll();
=======
            Phone[] phones = await _productService.GetAll();
            await _categoryService.GetAll();
>>>>>>> Stashed changes

            return View(phones);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddPhone()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPhone(Phone phoneFromForm)
        {
<<<<<<< Updated upstream
            _productService.Add(phoneFromForm);
=======
            await _productService.Add(phoneFromForm);
>>>>>>> Stashed changes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPhone(int phoneId)
        {
<<<<<<< Updated upstream
            Phone phone = _productService.Get(phoneId);
            //TODO GetCategories

=======
            Phone phone = await _productService.Get(phoneId);
>>>>>>> Stashed changes
            return View(phone);
        }
        [HttpPost]
        public async Task<IActionResult> EditPhone(Phone phoneFromForm)
        {
<<<<<<< Updated upstream
            _productService.Edit(phoneFromForm);
=======
            await _productService.Update(phoneFromForm);
>>>>>>> Stashed changes
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePhone(int phoneId)
        {
<<<<<<< Updated upstream
            _productService.Delete(phoneId);
=======
            await _productService.Delete(phoneId);
>>>>>>> Stashed changes
            return RedirectToAction("Index");
        }
    }
}