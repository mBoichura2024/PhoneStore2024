using Core.Services;
using Infrastructure;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Core.Interfaces;

namespace UI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public ProductController(IProductService productService,
                                 ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            Phone[] phones = await _productService.GetAll();
            await _categoryService.GetAll();

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
            await _productService.Add(phoneFromForm);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditPhone(int phoneId)
        {
            Phone phone = await _productService.Get(phoneId);
            return View(phone);
        }
        [HttpPost]
        public async Task<IActionResult> EditPhone(Phone phoneFromForm)
        {
            await _productService.Update(phoneFromForm);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePhone(int phoneId)
        {
            await _productService.Delete(phoneId);
            return RedirectToAction("Index");
        }
    }
}